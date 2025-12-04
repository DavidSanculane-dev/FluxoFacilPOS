using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            CarregarDados();
            AtivarBotao();
            btnSalvar.Visible = false;
            btnApagar.Visible = true;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmarSenha.Enabled = false;
            cboTipoAcesso.Enabled = false;
        }

        private void CarregarDados()
        {
            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (FbCommand cmd = new FbCommand("SELECT USUARIO FROM USUARIO ORDER BY USUARIO", conn))
                    {
                        using (FbDataReader rdr = cmd.ExecuteReader())
                        {
                            listaUsuarios.Items.Clear();
                            while (rdr.Read())
                            {
                                listaUsuarios.Items.Add(rdr[0].ToString());
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdicionarUsuario()
        {
            try
            {
                string connString = new dbconnection().dbconnect().ToString();
                using (FbConnection conn = new FbConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO USUARIO (USUARIO, SENHA, TIPO_USUARIO) VALUES (@USUARIO, @SENHA, @TIPO_USUARIO)";
                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@USUARIO", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@SENHA", txtSenha.Text.Trim());
                        cmd.Parameters.AddWithValue("@TIPO_USUARIO", cboTipoAcesso.Text.Trim());

                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {

                            MessageBox.Show("Usuário adicionado com sucesso", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao adicionar usuário", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtivarBotao()
        {
            if (txtUsuario.Text == "")
            {
                btnSalvar.Visible = true;
            }
            else
            {
                btnSalvar.Visible = false;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmarSenha.Enabled = true;
            cboTipoAcesso.Enabled = true;
            txtUsuario.Focus();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DeleteUsuario();
            CarregarDados();
        }

        private void DeleteUsuario()
        {
            try
            {
                string connString = new dbconnection().dbconnect().ToString();
                using (FbConnection conn = new FbConnection(connString))
                {
                    conn.Open();

                    string username = listaUsuarios.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Selecione um usuário da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "DELETE FROM USUARIO WHERE USUARIO = @usuario";
                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", username);
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {

                            MessageBox.Show("Usuário apagado com sucesso", "Eliminas usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao apagar usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Adicionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.SelectAll();
                txtConfirmarSenha.SelectAll();
                txtSenha.Focus();
                return;
            }
            else
            {
                AdicionarUsuario();
                CarregarDados();
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtConfirmarSenha.Enabled = false;
                cboTipoAcesso.Enabled = false;

                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                cboTipoAcesso.Text = "";

            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
