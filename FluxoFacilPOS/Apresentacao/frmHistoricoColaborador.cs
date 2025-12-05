using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using FluxoFacil.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmHistoricoColaborador : Form
    {
        public string numeroInterno { get; set; }

        public frmHistoricoColaborador()
        {
            InitializeComponent();
            CriarTabelaComAcoes();
        }

        private void frmHistoricoColaborador_Load(object sender, EventArgs e)
        {
            txtProcurarNInterno.Text = numeroInterno;
            CarregarDados();
        }

        private void CarregarDados()
        {
            string nomeColaborador = lblNomeColaborador.Text.Trim();

            if (string.IsNullOrEmpty(nomeColaborador))
            {
                MessageBox.Show("O nome do colaborador está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM MOVIMENTOS WHERE COLABORADOR = @nomeColaborador AND DATA_MOVIMENTO >= CURRENT_DATE - 30";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeColaborador", nomeColaborador);

                        using (FbDataAdapter adapter = new FbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvPrincipal.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CriarTabelaComAcoes()
        {
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Dock = DockStyle.Fill;
            dgvPrincipal.AutoGenerateColumns = false;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.RowHeadersVisible = true;
            dgvPrincipal.AllowUserToAddRows = false;

            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID", Name = "ID", Width = 50, Visible = false });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Pedido", DataPropertyName = "Pedido_No", Name = "Pedido_No", Width = 80 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data", DataPropertyName = "Data_Movimento", Name = "Data_Movimento", Width = 130 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição", DataPropertyName = "Descricao", Name = "Descricao", Width = 200 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quanti.", DataPropertyName = "Quantidade", Name = "Quantidade", Width = 80 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nome do Colaborador", DataPropertyName = "Colaborador", Name = "Colaborador", Width = 200 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Empresa", DataPropertyName = "Empresa", Name = "Empresa", Width = 150 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Departamento", DataPropertyName = "Departamento", Name = "Departamento", Width = 140 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CC", DataPropertyName = "CentroCusto", Name = "CentroCusto", Width = 80 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo de Uso", DataPropertyName = "Finalidade", Name = "Finalidade", Width = 150 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Entregue Por", DataPropertyName = "Entregue_Por", Name = "Entregue_Por", Width = 160 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Local de Aplicação", DataPropertyName = "Lugar_Uso", Name = "Lugar_Uso", Width = 160 });

            

            // Estilo de cabeçalho e células
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvPrincipal.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPrincipal.EnableHeadersVisualStyles = false;



            pnlDgv.Controls.Add(dgvPrincipal);
        }

        private async void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (frmLoading loading = new frmLoading())
            {
                loading.Show();

                await Task.Run(() =>
                {
                    ExcelExportImport exportImportExcel = new ExcelExportImport();
                    exportImportExcel.ExportExcel(dgvPrincipal);
                });

                loading.Close();
            }
        }

        private void txtProcurarNInterno_TextChanged(object sender, EventArgs e)
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
                txtProcurarNInterno.Focus();
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
                                lblNomeColaborador.ForeColor = Color.Black;
                                lblNomeColaborador.Text = reader["NOME"].ToString();
                                lblDepartamento.Text = reader["DEPARTAMENTO"].ToString();
                            }
                            else
                            {
                                lblNomeColaborador.Text = "Colaborador não encontrado.";
                                lblNomeColaborador.ForeColor = Color.Red;
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

        private void txtPesquisarDescricao_TextChanged(object sender, EventArgs e)
        {
            ProcurarPorDescricao();
        }

        private void ProcurarPorDescricao()
        {
            string nomeColaborador = lblNomeColaborador.Text.Trim();

            string connString = new dbconnection().dbconnect().ToString();
            string descricaoBusca = txtPesquisarDescricao.Text.Trim();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM MOVIMENTOS WHERE UPPER(DESCRICAO) LIKE @DESCRICAO AND COLABORADOR = @nomeColaborador AND DATA_MOVIMENTO >= CURRENT_DATE - 30";
                    FbDataAdapter adapter = new FbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@DESCRICAO", $"%{descricaoBusca.ToUpper()}%");
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeColaborador", nomeColaborador);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPrincipal.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
