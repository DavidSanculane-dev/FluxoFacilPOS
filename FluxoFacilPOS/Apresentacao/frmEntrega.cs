using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
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
    public partial class frmEntrega : Form
    {
        
        public string usuario { get; set; }

        public frmEntrega()
        {
            InitializeComponent();
            CriarTabelaListaProduto();
            CriarTabelaPedido();
            lblData.Text = DateTime.Now.ToShortDateString();
            lblNomeColaborador.Text = "---";
            lblEmpresa.Text = "---";
            lblDepartamento.Text = "---";
            lblCentroCusto.Text = "---";

        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            CarregarDados();
            CarregarEntregaTemporaria();
            GerarNumeroPedido();

            lblUser.Text = usuario;
        }

        private void GerarNumeroPedido()
        {
            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    int anoAtual = DateTime.Now.Year;

                    // Busca o maior número de pedido do ano atual
                    FbCommand cmd = new FbCommand("SELECT MAX(CAST(SUBSTRING(PEDIDO_NO FROM 6) AS INTEGER)) FROM MOVIMENTOS WHERE SUBSTRING(PEDIDO_NO FROM 1 FOR 4) = @Ano", conn);
                    cmd.Parameters.AddWithValue("@Ano", anoAtual.ToString());

                    object result = cmd.ExecuteScalar();
                    int numeroSequencial = 1;

                    if (result != DBNull.Value)
                    {
                        numeroSequencial = Convert.ToInt32(result) + 1;
                    }

                    string numeroPedido = $"{anoAtual}/{numeroSequencial}";
                    lblPedido.Text = numeroPedido;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar número do pedido: " + ex.Message);
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
                    FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM PRODUTOS", conn);
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

        private void CriarTabelaListaProduto()
        {
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Dock = DockStyle.Fill;
            dgvPrincipal.AutoGenerateColumns = false;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.RowHeadersVisible = true;
            dgvPrincipal.AllowUserToAddRows = false;

            var colSelecionar = new DataGridViewImageColumn
            {
                Name = "Selecionar",
                HeaderText = "",
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "image", "Selecionar.png")),
                Width = 35
            };
            dgvPrincipal.Columns.Add(colSelecionar);

            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID", Name = "ID", Width = 50, Visible = false });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo do Produto", DataPropertyName = "Codigo", Name = "Codigo", Width = 120, Visible = false });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição do Produto", DataPropertyName = "Descricao", Name = "Descricao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoria", DataPropertyName = "Categoria", Name = "Categoria", Width = 160, Visible = false });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock Minimo", DataPropertyName = "Stockminimo", Name = "Stockminimo", Width = 80, Visible = false });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock Atual", DataPropertyName = "Stockatual", Name = "Stockatual", Width = 65 });
            dgvPrincipal.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Local Armazém", DataPropertyName = "LocalArmazem", Name = "LocalArmazem", Width = 120 });

            dgvPrincipal.CellClick += dgvPrincipal_CellContentClick;

            // Estilo de cabeçalho e células
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvPrincipal.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPrincipal.EnableHeadersVisualStyles = false;



            pnlDGVListaProduto.Controls.Add(dgvPrincipal);
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

            if (colName == "Descricao" || colName == "Selecionar")
            {
                DataGridViewRow dr = dgvPrincipal.Rows[e.RowIndex];

                string codigo = dr.Cells["CODIGO"].Value?.ToString();
                string descricao = dr.Cells["DESCRICAO"].Value?.ToString();
                int id = Convert.ToInt32(dr.Cells["ID"].Value);
                int quantidade = 0;

                if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    quantidade = 1;
                }
                else
                {
                    quantidade = Convert.ToInt32(txtQuantidade.Text);
                }
                
                
                ReduzirEstoque(id, quantidade);
                CarregarDados();
                //ReduzirEstoque(Convert.ToInt32(txtID.Text), quantidade);
                InserirEntregaTemporaria(codigo, descricao, quantidade);
                txtQuantidade.Text = "";
                CarregarEntregaTemporaria();   

            }

        }

        private void InserirEntregaTemporaria(string codigo, string descricao, int quantidade)
        {
            string connString = new dbconnection().dbconnect().ToString();

            string query = "INSERT INTO TEMP_ENTREGA (CODIGO, DESCRICAO, QUANTIDADE) VALUES (@CODIGO, @DESCRICAO, @QUANTIDADE)";

            using (FbConnection conn = new FbConnection(connString))
            using (FbCommand cmd = new FbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
                cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CarregarEntregaTemporaria()
        {
            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM TEMP_ENTREGA", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPedidos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void CriarTabelaPedido()
        {
            dgvPedidos.Name = "dgvListaProduto";
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.RowHeadersVisible = true;
            dgvPedidos.AllowUserToAddRows = false;

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID", Name = "ID", Width = 50, Visible = false });
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CODIGO", DataPropertyName = "CODIGO", Name = "CODIGO", Width = 50, Visible = false });
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descrição", DataPropertyName = "Descricao", Name = "Descricao", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantidade", DataPropertyName = "Quantidade", Name = "Quantidade", Width = 180 });

            var colExcluir = new DataGridViewImageColumn
            {
                Name = "Apagar",
                HeaderText = "Apagar",
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "image", "apagar.png")),
                Width = 90
            };
            dgvPedidos.Columns.Add(colExcluir);


            dgvPedidos.CellClick += dgvPedidos_CellContentClick;

            // Estilo de cabeçalho e células
            dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233);
            dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvPedidos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPedidos.EnableHeadersVisualStyles = false;



            pnlDGVPedidos.Controls.Add(dgvPedidos);
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica se o clique foi em uma célula válida
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            try
            {
                if (dgvPedidos.Rows.Count > 0)
                {
                    DataGridViewRow dr = dgvPedidos.Rows[e.RowIndex];
                    txtID.Text = dr.Cells[0].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string colName = dgvPedidos.Columns[e.ColumnIndex].Name;

            if (colName == "Editar")
            {


            }
            else if (colName == "Apagar")
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        
                        ExcluirRegistro();
                        CarregarDados();
                        CarregarEntregaTemporaria();
                        
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
                    
                    DevolucaoEstoque(dgvPedidos.Rows[0].Cells["Codigo"].Value?.ToString(), Convert.ToInt32(dgvPedidos.Rows[0].Cells["Quantidade"].Value?.ToString()));
                    conn.Open();
                    FbCommand cmd = new FbCommand("DELETE FROM TEMP_ENTREGA WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void ExcluirTodosRegistro()
        {

            string connString = new dbconnection().dbconnect().ToString();
            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbCommand cmd = new FbCommand("DELETE FROM TEMP_ENTREGA", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void ReduzirEstoque(int id, int quantidadeEntrada)
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE PRODUTOS SET STOCKATUAL = STOCKATUAL - @REDUCAO WHERE ID = @ID";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@REDUCAO", quantidadeEntrada);
                        cmd.Parameters.AddWithValue("@ID", id);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0) { }

                           //MessageBox.Show("Estoque atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o stock: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DevolucaoEstoque(string codigo, int quantidadeEntrada)
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE PRODUTOS SET STOCKATUAL = STOCKATUAL + @AUMENTO WHERE CODIGO = @CODIGO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AUMENTO", quantidadeEntrada);
                        cmd.Parameters.AddWithValue("@CODIGO", codigo);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0) 
                        {
                            MessageBox.Show("Estoque atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                            MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o stock: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProcessarPedido_Click(object sender, EventArgs e)
        {
            ProcessarPedido();
            ExcluirTodosRegistro();
            CarregarEntregaTemporaria();
            CarregarDados();
            GerarNumeroPedido();
            txtProcurarNInterno.Text = "";
            lblNomeColaborador.Text = "";
            lblDepartamento.Text = "";
            lblEmpresa.Text = "";
            lblCentroCusto.Text = "";
            cboSelecaoUso.Text = "";
            txtLocalUso.Text = "";
        }

        private void ProcessarPedido1()
        {


            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbCommand cmd = conn.CreateCommand();
                    cmd.Parameters.Clear();

                    // Captura e validação dos dados
                    string pedido = lblPedido.Text;
                    DateTime data_movimento = DateTime.Now;
                    string descricao = dgvPedidos.Rows[0].Cells["Descricao"].Value?.ToString();
                    int quantidade = Convert.ToInt32(dgvPedidos.Rows[0].Cells["Quantidade"].Value ?? 1); // valor padrão 1
                    string colaborador = lblNomeColaborador.Text;
                    string empresa = lblEmpresa.Text;
                    string departamento = lblDepartamento.Text;
                    string centroCusto = lblCentroCusto.Text;
                    string finalidade = "Uso individual";

                    ReduzirEstoque(Convert.ToInt32(dgvPedidos.Rows[0].Cells["ID"].Value), quantidade);

                    cmd.CommandText = @"INSERT INTO MOVIMENTOS (PEDIDO_NO, DATA_MOVIMENTO, DESCRICAO, QUANTIDADE, COLABORADOR, EMPRESA, DEPARTAMENTO, CENTROCUSTO, FINALIDADE) VALUES (@PEDIDO_NO, @DATA_MOVIMENTO, @DESCRICAO, @QUANTIDADE, @COLABORADOR, @EMPRESA, @DEPARTAMENTO, @CENTROCUSTO, @FINALIDADE)";


                    // Parâmetros
                    cmd.Parameters.AddWithValue("@PEDIDO_NO", pedido);
                    cmd.Parameters.AddWithValue("@DATA_MOVIMENTO", data_movimento);
                    cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                    cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                    cmd.Parameters.AddWithValue("@COLABORADOR", colaborador);
                    cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                    cmd.Parameters.AddWithValue("@DEPARTAMENTO", departamento);
                    cmd.Parameters.AddWithValue("@CENTROCUSTO", centroCusto);
                    cmd.Parameters.AddWithValue("@FINALIDADE", finalidade);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Processado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao processar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ProcessarPedido()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    FbTransaction transaction = conn.BeginTransaction();

                    FbCommand cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;

                    string pedido = lblPedido.Text;
                    DateTime data_movimento = DateTime.Now;

                    if (string.IsNullOrWhiteSpace(lblNomeColaborador.Text) || string.IsNullOrWhiteSpace(lblEmpresa.Text) || string.IsNullOrWhiteSpace(lblDepartamento.Text) || string.IsNullOrWhiteSpace(lblCentroCusto.Text))
                    {
                        MessageBox.Show("Por favor, busque o Nº Interno para preencher os dados do colaborador.");
                        return;
                    }
                    string colaborador = lblNomeColaborador.Text;
                    string empresa = lblEmpresa.Text;
                    string departamento = lblDepartamento.Text;
                    string centroCusto = lblCentroCusto.Text;
                    string entregue_por = lblUser.Text;
                    string localUso = txtLocalUso.Text;

                    if (string.IsNullOrWhiteSpace(cboSelecaoUso.Text))
                    {
                        MessageBox.Show("Por favor, escolha o tipo de Uso individual ou Uso colectivo");
                        return;
                    }

                    string finalidade = cboSelecaoUso.Text;


                    foreach (DataGridViewRow row in dgvPedidos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProduto = Convert.ToInt32(row.Cells["ID"].Value);
                        string descricao = row.Cells["Descricao"].Value?.ToString();
                        int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value ?? 1);

                        

                        // Insere o movimento
                        cmd.Parameters.Clear();
                        cmd.CommandText = @"
                    INSERT INTO MOVIMENTOS 
                    (PEDIDO_NO, DATA_MOVIMENTO, DESCRICAO, QUANTIDADE, COLABORADOR, EMPRESA, DEPARTAMENTO, CENTROCUSTO, FINALIDADE, ENTREGUE_POR, LUGAR_USO) 
                    VALUES 
                    (@PEDIDO_NO, @DATA_MOVIMENTO, @DESCRICAO, @QUANTIDADE, @COLABORADOR, @EMPRESA, @DEPARTAMENTO, @CENTROCUSTO, @FINALIDADE, @ENTREGUE_POR, @LUGAR_USO)";

                        cmd.Parameters.AddWithValue("@PEDIDO_NO", pedido);
                        cmd.Parameters.AddWithValue("@DATA_MOVIMENTO", data_movimento);
                        cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                        cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                        cmd.Parameters.AddWithValue("@COLABORADOR", colaborador);
                        cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                        cmd.Parameters.AddWithValue("@DEPARTAMENTO", departamento);
                        cmd.Parameters.AddWithValue("@CENTROCUSTO", centroCusto);
                        cmd.Parameters.AddWithValue("@FINALIDADE", finalidade);
                        cmd.Parameters.AddWithValue("@ENTREGUE_POR", entregue_por);
                        cmd.Parameters.AddWithValue("@LUGAR_USO", localUso);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Pedido processado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao processar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //ExcluirTodosRegistro();
            CarregarEntregaTemporaria();
            CarregarDados();
            GerarNumeroPedido();
            txtProcurarNInterno.Text = "";
            lblNomeColaborador.Text = "";
            lblDepartamento.Text = "";
            lblEmpresa.Text = "";
            lblCentroCusto.Text = "";
            cboSelecaoUso.Text = "";
            txtLocalUso.Text = "";
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
                                lblEmpresa.Text = reader["EMPRESA"].ToString();
                                lblDepartamento.Text = reader["DEPARTAMENTO"].ToString();
                                lblCentroCusto.Text = reader["CENTROCUSTO"].ToString();
                            }
                            else
                            {
                                lblNomeColaborador.Text = "Colaborador não encontrado.";
                                lblNomeColaborador.ForeColor = Color.Red;
                                lblEmpresa.Text = "---";
                                lblDepartamento.Text = "---";
                                lblCentroCusto.Text = "---";
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

        private void btnBuscarDados_Click(object sender, EventArgs e)
        {
            if(txtProcurarNInterno.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Nº Interno do colaborador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProcurarNInterno.Focus();
                return;
            }
            frmHistoricoColaborador frm = new frmHistoricoColaborador();
            frm.numeroInterno = txtProcurarNInterno.Text.Trim();
            BuscarNomePorNInterno();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BuscarNomePorNInterno();
            }
        }

        private void btnRemoverSelecao_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtProcurarProduto_TextChanged(object sender, EventArgs e)
        {
            ProcurarPoduto();


        }

        
        private void ProcurarPoduto()
        {

            string connString = new dbconnection().dbconnect().ToString();
            string descricaoBusca = txtProcurarProduto.Text.Trim();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM PRODUTOS WHERE UPPER(DESCRICAO) LIKE @DESCRICAO";
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
