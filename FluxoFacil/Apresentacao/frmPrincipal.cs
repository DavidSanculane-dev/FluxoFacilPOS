using FluxoFacil.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil
{
    public partial class frmPrincipal : Form
    {
        public string Usuario { get; set; }
        public string TipoUsuario { get; set; }

        private bool permitirFechar = false;

        public frmPrincipal()
        {
            InitializeComponent();
            pnlGestaoStock.Visible = false;
            pnlEntregas.Visible = false;
            pnlAdministracao.Visible = false;
            pnlColorAdministracao.Visible = false;
            pnlColorDash.Visible = true;
            pnlColorEntrega.Visible = false;
            pnlColorStock.Visible = false;
            pnlColorRelatorio.Visible = false;

            LoadForm(new Apresentacao.frmDashboard());
        }

        private void LoadForm(Form frm)
        {
            
            pnlContent.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void PermissaoUsuario()
        {
            switch (TipoUsuario)
            {
                case "User":
                    pnlAdministracao.Visible = false;
                    pnlAdmin.Visible = false;
                    pnlBtnGestaoStock.Visible = false;
                    pnlRelatorio.Visible = false;
                    pnlBtnEntrega.Visible = true;
                    break;
                case "Admin":
                    pnlAdmin.Visible = true;
                    btnUser.Visible = false;
                    pnlBtnGestaoStock.Visible = false;
                    pnlRelatorio.Visible = true;
                    pnlBtnEntrega.Visible = true;
                    break;

                case "SuperAdmin":
                    pnlAdmin.Visible = true;
                    pnlBtnGestaoStock.Visible = true;
                    pnlRelatorio.Visible = true;
                    pnlBtnEntrega.Visible = true;
                    break;
                default:
                    MessageBox.Show("Tipo de usuário desconhecido.");
                    break;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Usuario;
            lblTipoUser.Text = TipoUsuario;
            PermissaoUsuario();
            
        }

        private void btnResumo_Click(object sender, EventArgs e)
        {
            pnlColorDash.Visible = true;
            pnlColorAdministracao.Visible = false;
            pnlColorEntrega.Visible = false;
            pnlColorStock.Visible = false;
            pnlColorRelatorio.Visible = false;

            pnlGestaoStock.Visible = false;
            pnlEntregas.Visible = false;
            pnlAdministracao.Visible = false;

            LoadForm(new Apresentacao.frmDashboard());
        }

        private void btnGestaoStock_Click(object sender, EventArgs e)
        {
            pnlColorDash.Visible = false;
            pnlColorAdministracao.Visible = false;
            pnlColorEntrega.Visible = false;
            pnlColorStock.Visible = true;
            pnlColorRelatorio.Visible = false;

            pnlGestaoStock.Visible = true;
            pnlEntregas.Visible = false;
            pnlAdministracao.Visible = false;
        }

        private void btnEntregasList_Click(object sender, EventArgs e)
        {
            pnlColorDash.Visible = false;
            pnlColorAdministracao.Visible = false;
            pnlColorEntrega.Visible = true;
            pnlColorStock.Visible = false;
            pnlColorRelatorio.Visible = false;


            pnlGestaoStock.Visible = false;
            pnlEntregas.Visible = true;
            pnlAdministracao.Visible = false;

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnlColorDash.Visible = false;
            pnlColorAdministracao.Visible = false;
            pnlColorEntrega.Visible = false;
            pnlColorStock.Visible = false;
            pnlColorRelatorio.Visible = true;
            LoadForm(new Apresentacao.frmRelatorio());
        }

        private void btnAdministracao_Click(object sender, EventArgs e)
        {
            pnlColorDash.Visible = false;
            pnlColorAdministracao.Visible = true;
            pnlColorEntrega.Visible = false;
            pnlColorStock.Visible = false;
            pnlColorRelatorio.Visible = false;


            pnlGestaoStock.Visible = false;
            pnlEntregas.Visible = false;
            pnlAdministracao.Visible = true;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            string logado = lblUsuario.Text;
            LoadForm(new Apresentacao.frmProdutos(logado));
        }

        private void btnCategoriaProduto_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmCategoriaProduto());

        }

        private void btnLocalArmazem_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmLocalArmazem());
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmColaboradores());
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmDepartamento());
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            frmEntrega frm = new frmEntrega();
            frm.usuario = lblUsuario.Text;
            frm.Show();
        }

        private void btnEntradaStock_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmEntradaStock());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            permitirFechar = true;
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnSaidaStock_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmMovimentos());
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!permitirFechar)
            {
                MessageBox.Show("Por favor, clique no botão 'Sair do Sistema' para efetuar o Logout.");
                e.Cancel = true; // Impede o fechamento do formulário
            }
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            LoadForm(new Apresentacao.frmSolicitacoes());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.ShowDialog();
        }
    }
}
