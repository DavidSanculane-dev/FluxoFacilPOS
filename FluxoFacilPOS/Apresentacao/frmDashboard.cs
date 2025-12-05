using Bunifu.UI.WinForms;
using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
using Microsoft.Office.Interop.Excel;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using PdfSharp;
using PdfSharp.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using PdfSharp.Pdf;
using DataTable = System.Data.DataTable;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using Font = System.Drawing.Font;
using Legend = System.Windows.Forms.DataVisualization.Charting.Legend;
using Rectangle = System.Drawing.Rectangle;

namespace FluxoFacil.Apresentacao
{
    public partial class frmDashboard : Form
    {

        int mes;
        int ano;

        public frmDashboard()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CarregarDadosProdutos();
            CarregarDadosEntregas();
            CarregarDadosColaboradores();
            CarregarProdutosMaisSolicitados();
            CarregarGraficoEntregas(DateTime.Now.Month, DateTime.Now.Year);
            CarregarGraficoEntregasPorDia(DateTime.Now.Month, DateTime.Now.Year);
            CarregarGraficoDepartamentos();
            CarregarDadosSolicitacoes();
        }

       

        private void CarregarDadosSolicitacoes()
        {
            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    //FbDataAdapter adapter = new FbDataAdapter("SELECT DESCRICAO AS 'Descricao', DATA_SOLICITACAO AS 'Data do Pedido', NOME, DEPARTAMENTO FROM SOLICITACOES ORDER BY DATA_SOLICITACAO", conn);
                    FbDataAdapter adapter = new FbDataAdapter(
                        "SELECT DESCRICAO AS \"Descrição\", DATA_SOLICITACAO AS \"Data do Pedido\", NOME AS \"Nome\", DEPARTAMENTO AS \"Departamento\" FROM SOLICITACOES ORDER BY DATA_SOLICITACAO",
                        conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Adiciona uma coluna para os pontos quadrados
                    dt.Columns.Add("Marcador", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Marcador"] = "■";
                    }

                    // Reordena as colunas para que o marcador apareça primeiro
                    dt.Columns["Marcador"].SetOrdinal(0);

                    dgvSolicitacoes.DataSource = dt;


                    // Configura as outras colunas para preencher o espaço restante
                    dgvSolicitacoes.Columns["Descrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvSolicitacoes.Columns["Data do Pedido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvSolicitacoes.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvSolicitacoes.Columns["Departamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Configuração do AutoSizeColumnsMode ANTES de ajustar colunas individuais
                    dgvSolicitacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Desativa o auto-size geral

                    // Configuração específica da coluna Marcador
                    dgvSolicitacoes.Columns["Marcador"].HeaderText = "";
                    dgvSolicitacoes.Columns["Marcador"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvSolicitacoes.Columns["Marcador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvSolicitacoes.Columns["Marcador"].Resizable = DataGridViewTriState.False; // Impede redimensionamento pelo usuário

                    // Configuração das colunas
                    dgvSolicitacoes.Columns["Marcador"].HeaderText = ""; // Remove o cabeçalho
                    dgvSolicitacoes.Columns["Marcador"].Width = 15; // Largura fixa para o marcador
                    dgvSolicitacoes.Columns["Marcador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Esconde o cabeçalho da coluna do marcador
                    dgvSolicitacoes.Columns["Marcador"].HeaderCell.Style.BackColor = Color.White;
                    dgvSolicitacoes.Columns["Marcador"].HeaderCell.Style.ForeColor = Color.White;

                    // Estilização geral
                    dgvSolicitacoes.BackgroundColor = Color.White;
                    dgvSolicitacoes.BorderStyle = BorderStyle.None;
                    dgvSolicitacoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgvSolicitacoes.EnableHeadersVisualStyles = false;
                    dgvSolicitacoes.GridColor = Color.LightGray;

                    // Cabeçalho
                    dgvSolicitacoes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular);
                    dgvSolicitacoes.ColumnHeadersHeight = 40;

                    // Linhas alternadas
                    dgvSolicitacoes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

                    // Células
                    dgvSolicitacoes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
                    dgvSolicitacoes.DefaultCellStyle.ForeColor = Color.Black;
                    dgvSolicitacoes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 241, 251);
                    dgvSolicitacoes.DefaultCellStyle.SelectionForeColor = Color.Black;


                    // Remover bordas laterais das células
                    dgvSolicitacoes.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                    dgvSolicitacoes.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                    // Ajustar altura das linhas
                    dgvSolicitacoes.RowTemplate.Height = 35;
                    dgvSolicitacoes.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

                    // Configura a cor vermelha para os pontos
                    dgvSolicitacoes.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 0 && e.Value != null) // Coluna Marcador
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.SelectionForeColor = Color.Red;
                        }
                    };

                    // Ordenação automática (exceto para a coluna do marcador)
                    foreach (DataGridViewColumn col in dgvSolicitacoes.Columns)
                    {
                        if (col.Name != "Marcador")
                        {
                            col.SortMode = DataGridViewColumnSortMode.Automatic;
                        }
                        else
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }

                    dgvSolicitacoes.CurrentCell = null;
                    dgvSolicitacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvSolicitacoes.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void CarregarGraficoDepartamentos()
        {
            string connString = new dbconnection().dbconnect();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT DEPARTAMENTO, SUM(Quantidade) AS Total
                FROM MOVIMENTOS
                GROUP BY DEPARTAMENTO
                ORDER BY Total ASC";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        graficoDepartamento.Series.Clear();
                        graficoDepartamento.Titles.Clear();
                        graficoDepartamento.Legends.Clear();

                        Title titulo = new Title("");
                        titulo.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
                        titulo.Alignment = ContentAlignment.TopCenter;
                        graficoDepartamento.Titles.Add(titulo);

                        Series serie = new Series("Departamentos")
                        {
                            ChartType = SeriesChartType.Pie,
                            Font = new Font("Segoe UI", 9, FontStyle.Bold),
                            IsValueShownAsLabel = true,
                            LabelForeColor = Color.Black,
                            Label = "#PERCENT{P1}",
                            ToolTip = "#VALX - #VALY pedidos"
                        };

                        // Lista temporária para armazenar dados
                        var dados = new List<(string Departamento, int Total)>();
                        int totalGeral = 0;

                        while (reader.Read())
                        {
                            string departamento = reader["DEPARTAMENTO"].ToString();
                            int total = Convert.ToInt32(reader["Total"]);
                            dados.Add((departamento, total));
                            totalGeral += total;
                        }

                        int totalOutros = 0;

                        foreach (var item in dados)
                        {
                            double percentagem = (double)item.Total / totalGeral * 100;

                            if (percentagem < 3) // Agrupar valores menores que 5%
                            {
                                totalOutros += item.Total;
                            }
                            else
                            {
                                serie.Points.AddXY(item.Departamento, item.Total);
                            }
                        }

                        if (totalOutros > 0)
                        {
                            serie.Points.AddXY("Outros", totalOutros);
                        }

                        // Explodir a fatia com maior valor
                        if (serie.Points.Count > 0)
                        {
                            int maxIndex = serie.Points.IndexOf(
                                serie.Points.OrderByDescending(p => p.YValues[0]).First()
                            );
                            serie.Points[maxIndex]["Exploded"] = "true";
                        }

                        // Estilo visual
                        graficoDepartamento.Palette = ChartColorPalette.BrightPastel;
                        serie["PieLabelStyle"] = "Outside";
                        serie["PieLineColor"] = "Black";

                        // Legenda
                        Legend legenda = new Legend("Legenda");
                        legenda.Font = new Font("Segoe UI", 9);
                        graficoDepartamento.Legends.Add(legenda);
                        serie.LegendText = "#VALX";

                        graficoDepartamento.Series.Add(serie);

                        // Remover eixos
                        var area = graficoDepartamento.ChartAreas[0];
                        area.AxisX.Enabled = AxisEnabled.False;
                        area.AxisY.Enabled = AxisEnabled.False;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar gráfico de departamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        


        private void InicializarControles()
        {
            // Adiciona os meses ao ComboBox
            string[] meses = new string[]
            {
                "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            };
            cbMes.Items.AddRange(meses);
            cbMes.SelectedIndex = DateTime.Now.Month - 1;

            // Define o valor inicial do ano
            numAno.Minimum = 2000;
            numAno.Maximum = 2100;
            numAno.Value = DateTime.Now.Year;
        }


        private void CarregarDadosProdutos()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) AS Total FROM PRODUTOS";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            // Zera os labels antes de preencher
                            lblTotalProdutos.Text = "0";
                            

                            while (reader.Read())
                            {
                                
                                lblTotalProdutos.Text = reader["Total"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o total de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarDadosEntregas()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT SUM(Quantidade) AS Total FROM MOVIMENTOS";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            // Zera os labels antes de preencher
                            lblTotalEntrega.Text = "0";


                            while (reader.Read())
                            {

                                lblTotalEntrega.Text = reader["Total"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o total de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarDadosColaboradores()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) AS Total FROM COLABORADORES";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            // Zera os labels antes de preencher
                            lblTotalColaborador.Text = "0";


                            while (reader.Read())
                            {

                                lblTotalColaborador.Text = reader["Total"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o total de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarProdutosMaisSolicitados()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT FIRST 10 DESCRICAO, Sum(Quantidade) AS Total
                FROM MOVIMENTOS
                GROUP BY DESCRICAO
                ORDER BY Total DESC";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        using (FbDataAdapter adapter = new FbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Adiciona uma coluna para os pontos quadrados
                            dt.Columns.Add("Marcador", typeof(string));
                            foreach (DataRow row in dt.Rows)
                            {
                                row["Marcador"] = "■";
                            }

                            // Reordena as colunas para que o marcador apareça primeiro
                            dt.Columns["Marcador"].SetOrdinal(0);

                            dgvMaisSolicitados.DataSource = dt;

                            // Configura as outras colunas para preencher o espaço restante
                            dgvMaisSolicitados.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvMaisSolicitados.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            // Configuração do AutoSizeColumnsMode ANTES de ajustar colunas individuais
                            dgvMaisSolicitados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Desativa o auto-size geral

                            // Configuração específica da coluna Marcador
                            dgvMaisSolicitados.Columns["Marcador"].HeaderText = "";
                            dgvMaisSolicitados.Columns["Marcador"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dgvMaisSolicitados.Columns["Marcador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvMaisSolicitados.Columns["Marcador"].Resizable = DataGridViewTriState.False; // Impede redimensionamento pelo usuário

                            // Configuração das colunas
                            dgvMaisSolicitados.Columns["Marcador"].HeaderText = ""; // Remove o cabeçalho
                            dgvMaisSolicitados.Columns["Marcador"].Width = 15; // Largura fixa para o marcador
                            dgvMaisSolicitados.Columns["Marcador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            // Esconde o cabeçalho da coluna do marcador
                            dgvMaisSolicitados.Columns["Marcador"].HeaderCell.Style.BackColor = Color.White;
                            dgvMaisSolicitados.Columns["Marcador"].HeaderCell.Style.ForeColor = Color.White;

                            // Estilização geral
                            dgvMaisSolicitados.BackgroundColor = Color.White;
                            dgvMaisSolicitados.BorderStyle = BorderStyle.None;
                            dgvMaisSolicitados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                            dgvMaisSolicitados.EnableHeadersVisualStyles = false;
                            dgvMaisSolicitados.GridColor = Color.LightGray;

                            // Cabeçalho
                            dgvMaisSolicitados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            dgvMaisSolicitados.ColumnHeadersHeight = 40;

                            // Linhas alternadas
                            dgvMaisSolicitados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

                            // Células
                            dgvMaisSolicitados.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                            dgvMaisSolicitados.DefaultCellStyle.ForeColor = Color.Black;
                            dgvMaisSolicitados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 241, 251);
                            dgvMaisSolicitados.DefaultCellStyle.SelectionForeColor = Color.Black;


                            // Remover bordas laterais das células
                            dgvMaisSolicitados.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                            dgvMaisSolicitados.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                            // Ajustar altura das linhas
                            dgvMaisSolicitados.RowTemplate.Height = 35;
                            dgvMaisSolicitados.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

                            // Configura a cor vermelha para os pontos
                            dgvMaisSolicitados.CellFormatting += (sender, e) =>
                            {
                                if (e.ColumnIndex == 0 && e.Value != null) // Coluna Marcador
                                {
                                    e.CellStyle.ForeColor = Color.Red;
                                    e.CellStyle.SelectionForeColor = Color.Red;
                                }
                            };

                            // Ordenação automática (exceto para a coluna do marcador)
                            foreach (DataGridViewColumn col in dgvMaisSolicitados.Columns)
                            {
                                if (col.Name != "Marcador")
                                {
                                    col.SortMode = DataGridViewColumnSortMode.Automatic;
                                }
                                else
                                {
                                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                                }
                            }

                            dgvMaisSolicitados.CurrentCell = null;
                            dgvMaisSolicitados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgvMaisSolicitados.ClearSelection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os produtos mais solicitados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarGraficoEntregas(int mes, int ano)
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT SUM(Quantidade) AS Total
                FROM MOVIMENTOS
                WHERE EXTRACT(MONTH FROM DATA_MOVIMENTO) = @Mes
                  AND EXTRACT(YEAR FROM DATA_MOVIMENTO) = @Ano";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Mes", mes);
                        cmd.Parameters.AddWithValue("@Ano", ano);

                        object result = cmd.ExecuteScalar();
                        int total = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                        // Limpa e configura o gráfico
                        graficoEntrega.Series.Clear();
                        graficoEntrega.Titles.Clear();
                        graficoEntrega.ChartAreas[0].BackColor = Color.WhiteSmoke;

                        graficoEntrega.Titles.Add($"Entregas em {mes:D2}/{ano}");

                        Series serie = new Series("Entregas")
                        {
                            ChartType = SeriesChartType.Column,
                            //Color = Color.FromArgb(41, 128, 185), // Azul moderno
                            Color = Color.FromArgb(255, 127, 0), //Laranja moderno
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            IsValueShownAsLabel = true,
                            LabelForeColor = Color.Black,
                            ToolTip = "Total: #VALY"
                        };

                        serie.Points.AddXY($"{mes:D2}/{ano}", total);
                        graficoEntrega.Series.Add(serie);

                        // Eixos
                        var area = graficoEntrega.ChartAreas[0];
                        area.AxisX.Title = "Mês/Ano";
                        area.AxisY.Title = "Quantidade";
                        area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                        area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
                        area.AxisX.MajorGrid.LineColor = Color.LightGray;
                        area.AxisY.MajorGrid.LineColor = Color.LightGray;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar gráfico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void CarregarGraficoEntregasPorDia(int mes, int ano)
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    EXTRACT(DAY FROM DATA_MOVIMENTO) AS Dia,
                    SUM(Quantidade) AS Total
                FROM MOVIMENTOS
                WHERE EXTRACT(MONTH FROM DATA_MOVIMENTO) = @Mes
                  AND EXTRACT(YEAR FROM DATA_MOVIMENTO) = @Ano
                GROUP BY EXTRACT(DAY FROM DATA_MOVIMENTO)
                ORDER BY Dia";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Mes", mes);
                        cmd.Parameters.AddWithValue("@Ano", ano);

                        Dictionary<int, int> entregasPorDia = new Dictionary<int, int>();

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int dia = Convert.ToInt32(reader["Dia"]);
                                int total = Convert.ToInt32(reader["Total"]);
                                entregasPorDia[dia] = total;
                            }
                        }

                        // Preencher dias sem entregas com 0
                        //for (int dia = 1; dia <= DateTime.DaysInMonth(ano, mes); dia++)
                        //{
                        //    if (!entregasPorDia.ContainsKey(dia))
                        //        entregasPorDia[dia] = 0;
                        //}

                        // Atualizar gráfico
                        graficoEntrega.Series.Clear();
                        graficoEntrega.Titles.Clear();
                        graficoEntrega.ChartAreas[0].BackColor = Color.White;

                        Title titulo = new Title($"Mês {mes:D2}/{ano}");
                        titulo.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                        titulo.Alignment = ContentAlignment.TopCenter;
                        graficoEntrega.Titles.Add(titulo);

                        Series serie = new Series(" ")
                        {
                            ChartType = SeriesChartType.Column,
                            Font = new Font("Segoe UI", 10, FontStyle.Regular),
                            IsValueShownAsLabel = true,
                            LabelForeColor = Color.Black,
                            ToolTip = "Dia #VALX saiu #VALY produtos"
                        };

                        foreach (var dia in entregasPorDia.OrderBy(d => d.Key))
                        {
                            int index = serie.Points.AddXY(dia.Key, dia.Value);
                            DataPoint ponto = serie.Points[index];
                            // Destacar dias com mais de 500 entregas
                            if (dia.Value > 400)
                                ponto.Color = Color.DarkOrange;
                            else
                                ponto.Color = Color.BlueViolet;
                        }

                        graficoEntrega.Series.Add(serie);

                        var area = graficoEntrega.ChartAreas[0];
                        area.AxisX.Title = "Dia";
                        area.AxisY.Title = "Quantidade";
                        area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                        area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
                        area.AxisX.MajorGrid.LineColor = Color.White;
                        area.AxisY.MajorGrid.LineColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar gráfico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltarEntrega_Click(object sender, EventArgs e)
        {


            if (cbMes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um mês.");
                return;
            }

            mes = cbMes.SelectedIndex + 1;
            ano = (int)numAno.Value;

            //CarregarGraficoEntregas(mes, ano);
            CarregarGraficoEntregasPorDia(mes, ano);

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarDashboardMultiPaginaParaPDF();
        }


        private void ExportarDashboardMultiPaginaParaPDF()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Ficheiro PDF (*.pdf)|*.pdf";
                saveDialog.Title = "Salvar Dashboard como PDF";
                saveDialog.FileName = "dashboard_completo.pdf";

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                string caminhoPDF = saveDialog.FileName;
                string logoPath = "LogoSemFundo.png"; // Caminho do logotipo

                PdfDocument documento = new PdfDocument();
                documento.Info.Title = "Dashboard Completo";

                // Lista de painéis a exportar (podes adicionar mais)
                var paineis = new List<(Control painel, string titulo)>
                {
                    //(painelResumoGeral, "Resumo Geral"),
                    (pnlGraficoBarEntrega, "Entregas por Dia"),
                    (pnlGraficoPizzaEntrega, "Entregas por Departamento"),
                    (pnlTopProdutos, "Produtos mais solicitados"),
                    (pnlPedidosPendentes, "Pedidos Pendentes")
                };

                foreach (var (painel, titulo) in paineis)
                {
                    // Capturar imagem do painel
                    Bitmap bmp = new Bitmap(painel.Width, painel.Height);
                    painel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    string imagemTemp = Path.GetTempFileName();
                    bmp.Save(imagemTemp, ImageFormat.Png);

                    // Criar nova página
                    PdfPage pagina = documento.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(pagina);

                    // Logotipo
                    if (File.Exists(logoPath))
                    {
                        XImage logo = XImage.FromFile(logoPath);

                        double proporcao = (double)logo.PixelWidth / logo.PixelHeight;
                        double lar = 80;
                        double alt = lar / proporcao;
                        gfx.DrawImage(logo, 40, 30, lar, alt);

                        //gfx.DrawImage(logo, 40, 30, 60, 60);
                    }

                    // Data
                    string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
                    gfx.DrawString("Data de Impressão: " + dataAtual, new XFont("Segoe UI", 10), XBrushes.Black, new XPoint(450, 50));

                    // Título da página
                    gfx.DrawString(titulo, new XFont("Segoe UI", 14, XFontStyle.Bold), XBrushes.DarkOrange, new XPoint(50, 100));

                    // Imagem do painel
                    XImage imagem = XImage.FromFile(imagemTemp);
                    double largura = pagina.Width.Point;
                    double altura = pagina.Height.Point;
                    double escala = Math.Min((largura - 80) / imagem.PixelWidth, (altura - 150) / imagem.PixelHeight);

                    double larguraFinal = imagem.PixelWidth * escala;
                    double alturaFinal = imagem.PixelHeight * escala;

                    gfx.DrawImage(imagem, 40, 130, larguraFinal, alturaFinal);

                    // Limpar imagem temporária
                    imagem.Dispose();
                    File.Delete(imagemTemp);
                }

                documento.Save(caminhoPDF);
                MessageBox.Show("Dashboard exportado com sucesso para: " + caminhoPDF, "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar dashboard: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
