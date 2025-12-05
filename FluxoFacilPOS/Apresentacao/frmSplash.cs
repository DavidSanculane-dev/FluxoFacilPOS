using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace FluxoFacil.Apresentacao
{
    public partial class frmSplash : Form
    {
        private Timer timer;
        private int progresso = 0;

        public frmSplash()
        {
            InitializeComponent();

            // Configurações da janela
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(25, 25, 25); // fundo escuro elegante
            this.Size = new Size(600, 350);
            this.Opacity = 0; // começa invisível
            this.DoubleBuffered = true;


            // Logo / Título

            Label lblLogo = new Label();
            lblLogo.Text = "FluxoFacilPOS";
            lblLogo.Font = new Font("Segoe UI", 32, FontStyle.Bold);
            lblLogo.ForeColor = Color.DeepSkyBlue;
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point((this.ClientSize.Width - lblLogo.PreferredWidth) / 2, 60);
            this.Controls.Add(lblLogo);


            // Subtítulo


            Label lblSub = new Label();
            lblSub.Text = "Ponto de Venda Inteligente";
            lblSub.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblSub.ForeColor = Color.LightGray;
            lblSub.AutoSize = true;
            lblSub.Location = new Point((this.ClientSize.Width - lblSub.PreferredWidth) / 2, 120);
            this.Controls.Add(lblSub);




            // Barra de progresso


            ProgressBar progressBar = new ProgressBar();
            progressBar.Name = "progressBar";
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.ForeColor = Color.DeepSkyBlue;
            progressBar.BackColor = Color.FromArgb(45, 45, 45);
            progressBar.Dock = DockStyle.Bottom; // ocupa toda a largura
            progressBar.Height = 20;
            this.Controls.Add(progressBar);


            // Timer para animação

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;

                progresso += 2;
                progressBar.Value = Math.Min(progresso, 100);

                if (progresso >= 100)
                {
                    timer.Stop();
                    this.Hide();
                    new frmLogin().Show(); // substitua pelo form principal
                }
            };


        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            timer.Start();
        }


        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
