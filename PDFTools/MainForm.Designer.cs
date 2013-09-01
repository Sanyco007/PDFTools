namespace PDFTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSavePDF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.упавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrevPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNextPage = new System.Windows.Forms.ToolStripMenuItem();
            this.изображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmOpenTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.lbImageList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudGroup = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddImage = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpenTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveTemplate = new System.Windows.Forms.ToolStripButton();
            this.openPdfDialog = new System.Windows.Forms.OpenFileDialog();
            this.pdfPanel = new System.Windows.Forms.Panel();
            this.pbPDF = new System.Windows.Forms.PictureBox();
            this.pToolStrip = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbOpenPDF = new System.Windows.Forms.ToolStripButton();
            this.tsbSavePDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrevPage = new System.Windows.Forms.ToolStripButton();
            this.tsbNextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbZoom = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.savePdfDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.itemsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.pdfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).BeginInit();
            this.pToolStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.упавлениеToolStripMenuItem,
            this.изображенияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(703, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenPdf,
            this.toolStripMenuItem1,
            this.tsmiSavePDF,
            this.toolStripMenuItem2,
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiOpenPdf
            // 
            this.tsmiOpenPdf.Image = global::PDFTools.Properties.Resources.open;
            this.tsmiOpenPdf.Name = "tsmiOpenPdf";
            this.tsmiOpenPdf.Size = new System.Drawing.Size(156, 22);
            this.tsmiOpenPdf.Text = "Открыть PDF";
            this.tsmiOpenPdf.Click += new System.EventHandler(this.tsmiOpenPdf_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // tsmiSavePDF
            // 
            this.tsmiSavePDF.Image = global::PDFTools.Properties.Resources.save;
            this.tsmiSavePDF.Name = "tsmiSavePDF";
            this.tsmiSavePDF.Size = new System.Drawing.Size(156, 22);
            this.tsmiSavePDF.Text = "Сохранить PDF";
            this.tsmiSavePDF.Click += new System.EventHandler(this.TsbSavePdfClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::PDFTools.Properties.Resources.exit;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(156, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // упавлениеToolStripMenuItem
            // 
            this.упавлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPrevPage,
            this.tsmNextPage});
            this.упавлениеToolStripMenuItem.Name = "упавлениеToolStripMenuItem";
            this.упавлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.упавлениеToolStripMenuItem.Text = "Управление";
            // 
            // tsmPrevPage
            // 
            this.tsmPrevPage.Name = "tsmPrevPage";
            this.tsmPrevPage.Size = new System.Drawing.Size(200, 22);
            this.tsmPrevPage.Text = "Предыдущая страница";
            this.tsmPrevPage.Click += new System.EventHandler(this.tsbPrevPage_Click);
            // 
            // tsmNextPage
            // 
            this.tsmNextPage.Name = "tsmNextPage";
            this.tsmNextPage.Size = new System.Drawing.Size(200, 22);
            this.tsmNextPage.Text = "Следующая страница";
            this.tsmNextPage.Click += new System.EventHandler(this.tsbNextPage_Click);
            // 
            // изображенияToolStripMenuItem
            // 
            this.изображенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddImage,
            this.tsmRemoveImage,
            this.toolStripMenuItem3,
            this.tsmOpenTemplate,
            this.tsmSaveTemplate});
            this.изображенияToolStripMenuItem.Name = "изображенияToolStripMenuItem";
            this.изображенияToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.изображенияToolStripMenuItem.Text = "Изображения";
            // 
            // tsmAddImage
            // 
            this.tsmAddImage.Name = "tsmAddImage";
            this.tsmAddImage.Size = new System.Drawing.Size(180, 22);
            this.tsmAddImage.Text = "Добавить";
            this.tsmAddImage.Click += new System.EventHandler(this.tsbAddImage_Click);
            // 
            // tsmRemoveImage
            // 
            this.tsmRemoveImage.Name = "tsmRemoveImage";
            this.tsmRemoveImage.Size = new System.Drawing.Size(180, 22);
            this.tsmRemoveImage.Text = "Удалить";
            this.tsmRemoveImage.Click += new System.EventHandler(this.tsbDeleteImage_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmOpenTemplate
            // 
            this.tsmOpenTemplate.Name = "tsmOpenTemplate";
            this.tsmOpenTemplate.Size = new System.Drawing.Size(180, 22);
            this.tsmOpenTemplate.Text = "Открыть шаблон";
            this.tsmOpenTemplate.Click += new System.EventHandler(this.tsbOpenTemplate_Click);
            // 
            // tsmSaveTemplate
            // 
            this.tsmSaveTemplate.Name = "tsmSaveTemplate";
            this.tsmSaveTemplate.Size = new System.Drawing.Size(180, 22);
            this.tsmSaveTemplate.Text = "Сохранить шаблон";
            this.tsmSaveTemplate.Click += new System.EventHandler(this.tsbSaveTemplate_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.BackColor = System.Drawing.Color.White;
            this.itemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsPanel.Controls.Add(this.lbImageList);
            this.itemsPanel.Controls.Add(this.groupBox1);
            this.itemsPanel.Controls.Add(this.toolStrip1);
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemsPanel.Location = new System.Drawing.Point(0, 52);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(213, 386);
            this.itemsPanel.TabIndex = 1;
            // 
            // lbImageList
            // 
            this.lbImageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbImageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbImageList.FormattingEnabled = true;
            this.lbImageList.ItemHeight = 16;
            this.lbImageList.Location = new System.Drawing.Point(0, 25);
            this.lbImageList.Name = "lbImageList";
            this.lbImageList.Size = new System.Drawing.Size(211, 213);
            this.lbImageList.TabIndex = 1;
            this.lbImageList.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // nudGroup
            // 
            this.nudGroup.Location = new System.Drawing.Point(57, 23);
            this.nudGroup.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudGroup.Name = "nudGroup";
            this.nudGroup.Size = new System.Drawing.Size(148, 20);
            this.nudGroup.TabIndex = 12;
            this.nudGroup.ValueChanged += new System.EventHandler(this.nudGroup_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Группа:";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(131, 116);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(74, 20);
            this.nudHeight.TabIndex = 10;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "В:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(29, 116);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(74, 20);
            this.nudWidth.TabIndex = 8;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ш:";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(131, 73);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(74, 20);
            this.nudY.TabIndex = 6;
            this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(29, 73);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(74, 20);
            this.nudX.TabIndex = 4;
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddImage,
            this.tsbDeleteImage,
            this.toolStripSeparator3,
            this.tsbOpenTemplate,
            this.tsbSaveTemplate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(211, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbAddImage
            // 
            this.tsbAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddImage.Image")));
            this.tsbAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddImage.Name = "tsbAddImage";
            this.tsbAddImage.Size = new System.Drawing.Size(23, 22);
            this.tsbAddImage.Text = "Добавить изображение";
            this.tsbAddImage.Click += new System.EventHandler(this.tsbAddImage_Click);
            // 
            // tsbDeleteImage
            // 
            this.tsbDeleteImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteImage.Image")));
            this.tsbDeleteImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteImage.Name = "tsbDeleteImage";
            this.tsbDeleteImage.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteImage.Text = "Удалить изображение";
            this.tsbDeleteImage.Click += new System.EventHandler(this.tsbDeleteImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOpenTemplate
            // 
            this.tsbOpenTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenTemplate.Image")));
            this.tsbOpenTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenTemplate.Name = "tsbOpenTemplate";
            this.tsbOpenTemplate.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenTemplate.Text = "Открыть шаблон";
            this.tsbOpenTemplate.Click += new System.EventHandler(this.tsbOpenTemplate_Click);
            // 
            // tsbSaveTemplate
            // 
            this.tsbSaveTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveTemplate.Image")));
            this.tsbSaveTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveTemplate.Name = "tsbSaveTemplate";
            this.tsbSaveTemplate.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveTemplate.Text = "Сохранить шаблон";
            this.tsbSaveTemplate.Click += new System.EventHandler(this.tsbSaveTemplate_Click);
            // 
            // openPdfDialog
            // 
            this.openPdfDialog.DefaultExt = "pdf";
            this.openPdfDialog.Filter = "Файл PDF (*.pdf)|*.pdf";
            // 
            // pdfPanel
            // 
            this.pdfPanel.AutoScroll = true;
            this.pdfPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pdfPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfPanel.Controls.Add(this.pbPDF);
            this.pdfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfPanel.Location = new System.Drawing.Point(213, 52);
            this.pdfPanel.Name = "pdfPanel";
            this.pdfPanel.Size = new System.Drawing.Size(490, 386);
            this.pdfPanel.TabIndex = 3;
            // 
            // pbPDF
            // 
            this.pbPDF.Location = new System.Drawing.Point(0, 0);
            this.pbPDF.Name = "pbPDF";
            this.pbPDF.Size = new System.Drawing.Size(63, 61);
            this.pbPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPDF.TabIndex = 0;
            this.pbPDF.TabStop = false;
            this.pbPDF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbPdfMouseDown);
            this.pbPDF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbPdfMouseMove);
            this.pbPDF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbPdfMouseUp);
            // 
            // pToolStrip
            // 
            this.pToolStrip.Controls.Add(this.toolStrip);
            this.pToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolStrip.Location = new System.Drawing.Point(0, 24);
            this.pToolStrip.Name = "pToolStrip";
            this.pToolStrip.Size = new System.Drawing.Size(703, 28);
            this.pToolStrip.TabIndex = 4;
            // 
            // toolStrip
            // 
            this.toolStrip.CanOverflow = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenPDF,
            this.tsbSavePDF,
            this.toolStripSeparator1,
            this.tsbPrevPage,
            this.tsbNextPage,
            this.toolStripSeparator2,
            this.tscbZoom,
            this.toolStripSeparator4,
            this.tslInfo,
            this.toolStripSeparator5,
            this.tsbExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(703, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // tsbOpenPDF
            // 
            this.tsbOpenPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenPDF.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenPDF.Image")));
            this.tsbOpenPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenPDF.Name = "tsbOpenPDF";
            this.tsbOpenPDF.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenPDF.Text = " Открыть PDF";
            this.tsbOpenPDF.Click += new System.EventHandler(this.tsmiOpenPdf_Click);
            // 
            // tsbSavePDF
            // 
            this.tsbSavePDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSavePDF.Image = ((System.Drawing.Image)(resources.GetObject("tsbSavePDF.Image")));
            this.tsbSavePDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSavePDF.Name = "tsbSavePDF";
            this.tsbSavePDF.Size = new System.Drawing.Size(23, 22);
            this.tsbSavePDF.Text = "Сохранить PDF";
            this.tsbSavePDF.Click += new System.EventHandler(this.TsbSavePdfClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrevPage
            // 
            this.tsbPrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevPage.Image")));
            this.tsbPrevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevPage.Name = "tsbPrevPage";
            this.tsbPrevPage.Size = new System.Drawing.Size(23, 22);
            this.tsbPrevPage.Text = "Предыдущая страница";
            this.tsbPrevPage.Click += new System.EventHandler(this.tsbPrevPage_Click);
            // 
            // tsbNextPage
            // 
            this.tsbNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextPage.Image = ((System.Drawing.Image)(resources.GetObject("tsbNextPage.Image")));
            this.tsbNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextPage.Name = "tsbNextPage";
            this.tsbNextPage.Size = new System.Drawing.Size(23, 22);
            this.tsbNextPage.Text = "Следующая страница";
            this.tsbNextPage.Click += new System.EventHandler(this.tsbNextPage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInfo
            // 
            this.tslInfo.BackColor = System.Drawing.Color.Transparent;
            this.tslInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(93, 22);
            this.tslInfo.Text = "Перемещение";
            this.tslInfo.Click += new System.EventHandler(this.tslInfo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tscbZoom
            // 
            this.tscbZoom.Items.AddRange(new object[] {
            "50%",
            "100%",
            "150%",
            "200%",
            "300%",
            "400%",
            "500%"});
            this.tscbZoom.Name = "tscbZoom";
            this.tscbZoom.Size = new System.Drawing.Size(121, 25);
            this.tscbZoom.SelectedIndexChanged += new System.EventHandler(this.tscbZoom_SelectedIndexChanged);
            this.tscbZoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbZoom_KeyPress);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "Выход";
            this.tsbExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 438);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(703, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // savePdfDialog
            // 
            this.savePdfDialog.DefaultExt = "pdf";
            this.savePdfDialog.FileName = "Без названия.pdf";
            this.savePdfDialog.Filter = "Файл PDF (*.pdf)|*.pdf";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 460);
            this.Controls.Add(this.pdfPanel);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pToolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFTools";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.itemsPanel.ResumeLayout(false);
            this.itemsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pdfPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).EndInit();
            this.pToolStrip.ResumeLayout(false);
            this.pToolStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenPdf;
        private System.Windows.Forms.OpenFileDialog openPdfDialog;
        private System.Windows.Forms.Panel pdfPanel;
        private System.Windows.Forms.PictureBox pbPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSavePDF;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Panel pToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbOpenPDF;
        private System.Windows.Forms.ToolStripButton tsbSavePDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPrevPage;
        private System.Windows.Forms.ToolStripButton tsbNextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox lbImageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton tsbAddImage;
        private System.Windows.Forms.ToolStripButton tsbDeleteImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOpenTemplate;
        private System.Windows.Forms.ToolStripButton tsbSaveTemplate;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog savePdfDialog;
        private System.Windows.Forms.ToolStripLabel tslInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem упавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPrevPage;
        private System.Windows.Forms.ToolStripMenuItem tsmNextPage;
        private System.Windows.Forms.ToolStripMenuItem изображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddImage;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveTemplate;
        private System.Windows.Forms.ToolStripComboBox tscbZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

