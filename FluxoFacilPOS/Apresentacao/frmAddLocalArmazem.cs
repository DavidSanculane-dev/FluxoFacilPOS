using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmAddLocalArmazem : Form
    {
        public int? ID {  get; set; }
        public string LocalArmazem { get; set; }
        public string Observacao { get; set; }
        public string ButtonText { set { btnSalvar.Text = value; } }

        public frmAddLocalArmazem()
        {
            InitializeComponent();
        }

        private void frmAddLocalArmazem_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                txtID.Text = ID.ToString();
                txtLocalArmazem.Text = LocalArmazem;
                txtObservacao.Text = Observacao;
                btnSalvar.Text = "  Atualizar";
            }
            else
            {
                btnSalvar.Text = "  Salvar";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void SalvarDados()
        {
            if (string.IsNullOrWhiteSpace(txtLocalArmazem.Text))
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
                        cmd.CommandText = "INSERT INTO LOCAL_ARMAZEM (Descricao, Observacao) VALUES (@d1, @d2)";
                    }
                    else // ATUALIZAR
                    {
                        cmd.CommandText = "UPDATE LOCAL_ARMAZEM SET Descricao = @d1, Observacao = @d2 WHERE ID = @d3";
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@d1", txtLocalArmazem.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
