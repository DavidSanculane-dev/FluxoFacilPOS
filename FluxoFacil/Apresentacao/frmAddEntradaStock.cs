using FirebirdSql.Data.FirebirdClient;
using FluxoFacil.Dados;
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
    public partial class frmAddEntradaStock : Form
    {
        public int? ID { get; set; }
        public string Descricao { get; set; }
        public string LocalArmazem { get; set; }
        public string UsuarioLogado { get; set; }

        public frmAddEntradaStock()
        {
            InitializeComponent();
            
        }

        private void frmAddEntradaStock_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UsuarioLogado;

            if (ID.HasValue)
            {
                txtID.Text = ID.ToString();
                lblDescricao.Text = Descricao;
                lblLocalArmazem.Text = LocalArmazem;
                

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtID.Text, out int id) && int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                EntradaDeStock(id, quantidade);
                InserirTabelaStockIn();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("ID ou Quantidade inválidos.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void EntradaDeStock(int id, int quantidadeEntrada)
        {
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE PRODUTOS SET STOCKATUAL = STOCKATUAL + @ENTRADA WHERE ID = @ID";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ENTRADA", quantidadeEntrada);
                        cmd.Parameters.AddWithValue("@ID", id);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                            MessageBox.Show("Entrada de stock registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void InserirTabelaStockIn()
        {

            string data = DateTime.Now.ToShortDateString();
            string descricao = lblDescricao.Text;
            string armazem = lblLocalArmazem.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            
            string utilizador = lblUsuario.Text;
            
            string connString = new dbconnection().dbconnect().ToString();

            using (FbConnection conn = new FbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO ENTRADA_STOCK (DATA_ENTRADA, DESCRICAO, lOCAL_ARMAZEM, QUANTIDADE, UTILIZADOR) VALUES (@DATE, @DESCRICAO, @ARMAZEM, @QUANTIDADE, @UTILIZADOR)";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DATE", data);
                        cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                        cmd.Parameters.AddWithValue("@ARMAZEM", armazem);
                        cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                        cmd.Parameters.AddWithValue("@UTILIZADOR", utilizador);
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                            MessageBox.Show("Stock atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Falha ao inserir Entrada de Stock", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao inserir Entrada de Stock: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
