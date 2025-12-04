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
    public partial class frmSolicitacoes : Form
    {
        public frmSolicitacoes()
        {
            InitializeComponent();
            CriarTabelaComAcoes();
        }

        private void frmSolicitacoes_Load(object sender, EventArgs e)
        {
            CarregarDados();
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
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição da Solicitação", DataPropertyName = "Descricao", Name = "Descricao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data da Solicitação", DataPropertyName = "Data_Solicitacao", Name = "Data_Solicitacao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nome do Colaborador", DataPropertyName = "Nome", Name = "Nome", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Departamento", DataPropertyName = "Departamento", Name = "Departamento", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado do Pedido", DataPropertyName = "Estado", Name = "Estado", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });


            var colEditar = new DataGridViewImageColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "image", "editar.png")),
                Width = 80
            };
            dgvPrincipal.Columns.Add(colEditar);

            var colExcluir = new DataGridViewImageColumn
            {
                Name = "Apagar",
                HeaderText = "Apagar",
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "image", "apagar.png")),
                Width = 80
            };
            dgvPrincipal.Columns.Add(colExcluir);

            dgvPrincipal.CellClick += dgvPrincipal_CellContentClick;

            // Estilo de cabeçalho e células
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvPrincipal.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPrincipal.EnableHeadersVisualStyles = false;



            pnlDGV.Controls.Add(dgvPrincipal);
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica se o clique foi em uma célula válida
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            try
            {
                if (dgvPrincipal.Rows.Count > 0)
                {
                    DataGridViewRow dr = dgvPrincipal.Rows[e.RowIndex];
                    txtID.Text = dr.Cells[0].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string colName = dgvPrincipal.Columns[e.ColumnIndex].Name;

            if (colName == "Editar")
            {

                frmAddSolicitacoes editar = new frmAddSolicitacoes();
                editar.ID = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells["ID"].Value);
                editar.Descricao = dgvPrincipal.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                editar.Data_Solicitacao = (DateTime)dgvPrincipal.Rows[e.RowIndex].Cells["Data_Solicitacao"].Value;
                editar.Nome = dgvPrincipal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                editar.Departamento = dgvPrincipal.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
                editar.EstadoPedido = dgvPrincipal.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

                if (editar.ShowDialog() == DialogResult.OK)
                {
                    CarregarDados();
                }



            }
            else if (colName == "Apagar")
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ExcluirRegistro();
                        CarregarDados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarDados()
        {
            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM SOLICITACOES", conn);
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

        private void ExcluirRegistro()
        {

            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbCommand cmd = new FbCommand("DELETE FROM SOLICITACOES WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            frmAddSolicitacoes add = new frmAddSolicitacoes();
            if (add.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void Procurar()
        {

            string connString = new dbconnection().dbconnect().ToString();
            string descricaoBusca = txtProcurar.Text.Trim();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM SOLICITACOES WHERE UPPER(DESCRICAO) LIKE @DESCRICAO";
                    FbDataAdapter adapter = new FbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@DESCRICAO", $"%{descricaoBusca.ToUpper()}%");

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

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Procurar();
        }
    }
}
