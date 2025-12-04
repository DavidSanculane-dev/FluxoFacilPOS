namespace FluxoFacil.Apresentacao
{
    partial class frmAddProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FrameworkTest.SATAButton();
            this.btnSalvar = new FrameworkTest.SATAButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQuantidadeAtual = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboLocalArmazem = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 70);
            this.panel1.TabIndex = 0;
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
            this.btnCancelar.Location = new System.Drawing.Point(519, 16);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock Minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 3);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Local do Armazém";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCodigo.Location = new System.Drawing.Point(35, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 25);
            this.txtCodigo.TabIndex = 32;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(35, 111);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(610, 25);
            this.txtDescricao.TabIndex = 33;
            // 
            // txtQuantidadeAtual
            // 
            this.txtQuantidadeAtual.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQuantidadeAtual.Location = new System.Drawing.Point(35, 264);
            this.txtQuantidadeAtual.Name = "txtQuantidadeAtual";
            this.txtQuantidadeAtual.Size = new System.Drawing.Size(169, 25);
            this.txtQuantidadeAtual.TabIndex = 34;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStockMinimo.Location = new System.Drawing.Point(476, 264);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(169, 25);
            this.txtStockMinimo.TabIndex = 35;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(328, 46);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(317, 25);
            this.cboCategoria.TabIndex = 36;
            // 
            // cboLocalArmazem
            // 
            this.cboLocalArmazem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLocalArmazem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalArmazem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboLocalArmazem.FormattingEnabled = true;
            this.cboLocalArmazem.Location = new System.Drawing.Point(35, 193);
            this.cboLocalArmazem.Name = "cboLocalArmazem";
            this.cboLocalArmazem.Size = new System.Drawing.Size(610, 25);
            this.cboLocalArmazem.TabIndex = 37;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtID.Location = new System.Drawing.Point(292, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(69, 25);
            this.txtID.TabIndex = 38;
            this.txtID.Visible = false;
            // 
            // frmAddProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 377);
            this.Controls.Add(this.cboLocalArmazem);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.txtQuantidadeAtual);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produtos";
            this.Load += new System.EventHandler(this.frmAddProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FrameworkTest.SATAButton btnCancelar;
        private FrameworkTest.SATAButton btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtQuantidadeAtual;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboLocalArmazem;
        private System.Windows.Forms.TextBox txtID;
    }
}