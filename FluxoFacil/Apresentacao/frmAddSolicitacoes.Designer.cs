namespace FluxoFacil.Apresentacao
{
    partial class frmAddSolicitacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSolicitacoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new FrameworkTest.SATAButton();
            this.btnSalvar = new FrameworkTest.SATAButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProcurarNInterno = new System.Windows.Forms.TextBox();
            this.btnBuscarDados = new FrameworkTest.SATAButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoPedido = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 70);
            this.panel1.TabIndex = 2;
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
            this.btnCancelar.Location = new System.Drawing.Point(646, 16);
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
            this.btnSalvar.Location = new System.Drawing.Point(11, 16);
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
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 3);
            this.panel2.TabIndex = 14;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(15, 224);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(767, 78);
            this.txtDescricao.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Descrição do material";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtProcurarNInterno);
            this.panel3.Controls.Add(this.btnBuscarDados);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 70);
            this.panel3.TabIndex = 52;
            // 
            // txtProcurarNInterno
            // 
            this.txtProcurarNInterno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarNInterno.Location = new System.Drawing.Point(21, 30);
            this.txtProcurarNInterno.Name = "txtProcurarNInterno";
            this.txtProcurarNInterno.Size = new System.Drawing.Size(298, 29);
            this.txtProcurarNInterno.TabIndex = 45;
            this.txtProcurarNInterno.TextChanged += new System.EventHandler(this.txtProcurarNInterno_TextChanged);
            // 
            // btnBuscarDados
            // 
            this.btnBuscarDados.ButtonText = "Procurar";
            this.btnBuscarDados.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnBuscarDados.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscarDados.CheckedImageTint = System.Drawing.Color.White;
            this.btnBuscarDados.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnBuscarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDados.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDados.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBuscarDados.HoverForeColor = System.Drawing.Color.White;
            this.btnBuscarDados.HoverImage = null;
            this.btnBuscarDados.HoverImageTint = System.Drawing.Color.White;
            this.btnBuscarDados.HoverOutline = System.Drawing.Color.Empty;
            this.btnBuscarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDados.Image")));
            this.btnBuscarDados.ImageAutoCenter = true;
            this.btnBuscarDados.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBuscarDados.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBuscarDados.ImageTint = System.Drawing.Color.White;
            this.btnBuscarDados.IsToggleButton = false;
            this.btnBuscarDados.IsToggled = false;
            this.btnBuscarDados.Location = new System.Drawing.Point(333, 26);
            this.btnBuscarDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarDados.Name = "btnBuscarDados";
            this.btnBuscarDados.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnBuscarDados.NormalForeColor = System.Drawing.Color.White;
            this.btnBuscarDados.NormalOutline = System.Drawing.Color.Empty;
            this.btnBuscarDados.OutlineThickness = 2F;
            this.btnBuscarDados.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnBuscarDados.PressedForeColor = System.Drawing.Color.White;
            this.btnBuscarDados.PressedImageTint = System.Drawing.Color.White;
            this.btnBuscarDados.PressedOutline = System.Drawing.Color.Empty;
            this.btnBuscarDados.Rounding = new System.Windows.Forms.Padding(5);
            this.btnBuscarDados.Size = new System.Drawing.Size(107, 35);
            this.btnBuscarDados.TabIndex = 44;
            this.btnBuscarDados.TextAutoCenter = true;
            this.btnBuscarDados.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBuscarDados.Click += new System.EventHandler(this.btnBuscarDados_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Procure pelo Nº Interno do colaborador";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblNomeColaborador);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 105);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preenchimento automático dos dados";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartamento.Location = new System.Drawing.Point(460, 63);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(40, 21);
            this.lblDepartamento.TabIndex = 43;
            this.lblDepartamento.Text = "-----";
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeColaborador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeColaborador.Location = new System.Drawing.Point(9, 63);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(46, 21);
            this.lblNomeColaborador.TabIndex = 42;
            this.lblNomeColaborador.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Área / Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome do colaborador";
            // 
            // cboEstadoPedido
            // 
            this.cboEstadoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboEstadoPedido.FormattingEnabled = true;
            this.cboEstadoPedido.Items.AddRange(new object[] {
            "Em processo de aquisição",
            "Aguarda aprovação",
            "Solicitação resolvida"});
            this.cboEstadoPedido.Location = new System.Drawing.Point(15, 362);
            this.cboEstadoPedido.Name = "cboEstadoPedido";
            this.cboEstadoPedido.Size = new System.Drawing.Size(260, 25);
            this.cboEstadoPedido.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Estado do pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Data da solicitação";
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(451, 359);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(331, 25);
            this.dtPicker.TabIndex = 57;
            // 
            // frmAddSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 514);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEstadoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSolicitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitações/Encomendas";
            this.Load += new System.EventHandler(this.frmAddSolicitacoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private FrameworkTest.SATAButton btnCancelar;
        private FrameworkTest.SATAButton btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProcurarNInterno;
        private FrameworkTest.SATAButton btnBuscarDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstadoPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}