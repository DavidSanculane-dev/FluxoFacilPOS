namespace FluxoFacil.Apresentacao
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFlitro = new System.Windows.Forms.Panel();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportExcel = new FrameworkTest.SATAButton();
            this.pnlgrafico = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.graficoDepartamento = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.pnlGraficoBar = new System.Windows.Forms.Panel();
            this.pnlGraficoPizza = new System.Windows.Forms.Panel();
            this.pieChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFlitro.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlgrafico.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.pnlGraficoBar.SuspendLayout();
            this.pnlGraficoPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 34);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório Analítico";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1012, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlDados);
            this.panel2.Controls.Add(this.pnlSeparador);
            this.panel2.Controls.Add(this.pnlFlitro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1050, 603);
            this.panel2.TabIndex = 2;
            // 
            // pnlFlitro
            // 
            this.pnlFlitro.BackColor = System.Drawing.Color.White;
            this.pnlFlitro.Controls.Add(this.label5);
            this.pnlFlitro.Controls.Add(this.label4);
            this.pnlFlitro.Controls.Add(this.label2);
            this.pnlFlitro.Controls.Add(this.label3);
            this.pnlFlitro.Controls.Add(this.btnGerarRelatorio);
            this.pnlFlitro.Controls.Add(this.comboDepartamento);
            this.pnlFlitro.Controls.Add(this.comboProduto);
            this.pnlFlitro.Controls.Add(this.dateFim);
            this.pnlFlitro.Controls.Add(this.dateInicio);
            this.pnlFlitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFlitro.Location = new System.Drawing.Point(0, 5);
            this.pnlFlitro.Name = "pnlFlitro";
            this.pnlFlitro.Size = new System.Drawing.Size(1050, 67);
            this.pnlFlitro.TabIndex = 0;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 72);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(1050, 5);
            this.pnlSeparador.TabIndex = 1;
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.White;
            this.pnlDados.Controls.Add(this.panel5);
            this.pnlDados.Controls.Add(this.panel4);
            this.pnlDados.Controls.Add(this.pnlgrafico);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 77);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(1050, 526);
            this.pnlDados.TabIndex = 2;
            // 
            // dateInicio
            // 
            this.dateInicio.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateInicio.Location = new System.Drawing.Point(10, 28);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(197, 25);
            this.dateInicio.TabIndex = 0;
            // 
            // dateFim
            // 
            this.dateFim.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateFim.Location = new System.Drawing.Point(241, 28);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(200, 25);
            this.dateFim.TabIndex = 1;
            // 
            // comboProduto
            // 
            this.comboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Location = new System.Drawing.Point(462, 28);
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(189, 25);
            this.comboProduto.TabIndex = 3;
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(671, 28);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(189, 25);
            this.comboDepartamento.TabIndex = 4;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorio.Image")));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(875, 19);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(163, 36);
            this.btnGerarRelatorio.TabIndex = 6;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Escolhe o produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(668, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escolhe o departamento";
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
            this.btnExportExcel.Location = new System.Drawing.Point(854, 2);
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
            this.btnExportExcel.Size = new System.Drawing.Size(136, 29);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.TextAutoCenter = true;
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // pnlgrafico
            // 
            this.pnlgrafico.Controls.Add(this.pnlGraficoPizza);
            this.pnlgrafico.Controls.Add(this.pnlGraficoBar);
            this.pnlgrafico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlgrafico.Location = new System.Drawing.Point(0, 285);
            this.pnlgrafico.Name = "pnlgrafico";
            this.pnlgrafico.Size = new System.Drawing.Size(1050, 241);
            this.pnlgrafico.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 5);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPrincipal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 280);
            this.panel5.TabIndex = 2;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrincipal.Size = new System.Drawing.Size(1050, 280);
            this.dgvPrincipal.TabIndex = 3;
            // 
            // graficoDepartamento
            // 
            this.graficoDepartamento.Location = new System.Drawing.Point(107, 32);
            this.graficoDepartamento.MatchAxesScreenDataRatio = false;
            this.graficoDepartamento.Name = "graficoDepartamento";
            this.graficoDepartamento.Size = new System.Drawing.Size(150, 150);
            this.graficoDepartamento.TabIndex = 0;
            // 
            // pnlGraficoBar
            // 
            this.pnlGraficoBar.Controls.Add(this.graficoDepartamento);
            this.pnlGraficoBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGraficoBar.Location = new System.Drawing.Point(0, 0);
            this.pnlGraficoBar.Name = "pnlGraficoBar";
            this.pnlGraficoBar.Size = new System.Drawing.Size(583, 241);
            this.pnlGraficoBar.TabIndex = 1;
            // 
            // pnlGraficoPizza
            // 
            this.pnlGraficoPizza.Controls.Add(this.pieChart);
            this.pnlGraficoPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraficoPizza.Location = new System.Drawing.Point(583, 0);
            this.pnlGraficoPizza.Name = "pnlGraficoPizza";
            this.pnlGraficoPizza.Size = new System.Drawing.Size(467, 241);
            this.pnlGraficoPizza.TabIndex = 2;
            // 
            // pieChart
            // 
            this.pieChart.InitialRotation = 0D;
            this.pieChart.IsClockwise = true;
            this.pieChart.Location = new System.Drawing.Point(163, 32);
            this.pieChart.MaxAngle = 360D;
            this.pieChart.MaxValue = double.NaN;
            this.pieChart.MinValue = 0D;
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(150, 150);
            this.pieChart.TabIndex = 0;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlFlitro.ResumeLayout(false);
            this.pnlFlitro.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlgrafico.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.pnlGraficoBar.ResumeLayout(false);
            this.pnlGraficoPizza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFlitro;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FrameworkTest.SATAButton btnExportExcel;
        private System.Windows.Forms.Panel pnlgrafico;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Panel panel4;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart graficoDepartamento;
        private System.Windows.Forms.Panel pnlGraficoBar;
        private System.Windows.Forms.Panel pnlGraficoPizza;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart;
    }
}