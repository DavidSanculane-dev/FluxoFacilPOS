namespace FluxoFacil.Apresentacao
{
    partial class frmCategoriaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriaProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.btnSaveExcel = new FrameworkTest.SATAButton();
            this.btnImportExcel = new FrameworkTest.SATAButton();
            this.btnExportExcel = new FrameworkTest.SATAButton();
            this.btnAdicionar = new FrameworkTest.SATAButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.dgvImportacaoExcel = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacaoExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProcurar);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnSaveExcel);
            this.panel1.Controls.Add(this.btnImportExcel);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 51);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Procurar por descrição";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProcurar.Location = new System.Drawing.Point(387, 17);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(262, 25);
            this.txtProcurar.TabIndex = 42;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(668, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "ID";
            this.txtID.Visible = false;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExcel.ButtonText = "Salvar importação";
            this.btnSaveExcel.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSaveExcel.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveExcel.CheckedImageTint = System.Drawing.Color.White;
            this.btnSaveExcel.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnSaveExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveExcel.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveExcel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveExcel.HoverForeColor = System.Drawing.Color.White;
            this.btnSaveExcel.HoverImage = null;
            this.btnSaveExcel.HoverImageTint = System.Drawing.Color.White;
            this.btnSaveExcel.HoverOutline = System.Drawing.Color.Empty;
            this.btnSaveExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveExcel.Image")));
            this.btnSaveExcel.ImageAutoCenter = true;
            this.btnSaveExcel.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSaveExcel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSaveExcel.ImageTint = System.Drawing.Color.White;
            this.btnSaveExcel.IsToggleButton = false;
            this.btnSaveExcel.IsToggled = false;
            this.btnSaveExcel.Location = new System.Drawing.Point(702, 9);
            this.btnSaveExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnSaveExcel.NormalForeColor = System.Drawing.Color.White;
            this.btnSaveExcel.NormalOutline = System.Drawing.Color.Empty;
            this.btnSaveExcel.OutlineThickness = 2F;
            this.btnSaveExcel.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnSaveExcel.PressedForeColor = System.Drawing.Color.White;
            this.btnSaveExcel.PressedImageTint = System.Drawing.Color.White;
            this.btnSaveExcel.PressedOutline = System.Drawing.Color.Empty;
            this.btnSaveExcel.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSaveExcel.Size = new System.Drawing.Size(136, 36);
            this.btnSaveExcel.TabIndex = 6;
            this.btnSaveExcel.TextAutoCenter = true;
            this.btnSaveExcel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportExcel.ButtonText = "Importar Excel";
            this.btnImportExcel.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnImportExcel.CheckedForeColor = System.Drawing.Color.White;
            this.btnImportExcel.CheckedImageTint = System.Drawing.Color.White;
            this.btnImportExcel.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportExcel.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImportExcel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnImportExcel.HoverForeColor = System.Drawing.Color.White;
            this.btnImportExcel.HoverImage = null;
            this.btnImportExcel.HoverImageTint = System.Drawing.Color.White;
            this.btnImportExcel.HoverOutline = System.Drawing.Color.Empty;
            this.btnImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.Image")));
            this.btnImportExcel.ImageAutoCenter = true;
            this.btnImportExcel.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnImportExcel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnImportExcel.ImageTint = System.Drawing.Color.White;
            this.btnImportExcel.IsToggleButton = false;
            this.btnImportExcel.IsToggled = false;
            this.btnImportExcel.Location = new System.Drawing.Point(856, 9);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnImportExcel.NormalForeColor = System.Drawing.Color.White;
            this.btnImportExcel.NormalOutline = System.Drawing.Color.Empty;
            this.btnImportExcel.OutlineThickness = 2F;
            this.btnImportExcel.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnImportExcel.PressedForeColor = System.Drawing.Color.White;
            this.btnImportExcel.PressedImageTint = System.Drawing.Color.White;
            this.btnImportExcel.PressedOutline = System.Drawing.Color.Empty;
            this.btnImportExcel.Rounding = new System.Windows.Forms.Padding(5);
            this.btnImportExcel.Size = new System.Drawing.Size(136, 36);
            this.btnImportExcel.TabIndex = 5;
            this.btnImportExcel.TextAutoCenter = true;
            this.btnImportExcel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
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
            this.btnExportExcel.Location = new System.Drawing.Point(1010, 9);
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
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.TextAutoCenter = true;
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, 0);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnAdicionar
            // 
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
            this.btnAdicionar.Location = new System.Drawing.Point(96, 9);
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
            this.btnAdicionar.Size = new System.Drawing.Size(102, 36);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.TextAutoCenter = true;
            this.btnAdicionar.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1168, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 5);
            this.panel2.TabIndex = 3;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgvPrincipal);
            this.pnlDGV.Controls.Add(this.dgvImportacaoExcel);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGV.Location = new System.Drawing.Point(0, 56);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(1206, 707);
            this.pnlDGV.TabIndex = 4;
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
            this.dgvPrincipal.Location = new System.Drawing.Point(712, 197);
            this.dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrincipal.Size = new System.Drawing.Size(344, 251);
            this.dgvPrincipal.TabIndex = 1;
            // 
            // dgvImportacaoExcel
            // 
            this.dgvImportacaoExcel.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportacaoExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportacaoExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportacaoExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportacaoExcel.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvImportacaoExcel.Location = new System.Drawing.Point(65, 94);
            this.dgvImportacaoExcel.Name = "dgvImportacaoExcel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportacaoExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvImportacaoExcel.Size = new System.Drawing.Size(344, 251);
            this.dgvImportacaoExcel.TabIndex = 0;
            // 
            // frmCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 763);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoriaProduto";
            this.Text = "frmCategoriaProduto";
            this.Load += new System.EventHandler(this.frmCategoriaProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacaoExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtID;
        private FrameworkTest.SATAButton btnSaveExcel;
        private FrameworkTest.SATAButton btnImportExcel;
        private FrameworkTest.SATAButton btnExportExcel;
        private FrameworkTest.SATAButton btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.DataGridView dgvImportacaoExcel;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label label2;
    }
}