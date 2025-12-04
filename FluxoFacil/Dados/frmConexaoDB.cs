using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Apresentacao;
using Microsoft.Office.Interop.Excel;

namespace FluxoFacil.Dados
{
    public partial class frmConexaoDB : Form
    {

        private bool abrirLoginAoFechar = true;

        public frmConexaoDB()
        {
            InitializeComponent();
            
        }

        string filePath;
        string connString;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (abrirLoginAoFechar)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //User=SYSDBA;Password=masterkey;Database=C:\\MeusProjetos\\estoque.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8

            filePath = System.Environment.CurrentDirectory.ToString() + "\\dir.txt";

            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string banco = txtBancoDados.Text.Trim();
            string servidor = txtServidor.Text.Trim();
            string porta = txtPorta.Text.Trim();


            connString = $"User={usuario};Password={senha};Database={banco};DataSource={servidor};Port={porta};Dialect=3;Charset=UTF8;";


           // connString = "User=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";Database=" + txtBancoDados.Text + ";DataSource=" + txtServidor.Text + ";Port=" + txtPorta.Text + ";Dialect=3;Charset=UTF8;";

            try
            {
                File.WriteAllText(filePath, connString);

                MessageBox.Show("Caminho de banco de dados salvo com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao salvar o caminho" + ex.Message);
            }
        }
        void TesteConexao()
        {
            //User=SYSDBA;Password=masterkey;Database=C:\\MeusProjetos\\estoque.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8


            filePath = System.Environment.CurrentDirectory.ToString() + "\\dir.txt";

            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string banco = txtBancoDados.Text.Trim();
            string servidor = txtServidor.Text.Trim();
            string porta = txtPorta.Text.Trim();

            connString = $"User={usuario};Password={senha};Database={banco};DataSource={servidor};Port={porta};Dialect=3;Charset=UTF8;";

            //connString = "User=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";Database=" + txtBancoDados.Text + ";DataSource=" + txtServidor.Text + ";Port=" + txtPorta.Text + ";Dialect=3;Charset=UTF8;";

            try
            {
                File.WriteAllText(filePath, connString);

                MessageBox.Show("Clique OK para prosseguir com o Teste...");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao encontrar o caminho de banco de dados" + ex.Message);
            }

        }

        private void btnTestarConexão_Click(object sender, EventArgs e)
        {
            TesteConexao();

            //Criar a conexao Firebird
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Banco de dados conectado com Sucesso.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha ao conectar com o banco de dados" + ex.Message);
                }
            }
        }

        private void frmConexaoDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (abrirLoginAoFechar)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            
            
        }
    }
}
