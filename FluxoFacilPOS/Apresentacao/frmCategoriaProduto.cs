using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using FluxoFacil.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmCategoriaProduto : Form
    {
        public frmCategoriaProduto()
        {
            InitializeComponent();
            CriarTabelaComAcoes();
            btnSaveExcel.Visible = false;
            dgvImportacaoExcel.Visible = false;
            dgvPrincipal.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCategoriaProduto_Load(object sender, EventArgs e)
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
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição da Categoria", DataPropertyName = "Descricao", Name = "Descricao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Observação", DataPropertyName = "Observacao", Name = "Observacao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });


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

                frmAddCategoria editar = new frmAddCategoria();
                editar.ID = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells["ID"].Value);
                editar.Descricao = dgvPrincipal.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                editar.Observacao = dgvPrincipal.Rows[e.RowIndex].Cells["Observacao"].Value.ToString();

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

        private void ExcluirRegistro()
        {

            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbCommand cmd = new FbCommand("DELETE FROM CATEGORIA WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
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
                    FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM CATEGORIA", conn);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddCategoria add = new frmAddCategoria();
            if (add.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            SalvarDadosDataGridView();
            btnSaveExcel.Visible = false;
            btnImportExcel.Visible = true;
            btnExportExcel.Visible = true;
            dgvPrincipal.Visible = true;
            dgvImportacaoExcel.Visible = false;
            CriarTabelaComAcoes();
            CarregarDados();
        }

        private void SalvarDadosDataGridView()
        {
            try
            {
                if (dgvImportacaoExcel.DataSource == null)
                {
                    MessageBox.Show("Nenhum dado para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable dt = (DataTable)dgvImportacaoExcel.DataSource;
                string connString = new dbconnection().dbconnect().ToString();
                using (FbConnection conn = new FbConnection(connString))
                {
                    conn.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        FbCommand cmd = new FbCommand("INSERT INTO CATEGORIA (Descricao, Observacao) VALUES (@Descricao, @Observacao)", conn);
                        cmd.Parameters.AddWithValue("@Descricao", row["Descricao"]);
                        cmd.Parameters.AddWithValue("@Observacao", row["Observacao"]);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnImportExcel_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            // Abrir o OpenFileDialog na UI thread (STA)
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                filePath = openFileDialog.FileName;
            }

            using (frmLoading loading = new frmLoading())
            {
                loading.LoadingText = "Importando Excel...";
                loading.Show();
                loading.Refresh();

                await Task.Run(() =>
                {
                    ImportarExcel(filePath); // passe o caminho do arquivo para o método
                });

                loading.Close();
            }
        }

        private void ImportarExcel(string excelFilePath)
        {
            try
            {

                string connString = new dbconnection().dbconnect().ToString();
                using (FbConnection conn = new FbConnection(
                    $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={excelFilePath};Extended Properties='Excel 12.0 Xml;HDR=YES';"))
                {
                    FbDataAdapter dta = new FbDataAdapter("SELECT * FROM [Folha1$]", conn);
                    DataSet dts = new DataSet();
                    dta.Fill(dts, "Folha1");

                    this.Invoke((MethodInvoker)(() =>
                    {
                        dgvImportacaoExcel.Visible = true;

                        dgvPrincipal.Visible = false;
                        dgvImportacaoExcel.DataSource = dts.Tables["Folha1"];
                        dgvImportacaoExcel.Dock = DockStyle.Fill;
                        dgvImportacaoExcel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        btnImportExcel.Visible = false;
                        btnSaveExcel.Visible = true;
                        btnExportExcel.Visible = false;
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Procurar();
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

                    string query = "SELECT * FROM CATEGORIA WHERE UPPER(DESCRICAO) LIKE @DESCRICAO";
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
    }
}
