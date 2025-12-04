using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using Microsoft.Office.Interop.Excel;
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
    public partial class frmAddSolicitacoes : Form
    {
        public int? ID { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public string EstadoPedido { get; set; }
        public DateTime Data_Solicitacao { get; set; }
        public string ButtonText { set { btnSalvar.Text = value; } }

        public frmAddSolicitacoes()
        {
            InitializeComponent();
        }

        private void txtProcurarNInterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarDados_Click(object sender, EventArgs e)
        {
            BuscarNomePorNInterno();
        }
        private void BuscarNomePorNInterno()
        {

            string connString = new dbconnection().dbconnect().ToString();
            string ninterno = txtProcurarNInterno.Text.Trim(); // txtCodigo é o TextBox com o filtro

            if (string.IsNullOrEmpty(ninterno))
            {
                MessageBox.Show("Informe um Nº Interno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NOME, EMPRESA, DEPARTAMENTO, CENTROCUSTO FROM COLABORADORES WHERE NINTERNO = @NINTERNO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NINTERNO", ninterno);

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNomeColaborador.Text = reader["NOME"].ToString();
                                lblDepartamento.Text = reader["DEPARTAMENTO"].ToString();
                            }
                            else
                            {
                                lblNomeColaborador.Text = "Colaborador não encontrado.";
                                lblDepartamento.Text = "---";
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar nome: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(lblNomeColaborador.Text) || string.IsNullOrWhiteSpace(lblDepartamento.Text))
            {
                MessageBox.Show("Preencha o campo Nome e Departamento", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Preencha o campo Descrição do material", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboEstadoPedido.Text))
            {
                MessageBox.Show("Preencha o estado do pedido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtPicker.Text))
            {
                MessageBox.Show("Preencha a Data da Solicitação", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string descricao = txtDescricao.Text;
                    string data_solicitacao = dtPicker.Text;
                    string nome = lblNomeColaborador.Text;
                    string departamento = lblDepartamento.Text;
                    string estado = cboEstadoPedido.Text;


                    if (string.IsNullOrWhiteSpace(txtID.Text)) // INSERIR
                    {
                        cmd.CommandText = @"INSERT INTO SOLICITACOES (DESCRICAO, DATA_SOLICITACAO, NOME, DEPARTAMENTO, ESTADO) VALUES (@DESCRICAO, @DATA_SOLICITACAO, @NOME, @DEPARTAMENTO, @ESTADO)";
                    }
                    else // ATUALIZAR
                    {
                        cmd.CommandText = cmd.CommandText = @"
                    UPDATE SOLICITACOES SET 
                    DESCRICAO = @DESCRICAO, 
                    DATA_SOLICITACAO = @DATA_SOLICITACAO, 
                    NOME = @NOME, 
                    DEPARTAMENTO = @DEPARTAMENTO, 
                    ESTADO = @ESTADO
                    WHERE ID = @ID";

                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                    }

                    // Adiciona os parâmetros comuns
                    cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                    cmd.Parameters.AddWithValue("@DATA_SOLICITACAO", data_solicitacao);
                    cmd.Parameters.AddWithValue("@NOME", nome);
                    cmd.Parameters.AddWithValue("@DEPARTAMENTO", departamento);
                    cmd.Parameters.AddWithValue("@ESTADO", estado);

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

        private void frmAddSolicitacoes_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                txtID.Text = ID.ToString();
                lblNomeColaborador.Text = Nome;
                lblDepartamento.Text = Departamento;
                txtDescricao.Text = Descricao;
                cboEstadoPedido.Text = EstadoPedido;
                dtPicker.Text = Data_Solicitacao.ToString();
                btnSalvar.Text = "Atualizar";
            }
            else
            {
                btnSalvar.Text = "Salvar";
            }

        }
    }
}
