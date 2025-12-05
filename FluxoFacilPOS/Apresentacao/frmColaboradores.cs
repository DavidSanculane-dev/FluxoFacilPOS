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
    public partial class frmColaboradores : Form
    {
        public frmColaboradores()
        {
            InitializeComponent();
            CriarTabelaComAcoes();
            btnSaveExcel.Visible = false;
            dgvImportacaoExcel.Visible = false;
            dgvPrincipal.Visible = true;
        }

        private void frmColaboradores_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM COLABORADORES", conn);
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

        private void CriarTabelaComAcoes()
        {
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Dock = DockStyle.Fill;
            dgvPrincipal.AutoGenerateColumns = false;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.RowHeadersVisible = true;
            dgvPrincipal.AllowUserToAddRows = false;

            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID", Name = "ID", Width = 50, Visible = false });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nº Interno", DataPropertyName = "NInterno", Name = "NInterno", Width = 160 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nome do Colaborador", DataPropertyName = "Nome", Name = "Nome", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Empresa", DataPropertyName = "Empresa", Name = "Empresa", Width = 180 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Área/Departamento", DataPropertyName = "Departamento", Name = "Departamento", Width = 130 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Centro de Custo", DataPropertyName = "CentroCusto", Name = "CentroCusto", Width = 90 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Observação", DataPropertyName = "Observacao", Name = "Observacao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

           

            var colEditar = new DataGridViewImageColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "image", "editar.png")),
                Width = 50
            };
            dgvPrincipal.Columns.Add(colEditar);

            var colExcluir = new DataGridViewImageColumn
            {
                Name = "Apagar",
                HeaderText = "Apagar",
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "image", "apagar.png")),
                Width = 55
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

                frmAddColaborador editar = new frmAddColaborador();
                editar.ID = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells["ID"].Value);
                editar.NInterno = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells["NInterno"].Value);
                editar.Nome = dgvPrincipal.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                editar.Empresa = dgvPrincipal.Rows[e.RowIndex].Cells["Empresa"].Value.ToString();
                editar.Departamento = dgvPrincipal.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
                editar.CentroCusto = dgvPrincipal.Rows[e.RowIndex].Cells["CentroCusto"].Value.ToString();
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
                    FbCommand cmd = new FbCommand("DELETE FROM COLABORADORES WHERE ID = @ID", conn);
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
            this.Close();
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

        private void SalvarDadosDataGridView1()
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
                        FbCommand cmd = new FbCommand("INSERT INTO COLABORADORES (NINTERNO, NOME, EMPRESA, DEPARTAMENTO, CENTROCUSTO, OBSERVACAO) VALUES (@NINTERNO, @NOME, @EMPRESA, @DEPARTAMENTO, @CENTROCUSTO, @OBSERVACAO)", conn);
                        cmd.Parameters.AddWithValue("@NINTERNO", row["NINTERNO"]);
                        cmd.Parameters.AddWithValue("@NOME", row["NOME"]);
                        cmd.Parameters.AddWithValue("@EMPRESA", row["EMPRESA"]);
                        cmd.Parameters.AddWithValue("@DEPARTAMENTO", row["DEPARTAMENTO"]);
                        cmd.Parameters.AddWithValue("@CENTROCUSTO", row["CENTROCUSTO"]);
                        cmd.Parameters.AddWithValue("@OBSERVACAO", row["OBSERVACAO"]);
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
                    using (FbTransaction transaction = conn.BeginTransaction())
                    {
                        FbCommand cmd = new FbCommand(
                            "INSERT INTO COLABORADORES (NINTERNO, NOME, EMPRESA, DEPARTAMENTO, CENTROCUSTO, OBSERVACAO) " +
                            "VALUES (@NINTERNO, @NOME, @EMPRESA, @DEPARTAMENTO, @CENTROCUSTO, @OBSERVACAO)", conn, transaction);

                        // Definir os parâmetros uma vez
                        cmd.Parameters.Add("@NINTERNO", FbDbType.VarChar);
                        cmd.Parameters.Add("@NOME", FbDbType.VarChar);
                        cmd.Parameters.Add("@EMPRESA", FbDbType.VarChar);
                        cmd.Parameters.Add("@DEPARTAMENTO", FbDbType.VarChar);
                        cmd.Parameters.Add("@CENTROCUSTO", FbDbType.VarChar);
                        cmd.Parameters.Add("@OBSERVACAO", FbDbType.VarChar);

                        foreach (DataRow row in dt.Rows)
                        {
                            cmd.Parameters["@NINTERNO"].Value = row["NINTERNO"];
                            cmd.Parameters["@NOME"].Value = row["NOME"];
                            cmd.Parameters["@EMPRESA"].Value = row["EMPRESA"];
                            cmd.Parameters["@DEPARTAMENTO"].Value = row["DEPARTAMENTO"];
                            cmd.Parameters["@CENTROCUSTO"].Value = row["CENTROCUSTO"];
                            cmd.Parameters["@OBSERVACAO"].Value = row["OBSERVACAO"];
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
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
            string connExcel = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={excelFilePath};Extended Properties='Excel 12.0 Xml;HDR=YES';";

            using (OleDbConnection conn = new OleDbConnection(connExcel))
            {
                OleDbDataAdapter dta = new OleDbDataAdapter("SELECT * FROM [Folha1$]", conn);
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddColaborador add = new frmAddColaborador();
            if (add.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
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

                    string query = "SELECT * FROM COLABORADORES WHERE UPPER(NOME) LIKE @NOME";
                    FbDataAdapter adapter = new FbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@NOME", $"%{descricaoBusca.ToUpper()}%");

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
