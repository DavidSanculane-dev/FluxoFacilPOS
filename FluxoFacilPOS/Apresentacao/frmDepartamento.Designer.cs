namespace FluxoFacil.Apresentacao
{
    partial class frmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.Label();
            this.btnSaveExcel = new FrameworkTest.SATAButton();
            this.btnImportExcel = new FrameworkTest.SATAButton();
            this.btnExportExcel = new FrameworkTest.SATAButton();
            this.btnAdicionar = new FrameworkTest.SATAButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvImportacaoExcel = new System.Windows.Forms.DataGridView();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacaoExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1189, 51);
            this.panel1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(660, 23);
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
            this.btnSaveExcel.Location = new System.Drawing.Point(685, 9);
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
            this.btnImportExcel.Location = new System.Drawing.Point(839, 9);
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
            this.btnExportExcel.Location = new System.Drawing.Point(993, 9);
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
            this.btnAdicionar.Location = new System.Drawing.Point(159, 9);
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
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Área/Departamento";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1151, 0);
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
            this.panel2.Size = new System.Drawing.Size(1189, 5);
            this.panel2.TabIndex = 4;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgvImportacaoExcel);
            this.pnlDGV.Controls.Add(this.dgvPrincipal);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGV.Location = new System.Drawing.Point(0, 56);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(1189, 641);
            this.pnlDGV.TabIndex = 5;
            // 
            // dgvImportacaoExcel
            // 
            this.dgvImportacaoExcel.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportacaoExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportacaoExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvImportacaoExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportacaoExcel.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvImportacaoExcel.Location = new System.Drawing.Point(94, 72);
            this.dgvImportacaoExcel.Name = "dgvImportacaoExcel";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportacaoExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvImportacaoExcel.Size = new System.Drawing.Size(344, 251);
            this.dgvImportacaoExcel.TabIndex = 3;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPrincipal.Location = new System.Drawing.Point(614, 281);
            this.dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPrincipal.Size = new System.Drawing.Size(344, 251);
            this.dgvPrincipal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Procurar por descrição";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtProcurar.Location = new System.Drawing.Point(442, 17);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(212, 25);
            this.txtProcurar.TabIndex = 44;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 697);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepartamento";
            this.Text = "frmDepartamento";
            this.Load += new System.EventHandler(this.frmDepartamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportacaoExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcurar;
    }
}