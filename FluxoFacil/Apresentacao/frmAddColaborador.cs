using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmAddColaborador : Form
    {
        public int? ID {  get; set; }
        public int? NInterno { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Departamento { get; set; }
        public string CentroCusto { get; set; }
        public string Observacao { get; set; }
        public string ButtonText { set { btnSalvar.Text = value; } }

        public frmAddColaborador()
        {
            InitializeComponent();
            CarregarDepartamento();
        }

        private void CarregarDepartamento()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT DESCRICAO FROM DEPARTAMENTO ORDER BY DESCRICAO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        cboDepartamento.Items.Clear();

                        while (reader.Read())
                        {
                            string categoria = reader["DESCRICAO"].ToString();
                            if (!string.IsNullOrWhiteSpace(categoria))
                                cboDepartamento.Items.Add(categoria);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void SalvarDados()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboEmpresa.Text))
            {
                MessageBox.Show("Preencha o campo Empresa", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboCC.Text))
            {
                MessageBox.Show("Preencha o campo Centro de Custo", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboDepartamento.Text))
            {
                MessageBox.Show("Preencha o campo Departamento", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbCommand cmd = conn.CreateCommand();
                    cmd.Parameters.Clear();

                    // Captura e validação dos dados
                    string ninterno = txtNInterno.Text;
                    string nome = txtNome.Text;
                    string empresa = cboEmpresa.Text;
                    string departamento = cboDepartamento.Text;
                    string centroCusto = cboCC.Text;
                    string observacao = txtObservacao.Text;


                    if (string.IsNullOrWhiteSpace(txtID.Text)) // INSERIR
                    {
                        cmd.CommandText = @"INSERT INTO COLABORADORES (NINTERNO, NOME, EMPRESA, DEPARTAMENTO, CENTROCUSTO, OBSERVACAO) VALUES (@NINTERNO, @NOME, @EMPRESA, @DEPARTAMENTO, @CENTROCUSTO, @OBSERVACAO)";
                    }
                    else // ATUALIZAR
                    {
                        cmd.CommandText = cmd.CommandText = @"
                    UPDATE COLABORADORES SET 
                    NINTERNO = @NINTERNO, 
                    NOME = @NOME, 
                    EMPRESA = @EMPRESA, 
                    DEPARTAMENTO = @DEPARTAMENTO, 
                    CENTROCUSTO = @CENTROCUSTO, 
                    OBSERVACAO = @OBSERVACAO 
                    WHERE ID = @ID";

                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                    }

                    // Adiciona os parâmetros comuns
                    cmd.Parameters.AddWithValue("@NINTERNO", ninterno);
                    cmd.Parameters.AddWithValue("@NOME", nome);
                    cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                    cmd.Parameters.AddWithValue("@DEPARTAMENTO", departamento);
                    cmd.Parameters.AddWithValue("@CENTROCUSTO", centroCusto);
                    cmd.Parameters.AddWithValue("@OBSERVACAO", observacao);

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

    

        private void frmAddColaborador_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                txtID.Text = ID.ToString();
                txtNInterno.Text = NInterno.ToString();
                txtNome.Text = Nome;
                cboEmpresa.Text = Empresa;
                cboDepartamento.Text = Departamento;
                cboCC.Text = CentroCusto;
                txtObservacao.Text = Observacao;
                btnSalvar.Text = "Atualizar";
            }
            else
            {
                btnSalvar.Text = "Salvar";
            }
            

        }
    }
}
