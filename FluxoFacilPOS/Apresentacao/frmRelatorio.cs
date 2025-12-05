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
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Axis = LiveChartsCore.SkiaSharpView.Axis;
using Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;
using DataTable = System.Data.DataTable;
using ISeries = LiveChartsCore.ISeries;

namespace FluxoFacil.Apresentacao
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
            CriarTabelaComAcoes();
            CarregarFiltros();

            var chart = new CartesianChart
            {
                Dock = DockStyle.Fill
            };
            pnlGraficoBar.Controls.Add(chart);

            var piechart = new PieChart
            {
                
                Dock = DockStyle.Fill
            };
            pnlGraficoPizza.Controls.Add(chart);

        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {

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
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição do produto", DataPropertyName = "Descricao", Name = "Descricao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data", DataPropertyName = "Data", Name = "Data", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Departamento", DataPropertyName = "Departamento", Name = "Departamento", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantidade", DataPropertyName = "Quantidade", Name = "Quantidade", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });



            //dgvPrincipal.CellClick += dgvPrincipal_CellContentClick;

            // Estilo de cabeçalho e células
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvPrincipal.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPrincipal.EnableHeadersVisualStyles = false;



            //pnlDGV.Controls.Add(dgvPrincipal);
        }

        private void CarregarFiltros()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                conn.Open();

                // Produtos
                FbDataAdapter daProdutos = new FbDataAdapter("SELECT DISTINCT DESCRICAO FROM MOVIMENTOS", conn);
                DataTable dtProdutos = new DataTable();
                daProdutos.Fill(dtProdutos);

                // Adiciona a opção "Todos"
                DataRow rowProduto = dtProdutos.NewRow();
                rowProduto["DESCRICAO"] = "Todos";
                dtProdutos.Rows.InsertAt(rowProduto, 0);

                comboProduto.DataSource = dtProdutos;
                comboProduto.DisplayMember = "DESCRICAO";
                comboProduto.SelectedIndex = 0;

                // Departamentos
                FbDataAdapter daDepartamentos = new FbDataAdapter("SELECT DISTINCT DEPARTAMENTO FROM MOVIMENTOS", conn);
                DataTable dtDepartamentos = new DataTable();
                daDepartamentos.Fill(dtDepartamentos);

                // Adiciona a opção "Todos"
                DataRow rowDepartamento = dtDepartamentos.NewRow();
                rowDepartamento["DEPARTAMENTO"] = "Todos";
                dtDepartamentos.Rows.InsertAt(rowDepartamento, 0);

                comboDepartamento.DataSource = dtDepartamentos;
                comboDepartamento.DisplayMember = "DEPARTAMENTO";
                comboDepartamento.SelectedIndex = 0;
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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        private void GerarRelatorio()
        {
            try
            {
                string connString = new dbconnection().dbconnect().ToString();

                using (FbConnection conn = new FbConnection(connString))
                {
                    conn.Open();

                    string query = @"
                                           SELECT DESCRICAO, DATA_MOVIMENTO AS ""Data"", DEPARTAMENTO, QUANTIDADE 
                                           FROM MOVIMENTOS
                                           WHERE DATA_MOVIMENTO BETWEEN @DataInicio AND @DataFim
                                       ";
        
            // Filtros opcionais
            if (comboProduto.Text != "Todos" && !string.IsNullOrWhiteSpace(comboProduto.Text))
                        query += " AND DESCRICAO = @Descricao";

                    if (comboDepartamento.Text != "Todos" && !string.IsNullOrWhiteSpace(comboDepartamento.Text))
                        query += " AND DEPARTAMENTO = @Departamento";

                    query += " ORDER BY DATA_MOVIMENTO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DataInicio", dateInicio.Value.Date);
                        cmd.Parameters.AddWithValue("@DataFim", dateFim.Value.Date);

                        if (comboProduto.Text != "Todos" && !string.IsNullOrWhiteSpace(comboProduto.Text))
                            cmd.Parameters.AddWithValue("@Descricao", comboProduto.Text);

                        if (comboDepartamento.Text != "Todos" && !string.IsNullOrWhiteSpace(comboDepartamento.Text))
                            cmd.Parameters.AddWithValue("@Departamento", comboDepartamento.Text);

                        using (FbDataAdapter adapter = new FbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvPrincipal.DataSource = dt;
                            //GerarGraficoPorDepartamento(dt);
                            GerarGraficos(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarGraficos(System.Data.DataTable dt)
        {
            var agrupado = dt.AsEnumerable()
                .GroupBy(r => r.Field<string>("DEPARTAMENTO"))
                .Select(g => new
                {
                    Departamento = g.Key,
                    Quantidade = g.Sum(r => Convert.ToInt32(r["QUANTIDADE"]))
                }).ToList();

            // Gráfico de Barras
            var barLabels = agrupado.Select(x => x.Departamento).ToArray();
            var barValues = agrupado.Select(x => (double)x.Quantidade).ToArray();

            var barChart = new CartesianChart
            {
                Series = new ISeries[]
                {
            new ColumnSeries<double>
            {
                Values = barValues,
                Name = "Quantidade"
            }
                },
                XAxes = new Axis[]
                {
            new Axis
            {
                Labels = barLabels,
                LabelsRotation = 15
            }
                },
                YAxes = new Axis[]
                {
            new Axis
            {
                Name = "Quantidade"
            }
                },
                Dock = DockStyle.Fill
            };

            pnlGraficoBar.Controls.Clear();
            pnlGraficoBar.Controls.Add(barChart);

            // Gráfico de Pizza
            var pieSeries = agrupado.Select(x => new PieSeries<double>
            {
                Name = x.Departamento,
                Values = new double[] { x.Quantidade },
                DataLabelsSize = 14,
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                //DataLabelsFormatter = point => $"{point.Context.Series.Name}: {point.PrimaryValue}"
                DataLabelsFormatter = point => $"{point.Context.Series.Name}: {point.Coordinate.PrimaryValue}"

            }).ToArray();

            var pieChart = new PieChart
            {
                Series = pieSeries,
                Dock = DockStyle.Fill
            };

            pnlGraficoPizza.Controls.Clear();
            pnlGraficoPizza.Controls.Add(pieChart);
        }



        //private void GerarGraficoLiveCharts(DataTable dt)
        //{
        //    var agrupado = dt.AsEnumerable()
        //        .GroupBy(r => r.Field<string>("DEPARTAMENTO"))
        //        .Select(g => new
        //        {
        //            Departamento = g.Key,
        //            Quantidade = g.Sum(r => Convert.ToInt32(r["QUANTIDADE"]))
        //        }).ToList();

        //    var labels = agrupado.Select(x => x.Departamento).ToArray();
        //    var valores = agrupado.Select(x => (double)x.Quantidade).ToArray();

        //    var chart = new CartesianChart
        //    {
        //        Series = new ISeries[]
        //        {
        //    new ColumnSeries<double>
        //    {
        //        Values = valores,
        //        Name = "Quantidade"
        //    }
        //        },
        //        XAxes = new Axis[]
        //        {
        //    new Axis
        //    {
        //        Labels = labels,
        //        LabelsRotation = 15
        //    }
        //        },
        //        YAxes = new LiveChartsCore.SkiaSharpView.Axis[]
        //        {
        //    new LiveChartsCore.SkiaSharpView.Axis
        //    {
        //        Name = "Quantidade"
        //    }
        //        },
        //        Dock = DockStyle.Fill
        //    };

        //    pnlGraficoBar.Controls.Clear(); // Limpa controles anteriores
        //    pnlGraficoBar.Controls.Add(chart);
        //}


        //private void GerarGraficoPizza(DataTable dt)
        //{
        //    var agrupado = dt.AsEnumerable()
        //        .GroupBy(r => r.Field<string>("DEPARTAMENTO"))
        //        .Select(g => new
        //        {
        //            Departamento = g.Key,
        //            Quantidade = g.Sum(r => Convert.ToInt32(r["QUANTIDADE"]))
        //        }).ToList();

        //    var series = agrupado.Select(x => new PieSeries<double>
        //    {
        //        Name = x.Departamento,
        //        Values = new double[] { x.Quantidade },
        //        DataLabelsSize = 14,
        //        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
        //        DataLabelsFormatter = point => $"{point.Context.Series.Name}: {point.PrimaryValue}"
        //    }).ToArray();

        //    var pieChart = new PieChart
        //    {
        //        Series = series,
        //        Dock = DockStyle.Fill
        //    };

        //    pnlGraficoPizza.Controls.Clear(); // Limpa controles anteriores
        //    pnlGraficoPizza.Controls.Add(pieChart);
        //}


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

