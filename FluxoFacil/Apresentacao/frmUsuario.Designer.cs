namespace FluxoFacil.Apresentacao
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listaUsuarios = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new FrameworkTest.SATAButton();
            this.btnApagar = new FrameworkTest.SATAButton();
            this.btnSalvar = new FrameworkTest.SATAButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoAcesso = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.listaUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 365);
            this.panel3.TabIndex = 2;
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUsuarios.FormattingEnabled = true;
            this.listaUsuarios.ItemHeight = 17;
            this.listaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(313, 365);
            this.listaUsuarios.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboTipoAcesso);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtConfirmarSenha);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSenha);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(313, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 365);
            this.panel4.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.ButtonText = "Adicionar";
            this.btnAdicionar.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnAdicionar.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdicionar.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdicionar.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdicionar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAdicionar.HoverForeColor = System.Drawing.Color.White;
            this.btnAdicionar.HoverImage = null;
            this.btnAdicionar.HoverImageTint = System.Drawing.Color.White;
            this.btnAdicionar.HoverOutline = System.Drawing.Color.Empty;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAutoCenter = true;
            this.btnAdicionar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAdicionar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdicionar.ImageTint = System.Drawing.Color.White;
            this.btnAdicionar.IsToggleButton = false;
            this.btnAdicionar.IsToggled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(13, 18);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnAdicionar.NormalForeColor = System.Drawing.Color.White;
            this.btnAdicionar.NormalOutline = System.Drawing.Color.Empty;
            this.btnAdicionar.OutlineThickness = 2F;
            this.btnAdicionar.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.PressedForeColor = System.Drawing.Color.White;
            this.btnAdicionar.PressedImageTint = System.Drawing.Color.White;
            this.btnAdicionar.PressedOutline = System.Drawing.Color.Empty;
            this.btnAdicionar.Rounding = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Size = new System.Drawing.Size(140, 45);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.TextAutoCenter = true;
            this.btnAdicionar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagar.ButtonText = "Apagar";
            this.btnApagar.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnApagar.CheckedForeColor = System.Drawing.Color.White;
            this.btnApagar.CheckedImageTint = System.Drawing.Color.White;
            this.btnApagar.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApagar.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnApagar.HoverForeColor = System.Drawing.Color.White;
            this.btnApagar.HoverImage = null;
            this.btnApagar.HoverImageTint = System.Drawing.Color.White;
            this.btnApagar.HoverOutline = System.Drawing.Color.Empty;
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAutoCenter = true;
            this.btnApagar.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnApagar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnApagar.ImageTint = System.Drawing.Color.White;
            this.btnApagar.IsToggleButton = false;
            this.btnApagar.IsToggled = false;
            this.btnApagar.Location = new System.Drawing.Point(258, 18);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(133)))));
            this.btnApagar.NormalForeColor = System.Drawing.Color.White;
            this.btnApagar.NormalOutline = System.Drawing.Color.Empty;
            this.btnApagar.OutlineThickness = 2F;
            this.btnApagar.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnApagar.PressedForeColor = System.Drawing.Color.White;
            this.btnApagar.PressedImageTint = System.Drawing.Color.White;
            this.btnApagar.PressedOutline = System.Drawing.Color.Empty;
            this.btnApagar.Rounding = new System.Windows.Forms.Padding(5);
            this.btnApagar.Size = new System.Drawing.Size(147, 45);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.TextAutoCenter = true;
            this.btnApagar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.btnSalvar.Location = new System.Drawing.Point(515, 18);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(170)))), ((int)(((byte)(115)))));
            this.btnSalvar.NormalForeColor = System.Drawing.Color.White;
            this.btnSalvar.NormalOutline = System.Drawing.Color.Empty;
            this.btnSalvar.OutlineThickness = 2F;
            this.btnSalvar.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.PressedForeColor = System.Drawing.Color.White;
            this.btnSalvar.PressedImageTint = System.Drawing.Color.White;
            this.btnSalvar.PressedOutline = System.Drawing.Color.Empty;
            this.btnSalvar.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Size = new System.Drawing.Size(147, 45);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.TextAutoCenter = true;
            this.btnSalvar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(22, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(327, 25);
            this.txtUsuario.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nome do utilizador:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSenha.Location = new System.Drawing.Point(22, 126);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(327, 25);
            this.txtSenha.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Palavra-passe:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(22, 208);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(327, 25);
            this.txtConfirmarSenha.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Confirmar palavra-passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nível de acesso:";
            // 
            // cboTipoAcesso
            // 
            this.cboTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAcesso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboTipoAcesso.FormattingEnabled = true;
            this.cboTipoAcesso.Items.AddRange(new object[] {
            "User",
            "Admin",
            "SuperAdmin"});
            this.cboTipoAcesso.Location = new System.Drawing.Point(22, 292);
            this.cboTipoAcesso.Name = "cboTipoAcesso";
            this.cboTipoAcesso.Size = new System.Drawing.Size(327, 29);
            this.cboTipoAcesso.TabIndex = 49;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de utilizadores";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listaUsuarios;
        private System.Windows.Forms.Panel panel4;
        private FrameworkTest.SATAButton btnAdicionar;
        private FrameworkTest.SATAButton btnApagar;
        private FrameworkTest.SATAButton btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipoAcesso;
    }
}