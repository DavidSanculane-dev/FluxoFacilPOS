namespace FluxoFacil.Apresentacao
{
    partial class frmHistoricoColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricoColaborador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDadosColaborador = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportExcel = new FrameworkTest.SATAButton();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.txtProcurarNInterno = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPesquisarDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlDadosColaborador.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtProcurarNInterno);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos dos últimos 30 dias";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 5);
            this.panel2.TabIndex = 1;
            // 
            // pnlDadosColaborador
            // 
            this.pnlDadosColaborador.BackColor = System.Drawing.Color.White;
            this.pnlDadosColaborador.Controls.Add(this.panel5);
            this.pnlDadosColaborador.Controls.Add(this.panel3);
            this.pnlDadosColaborador.Controls.Add(this.lblDepartamento);
            this.pnlDadosColaborador.Controls.Add(this.lblNomeColaborador);
            this.pnlDadosColaborador.Controls.Add(this.label5);
            this.pnlDadosColaborador.Controls.Add(this.label3);
            this.pnlDadosColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDadosColaborador.Location = new System.Drawing.Point(0, 46);
            this.pnlDadosColaborador.Name = "pnlDadosColaborador";
            this.pnlDadosColaborador.Size = new System.Drawing.Size(816, 122);
            this.pnlDadosColaborador.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(816, 5);
            this.panel4.TabIndex = 3;
            // 
            // pnlDgv
            // 
            this.pnlDgv.BackColor = System.Drawing.Color.White;
            this.pnlDgv.Controls.Add(this.dgvPrincipal);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgv.Location = new System.Drawing.Point(0, 173);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(816, 379);
            this.pnlDgv.TabIndex = 4;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartamento.Location = new System.Drawing.Point(366, 30);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(32, 21);
            this.lblDepartamento.TabIndex = 51;
            this.lblDepartamento.Text = "TIC";
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeColaborador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeColaborador.Location = new System.Drawing.Point(13, 33);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(293, 21);
            this.lblNomeColaborador.TabIndex = 50;
            this.lblNomeColaborador.Text = "DAVID CONDE JEQUECENE SANCULANE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(367, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Área / Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nome do colaborador";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.ButtonText = "Exportar Excel";
            this.btnExportExcel.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.CheckedForeColor = System.Drawing.Color.White;
            this.btnExportExcel.CheckedImageTint = System.Drawing.Color.White;
            this.btnExportExcel.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportExcel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnExportExcel.HoverForeColor = System.Drawing.Color.White;
            this.btnExportExcel.HoverImage = null;
            this.btnExportExcel.HoverImageTint = System.Drawing.Color.White;
            this.btnExportExcel.HoverOutline = System.Drawing.Color.Empty;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAutoCenter = true;
            this.btnExportExcel.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnExportExcel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExportExcel.ImageTint = System.Drawing.Color.White;
            this.btnExportExcel.IsToggleButton = false;
            this.btnExportExcel.IsToggled = false;
            this.btnExportExcel.Location = new System.Drawing.Point(674, 2);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnExportExcel.NormalForeColor = System.Drawing.Color.White;
            this.btnExportExcel.NormalOutline = System.Drawing.Color.Empty;
            this.btnExportExcel.OutlineThickness = 2F;
            this.btnExportExcel.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnExportExcel.PressedForeColor = System.Drawing.Color.White;
            this.btnExportExcel.PressedImageTint = System.Drawing.Color.White;
            this.btnExportExcel.PressedOutline = System.Drawing.Color.Empty;
            this.btnExportExcel.Rounding = new System.Windows.Forms.Padding(5);
            this.btnExportExcel.Size = new System.Drawing.Size(136, 36);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.TextAutoCenter = true;
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPrincipal.Location = new System.Drawing.Point(236, 63);
            this.dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPrincipal.Size = new System.Drawing.Size(344, 251);
            this.dgvPrincipal.TabIndex = 3;
            // 
            // txtProcurarNInterno
            // 
            this.txtProcurarNInterno.Enabled = false;
            this.txtProcurarNInterno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarNInterno.Location = new System.Drawing.Point(259, 6);
            this.txtProcurarNInterno.Name = "txtProcurarNInterno";
            this.txtProcurarNInterno.Size = new System.Drawing.Size(277, 29);
            this.txtProcurarNInterno.TabIndex = 43;
            this.txtProcurarNInterno.TextChanged += new System.EventHandler(this.txtProcurarNInterno_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPesquisarDescricao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 59);
            this.panel3.TabIndex = 52;
            // 
            // txtPesquisarDescricao
            // 
            this.txtPesquisarDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarDescricao.Location = new System.Drawing.Point(17, 24);
            this.txtPesquisarDescricao.Name = "txtPesquisarDescricao";
            this.txtPesquisarDescricao.Size = new System.Drawing.Size(519, 29);
            this.txtPesquisarDescricao.TabIndex = 44;
            this.txtPesquisarDescricao.TextChanged += new System.EventHandler(this.txtPesquisarDescricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Filtrar por nome do produto:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 5);
            this.panel5.TabIndex = 53;
            // 
            // frmHistoricoColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 552);
            this.Controls.Add(this.pnlDgv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlDadosColaborador);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistoricoColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico do Colaborador";
            this.Load += new System.EventHandler(this.frmHistoricoColaborador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDadosColaborador.ResumeLayout(false);
            this.pnlDadosColaborador.PerformLayout();
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDadosColaborador;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private FrameworkTest.SATAButton btnExportExcel;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.TextBox txtProcurarNInterno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisarDescricao;
        private System.Windows.Forms.Panel panel5;
    }
}