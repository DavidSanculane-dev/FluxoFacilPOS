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
    public partial class frmSplash : Form
    {
        private Timer timer;
        private int progresso = 0;

        public frmSplash()
        {
            InitializeComponent();


            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 30); // fundo escuro
            this.Opacity = 0; // começa invisível

            // Logo
            Label lblLogo = new Label();
            lblLogo.Text = "FluxoFacil";
            lblLogo.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblLogo.ForeColor = Color.Cyan;
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point((this.Width - lblLogo.Width) / 10, 50);
            this.Controls.Add(lblLogo);

            // Barra de progresso
            ProgressBar progressBar = new ProgressBar();
            progressBar.Name = "progressBar";
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.ForeColor = Color.DeepSkyBlue;
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Height = 20;
            progressBar.Location = new Point((this.Width - progressBar.Width) / 2, 150);
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
                    new frmLogin().Show(); // substitua por seu form principal
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
