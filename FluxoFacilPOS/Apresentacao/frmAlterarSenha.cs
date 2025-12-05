using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            AlterarSenha();
        }

        private void AlterarSenha()
        {
            try
            {
                int rowsAffected = 0;

                if (string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    MessageBox.Show("Por favor insira o nome do utlizador", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSenhaAntiga.Text))
                {
                    MessageBox.Show("Por favor insira antiga palavra-passe", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenhaAntiga.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
                {
                    MessageBox.Show("Por favor insira nova palavra-passe", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovaSenha.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtConfirmarNovaSenha.Text))
                {
                    MessageBox.Show("Por favor confirme a palavra-passe", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmarNovaSenha.Focus();
                    return;
                }

                if (txtNovaSenha.Text.Length < 5)
                {
                    MessageBox.Show("A nova palavra-passe tem que ter no mínimo 5 Caracteres", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovaSenha.Clear();
                    txtConfirmarNovaSenha.Clear();
                    txtNovaSenha.Focus();
                    return;
                }
                else if (txtNovaSenha.Text != txtConfirmarNovaSenha.Text)
                {
                    MessageBox.Show("A nova palavra-passe não conscide", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovaSenha.Clear();
                    txtSenhaAntiga.Clear();
                    txtConfirmarNovaSenha.Clear();
                    txtSenhaAntiga.Focus();
                    return;
                }
                else if (txtSenhaAntiga.Text == txtNovaSenha.Text)
                {
                    MessageBox.Show("A palavra-passe é a mesma...insira uma nova palavra-passe!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNovaSenha.Clear();
                    txtConfirmarNovaSenha.Clear();
                    txtNovaSenha.Focus();
                    return;
                }
                string connString = new dbconnection().dbconnect().ToString();
                using (FbConnection conn = new FbConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE USUARIO SET Senha = @novaSenha WHERE Usuario = @usuario AND Senha = @senhaAntiga";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@novaSenha", txtNovaSenha.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtUser.Text);
                        cmd.Parameters.AddWithValue("@senhaAntiga", txtSenhaAntiga.Text);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Senha atualizada com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmLogin login = new frmLogin();
                    login.Show();

                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválida", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    txtSenhaAntiga.Clear();
                    txtNovaSenha.Clear();
                    txtConfirmarNovaSenha.Clear();
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAlterarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
