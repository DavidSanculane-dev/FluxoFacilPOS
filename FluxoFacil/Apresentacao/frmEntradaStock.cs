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
    public partial class frmEntradaStock : Form
    {
        public frmEntradaStock()
        {
            InitializeComponent();
            CriarTabelaComAcoes();
        }

        private void frmEntradaStock_Load(object sender, EventArgs e)
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
                    FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM ENTRADA_STOCK", conn);
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
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data de Entrada", DataPropertyName = "Data_Entrada", Name = "Data_Entrada", Width = 160 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição do Produto", DataPropertyName = "Descricao", Name = "Descricao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Local do Armazém", DataPropertyName = "Local_Armazem", Name = "Local_Armazem", Width = 180 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantidade", DataPropertyName = "Quantidade", Name = "Quantidade", Width = 130 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Responsável da Entrada", DataPropertyName = "Utilizador", Name = "Utilizador", Width = 180 });


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

           
            if (colName == "Apagar")
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
                    FbCommand cmd = new FbCommand("DELETE FROM ENTRADA_STOCK WHERE ID = @ID", conn);
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

                    string query = "SELECT * FROM ENTRADA_STOCK WHERE UPPER(DESCRICAO) LIKE @DESCRICAO";
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
