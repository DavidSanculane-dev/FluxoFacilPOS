namespace FluxoFacil.Dados
{
    partial class frmConexaoDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexaoDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FrameworkTest.SATAButton();
            this.btnSalvar = new FrameworkTest.SATAButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBancoDados = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestarConexão = new FrameworkTest.SATAButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 70);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancelar.CheckedImageTint = System.Drawing.Color.White;
            this.btnCancelar.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnCancelar.HoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverImage = null;
            this.btnCancelar.HoverImageTint = System.Drawing.Color.White;
            this.btnCancelar.HoverOutline = System.Drawing.Color.Empty;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAutoCenter = true;
            this.btnCancelar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCancelar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancelar.ImageTint = System.Drawing.Color.White;
            this.btnCancelar.IsToggleButton = false;
            this.btnCancelar.IsToggled = false;
            this.btnCancelar.Location = new System.Drawing.Point(353, 17);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.NormalForeColor = System.Drawing.Color.White;
            this.btnCancelar.NormalOutline = System.Drawing.Color.Empty;
            this.btnCancelar.OutlineThickness = 2F;
            this.btnCancelar.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.PressedForeColor = System.Drawing.Color.White;
            this.btnCancelar.PressedImageTint = System.Drawing.Color.White;
            this.btnCancelar.PressedOutline = System.Drawing.Color.Empty;
            this.btnCancelar.Rounding = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Size = new System.Drawing.Size(136, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TextAutoCenter = true;
            this.btnCancelar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.CheckedForeColor = System.Drawing.Color.White;
            this.btnSalvar.CheckedImageTint = System.Drawing.Color.White;
            this.btnSalvar.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSalvar.HoverForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverImage = null;
            this.btnSalvar.HoverImageTint = System.Drawing.Color.White;
            this.btnSalvar.HoverOutline = System.Drawing.Color.Empty;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAutoCenter = true;
            this.btnSalvar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSalvar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSalvar.ImageTint = System.Drawing.Color.White;
            this.btnSalvar.IsToggleButton = false;
            this.btnSalvar.IsToggled = false;
            this.btnSalvar.Location = new System.Drawing.Point(13, 16);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSalvar.NormalForeColor = System.Drawing.Color.White;
            this.btnSalvar.NormalOutline = System.Drawing.Color.Empty;
            this.btnSalvar.OutlineThickness = 2F;
            this.btnSalvar.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.PressedForeColor = System.Drawing.Color.White;
            this.btnSalvar.PressedImageTint = System.Drawing.Color.White;
            this.btnSalvar.PressedOutline = System.Drawing.Color.Empty;
            this.btnSalvar.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Size = new System.Drawing.Size(136, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.TextAutoCenter = true;
            this.btnSalvar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 3);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSenha);
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.txtBancoDados);
            this.panel4.Controls.Add(this.txtPorta);
            this.panel4.Controls.Add(this.txtServidor);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnTestarConexão);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 245);
            this.panel4.TabIndex = 14;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(18, 183);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(175, 25);
            this.txtSenha.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(313, 111);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 25);
            this.txtUsuario.TabIndex = 19;
            // 
            // txtBancoDados
            // 
            this.txtBancoDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancoDados.Location = new System.Drawing.Point(18, 111);
            this.txtBancoDados.Name = "txtBancoDados";
            this.txtBancoDados.Size = new System.Drawing.Size(271, 25);
            this.txtBancoDados.TabIndex = 18;
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(353, 36);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(130, 25);
            this.txtPorta.TabIndex = 17;
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(18, 36);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(307, 25);
            this.txtServidor.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Palavra-passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuário (padrão: SYSDBA)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Caminho do Banco de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Porta (padrão: 3050)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor";
            // 
            // btnTestarConexão
            // 
            this.btnTestarConexão.ButtonText = "Testar a conexão com banco de dados";
            this.btnTestarConexão.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnTestarConexão.CheckedForeColor = System.Drawing.Color.White;
            this.btnTestarConexão.CheckedImageTint = System.Drawing.Color.White;
            this.btnTestarConexão.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnTestarConexão.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestarConexão.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTestarConexão.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexão.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnTestarConexão.HoverForeColor = System.Drawing.Color.White;
            this.btnTestarConexão.HoverImage = null;
            this.btnTestarConexão.HoverImageTint = System.Drawing.Color.White;
            this.btnTestarConexão.HoverOutline = System.Drawing.Color.Empty;
            this.btnTestarConexão.Image = ((System.Drawing.Image)(resources.GetObject("btnTestarConexão.Image")));
            this.btnTestarConexão.ImageAutoCenter = true;
            this.btnTestarConexão.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnTestarConexão.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTestarConexão.ImageTint = System.Drawing.Color.White;
            this.btnTestarConexão.IsToggleButton = false;
            this.btnTestarConexão.IsToggled = false;
            this.btnTestarConexão.Location = new System.Drawing.Point(214, 178);
            this.btnTestarConexão.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTestarConexão.Name = "btnTestarConexão";
            this.btnTestarConexão.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnTestarConexão.NormalForeColor = System.Drawing.Color.White;
            this.btnTestarConexão.NormalOutline = System.Drawing.Color.Empty;
            this.btnTestarConexão.OutlineThickness = 2F;
            this.btnTestarConexão.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnTestarConexão.PressedForeColor = System.Drawing.Color.White;
            this.btnTestarConexão.PressedImageTint = System.Drawing.Color.White;
            this.btnTestarConexão.PressedOutline = System.Drawing.Color.Empty;
            this.btnTestarConexão.Rounding = new System.Windows.Forms.Padding(5);
            this.btnTestarConexão.Size = new System.Drawing.Size(275, 41);
            this.btnTestarConexão.TabIndex = 5;
            this.btnTestarConexão.TextAutoCenter = true;
            this.btnTestarConexão.TextOffset = new System.Drawing.Point(0, 0);
            this.btnTestarConexão.Click += new System.EventHandler(this.btnTestarConexão_Click);
            // 
            // frmConexaoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 388);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConexaoDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexão com banco de dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConexaoDB_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FrameworkTest.SATAButton btnCancelar;
        private FrameworkTest.SATAButton btnSalvar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FrameworkTest.SATAButton btnTestarConexão;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtBancoDados;
        private System.Windows.Forms.TextBox txtPorta;
    }
}