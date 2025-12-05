using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
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
    public partial class frmLogin : Form
    {

        private bool permitirFechar = true;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCaminhoBanco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            permitirFechar = false;
            this.Hide();
            frmConexaoDB conexao = new frmConexaoDB();
            conexao.ShowDialog();
             
            
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (permitirFechar)
            {
                Environment.Exit(0);

            }

        }

        private void btnAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            permitirFechar = false;
            this.Hide();
            frmAlterarSenha frm = new frmAlterarSenha();
            frm.ShowDialog();
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            string usuario = txtUser.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string horaLogin = DateTime.Now.ToString();
            string tipoUsuario = string.Empty;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM USUARIO WHERE Usuario =@usuario AND senha =@senha";
                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        // Adiciona os parâmetros na ordem correta  
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tipoUsuario = reader["Tipo_Usuario"].ToString();
                                this.Hide();
                                frmPrincipal main = new frmPrincipal
                                {
                                    
                                    Usuario = usuario,
                                    TipoUsuario = tipoUsuario
                                };
                                
                                main.ShowDialog();
                                
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
