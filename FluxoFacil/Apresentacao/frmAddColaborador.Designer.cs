namespace FluxoFacil.Apresentacao
{
    partial class frmAddColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddColaborador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FrameworkTest.SATAButton();
            this.btnSalvar = new FrameworkTest.SATAButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNInterno = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.cboCC = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 70);
            this.panel1.TabIndex = 1;
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
            this.btnCancelar.Location = new System.Drawing.Point(636, 16);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
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
            this.btnSalvar.Location = new System.Drawing.Point(35, 16);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 3);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Área/Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Centro de Custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome do Colaborador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nº Interno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Observação";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtID.Location = new System.Drawing.Point(367, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(69, 25);
            this.txtID.TabIndex = 39;
            this.txtID.Visible = false;
            // 
            // txtNInterno
            // 
            this.txtNInterno.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNInterno.Location = new System.Drawing.Point(35, 31);
            this.txtNInterno.Name = "txtNInterno";
            this.txtNInterno.Size = new System.Drawing.Size(169, 25);
            this.txtNInterno.TabIndex = 33;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(35, 106);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(737, 25);
            this.txtNome.TabIndex = 34;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservacao.Location = new System.Drawing.Point(35, 258);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(737, 120);
            this.txtObservacao.TabIndex = 35;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(35, 188);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(737, 25);
            this.cboDepartamento.TabIndex = 37;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Items.AddRange(new object[] {
            "MOTA-ENGIL ENGENHARIA E CONSTRUÇÃO SA"});
            this.cboEmpresa.Location = new System.Drawing.Point(464, 31);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(308, 25);
            this.cboEmpresa.TabIndex = 38;
            // 
            // cboCC
            // 
            this.cboCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboCC.FormattingEnabled = true;
            this.cboCC.Items.AddRange(new object[] {
            "10159",
            "30159"});
            this.cboCC.Location = new System.Drawing.Point(238, 31);
            this.cboCC.Name = "cboCC";
            this.cboCC.Size = new System.Drawing.Size(192, 25);
            this.cboCC.TabIndex = 39;
            // 
            // frmAddColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 471);
            this.Controls.Add(this.cboCC);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNInterno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Colaborador";
            this.Load += new System.EventHandler(this.frmAddColaborador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FrameworkTest.SATAButton btnCancelar;
        private FrameworkTest.SATAButton btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNInterno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.ComboBox cboCC;
    }
}