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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;

namespace FluxoFacil.Apresentacao
{
    public partial class frmAddCategoria : Form
    {
        public int? ID {  get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string ButtonText { set { btnSalvar.Text = value; } }

        public frmAddCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void SalvarDados()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Preencha o campo descrição", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbCommand cmd = conn.CreateCommand();

                    if (string.IsNullOrWhiteSpace(txtID.Text)) // INSERIR
                    {
                        cmd.CommandText = "INSERT INTO CATEGORIA (Descricao, Observacao) VALUES (@d1, @d2)";
                    }
                    else // ATUALIZAR
                    {
                        cmd.CommandText = "UPDATE CATEGORIA SET Descricao = @d1, Observacao = @d2 WHERE ID = @d3";
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@d1", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@d2", txtObservacao.Text);

                    if (!string.IsNullOrWhiteSpace(txtID.Text))
                    {
                        cmd.Parameters.AddWithValue("@d3", Convert.ToInt32(txtID.Text));
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmAddCategoria_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                txtID.Text = ID.ToString();
                txtDescricao.Text = Descricao;
                txtObservacao.Text = Observacao;
                btnSalvar.Text = "  Atualizar";
            }
            else
            {
                btnSalvar.Text = "  Salvar";
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
