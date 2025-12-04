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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FluxoFacil.Apresentacao
{
    public partial class frmAddProdutos : Form
    {
        public int? ID { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int? StockMinimo { get; set; }
        public int? QuantidadeAtual { get; set; }
        public string LocalArmazem { get; set; }
        public string ButtonText { set { btnSalvar.Text = value; } }

        public frmAddProdutos()
        {
            InitializeComponent();
            CarregarCategorias();
            CarregarLocalArmazem();
        }

        private void frmAddProdutos_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                txtID.Text = ID.Value.ToString();
                txtCodigo.Text = Codigo;
                txtDescricao.Text = Descricao;
                cboCategoria.Text = Categoria;
                txtStockMinimo.Text = StockMinimo.Value.ToString();
                txtQuantidadeAtual.Text = QuantidadeAtual.Value.ToString();
                cboLocalArmazem.Text = LocalArmazem;
                btnSalvar.Text = "Atualizar";
            }
            else
            {
                btnSalvar.Text = "Salvar";
            }

        }

        private void CarregarLocalArmazem()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT DESCRICAO FROM LOCAL_ARMAZEM ORDER BY DESCRICAO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        cboLocalArmazem.Items.Clear();

                        while (reader.Read())
                        {
                            string categoria = reader["DESCRICAO"].ToString();
                            if (!string.IsNullOrWhiteSpace(categoria))
                                cboLocalArmazem.Items.Add(categoria);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar categorias: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarCategorias()
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT DESCRICAO FROM CATEGORIA ORDER BY DESCRICAO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        cboCategoria.Items.Clear();

                        while (reader.Read())
                        {
                            string categoria = reader["DESCRICAO"].ToString();
                            if (!string.IsNullOrWhiteSpace(categoria))
                                cboCategoria.Items.Add(categoria);
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


        private bool ProdutoExiste(string codigoProduto)
        {
            string connString = new dbconnection().dbconnect().ToString();
            bool existe = false;

            using (FbConnection conn = new FbConnection(connString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM PRODUTOS WHERE CODIGO = @CODIGO";

                using (FbCommand cmd = new FbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CODIGO", codigoProduto);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = count > 0;
                }
            }

            return existe;
        }


        private void SalvarDados()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Preencha o campo descrição", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string codigo = txtCodigo.Text;
                    string descricao = txtDescricao.Text;
                    string categoria = cboCategoria.Text;
                    string localArmazem = cboLocalArmazem.Text;

                    int stockMinimo = 0;
                    int quantidadeAtual = 0;
                    int.TryParse(txtStockMinimo.Text, out stockMinimo);
                    int.TryParse(txtQuantidadeAtual.Text, out quantidadeAtual);

                    if (string.IsNullOrWhiteSpace(txtID.Text)) // INSERIR
                    {
                        if (ProdutoExiste(codigo))
                        {
                            MessageBox.Show("Este código do produto já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            cmd.CommandText = @"
                    INSERT INTO PRODUTOS 
                    (CODIGO, DESCRICAO, CATEGORIA, STOCKMINIMO, STOCKATUAL, LOCALARMAZEM) 
                    VALUES 
                    (@CODIGO, @DESCRICAO, @CATEGORIA, @STOCKMINIMO, @STOCKATUAL, @LOCALARMAZEM)";
                        }
                        
                        
                    }
                    else // ATUALIZAR
                    {
                        cmd.CommandText = @"
                    UPDATE PRODUTOS SET 
                    CODIGO = @CODIGO, 
                    DESCRICAO = @DESCRICAO, 
                    CATEGORIA = @CATEGORIA, 
                    STOCKMINIMO = @STOCKMINIMO, 
                    STOCKATUAL = @STOCKATUAL, 
                    LOCALARMAZEM = @LOCALARMAZEM 
                    WHERE ID = @ID";

                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
                    }

                    // Adiciona os parâmetros comuns
                    cmd.Parameters.AddWithValue("@CODIGO", codigo);
                    cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                    cmd.Parameters.AddWithValue("@CATEGORIA", categoria);
                    cmd.Parameters.AddWithValue("@STOCKMINIMO", stockMinimo);
                    cmd.Parameters.AddWithValue("@STOCKATUAL", quantidadeAtual);
                    cmd.Parameters.AddWithValue("@LOCALARMAZEM", localArmazem);

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

    }
}
