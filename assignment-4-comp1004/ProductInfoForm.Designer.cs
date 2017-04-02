namespace assignment_4_comp1004
{
    partial class ProductInfoForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ToolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnotherProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProceedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.AnotherProductButton = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolbarMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(491, 347);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 30);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(41, 39);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(85, 20);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.BackColor = System.Drawing.Color.White;
            this.ProductIDTextBox.Location = new System.Drawing.Point(128, 36);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.ProductIDTextBox.TabIndex = 1;
            // 
            // ToolbarMenuStrip
            // 
            this.ToolbarMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolbarMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem});
            this.ToolbarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolbarMenuStrip.Name = "ToolbarMenuStrip";
            this.ToolbarMenuStrip.Size = new System.Drawing.Size(672, 29);
            this.ToolbarMenuStrip.TabIndex = 4;
            this.ToolbarMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 25);
            this.FileMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(118, 26);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(118, 26);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(118, 26);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnotherProductMenuItem,
            this.CancelMenuItem,
            this.ProceedMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(48, 25);
            this.EditMenuItem.Text = "Edit";
            // 
            // AnotherProductMenuItem
            // 
            this.AnotherProductMenuItem.Name = "AnotherProductMenuItem";
            this.AnotherProductMenuItem.Size = new System.Drawing.Size(240, 26);
            this.AnotherProductMenuItem.Text = "Select Another Product";
            this.AnotherProductMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // CancelMenuItem
            // 
            this.CancelMenuItem.Name = "CancelMenuItem";
            this.CancelMenuItem.Size = new System.Drawing.Size(240, 26);
            this.CancelMenuItem.Text = "Cancel Purchase";
            this.CancelMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ProceedMenuItem
            // 
            this.ProceedMenuItem.Name = "ProceedMenuItem";
            this.ProceedMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ProceedMenuItem.Text = "Proceed With Purchase";
            this.ProceedMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(585, 347);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 30);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // AnotherProductButton
            // 
            this.AnotherProductButton.AutoSize = true;
            this.AnotherProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherProductButton.Location = new System.Drawing.Point(286, 347);
            this.AnotherProductButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnotherProductButton.Name = "AnotherProductButton";
            this.AnotherProductButton.Size = new System.Drawing.Size(184, 30);
            this.AnotherProductButton.TabIndex = 17;
            this.AnotherProductButton.Text = "Select Another Product";
            this.AnotherProductButton.UseVisualStyleBackColor = true;
            this.AnotherProductButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(273, 39);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 7;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(506, 39);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 8;
            this.CostLabel.Text = "Cost";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.Color.White;
            this.ConditionTextBox.Location = new System.Drawing.Point(355, 36);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 26);
            this.ConditionTextBox.TabIndex = 2;
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.Location = new System.Drawing.Point(554, 36);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 26);
            this.CostTextBox.TabIndex = 3;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 68);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(648, 113);
            this.ProductInfoGroupBox.TabIndex = 11;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.White;
            this.ModelTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModelTextBox.Location = new System.Drawing.Point(343, 63);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(299, 26);
            this.ModelTextBox.TabIndex = 7;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModelLabel.Location = new System.Drawing.Point(285, 66);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 10;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.Color.White;
            this.PlatformTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlatformTextBox.Location = new System.Drawing.Point(116, 31);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 26);
            this.PlatformTextBox.TabIndex = 4;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 66);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 8;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(116, 63);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 26);
            this.ManufacturerTextBox.TabIndex = 6;
            // 
            // OSTextBox
            // 
            this.OSTextBox.BackColor = System.Drawing.Color.White;
            this.OSTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OSTextBox.Location = new System.Drawing.Point(343, 31);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(299, 26);
            this.OSTextBox.TabIndex = 5;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OSLabel.Location = new System.Drawing.Point(305, 34);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 20);
            this.OSLabel.TabIndex = 5;
            this.OSLabel.Text = "OS";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlatformLabel.Location = new System.Drawing.Point(42, 34);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebcamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebcamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 187);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(648, 144);
            this.TechSpecsGroupBox.TabIndex = 12;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.BackColor = System.Drawing.Color.White;
            this.WebcamTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WebcamTextBox.Location = new System.Drawing.Point(542, 94);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.ReadOnly = true;
            this.WebcamTextBox.Size = new System.Drawing.Size(100, 26);
            this.WebcamTextBox.TabIndex = 16;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.BackColor = System.Drawing.Color.White;
            this.GPUTypeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(542, 62);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.GPUTypeTextBox.TabIndex = 13;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.BackColor = System.Drawing.Color.White;
            this.CPUSpeedTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(343, 94);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUSpeedTextBox.TabIndex = 15;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.BackColor = System.Drawing.Color.White;
            this.CPUNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(343, 62);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.ReadOnly = true;
            this.CPUNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUNumberTextBox.TabIndex = 12;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WebcamLabel.Location = new System.Drawing.Point(464, 97);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(72, 20);
            this.WebcamLabel.TabIndex = 18;
            this.WebcamLabel.Text = "Webcam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GPUTypeLabel.Location = new System.Drawing.Point(454, 65);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.GPUTypeLabel.TabIndex = 17;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(244, 97);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.CPUSpeedLabel.TabIndex = 16;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUNumberLabel.Location = new System.Drawing.Point(235, 65);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.CPUNumberLabel.TabIndex = 15;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUTypeLabel.Location = new System.Drawing.Point(30, 97);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.CPUTypeLabel.TabIndex = 14;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.BackColor = System.Drawing.Color.White;
            this.CPUTypeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(116, 94);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUTypeTextBox.TabIndex = 14;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.BackColor = System.Drawing.Color.White;
            this.CPUBrandTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(116, 62);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUBrandTextBox.TabIndex = 11;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUBrandLabel.Location = new System.Drawing.Point(21, 65);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.CPUBrandLabel.TabIndex = 11;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.BackColor = System.Drawing.Color.White;
            this.HDDTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HDDTextBox.Location = new System.Drawing.Point(542, 30);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(100, 26);
            this.HDDTextBox.TabIndex = 10;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HDDLabel.Location = new System.Drawing.Point(491, 33);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 20);
            this.HDDLabel.TabIndex = 9;
            this.HDDLabel.Text = "HDD";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.BackColor = System.Drawing.Color.White;
            this.LCDSizeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(343, 30);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(100, 26);
            this.LCDSizeTextBox.TabIndex = 9;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCDSizeLabel.Location = new System.Drawing.Point(261, 33);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.LCDSizeLabel.TabIndex = 7;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MemoryLabel.Location = new System.Drawing.Point(45, 33);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Memory";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BackColor = System.Drawing.Color.White;
            this.MemoryTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MemoryTextBox.Location = new System.Drawing.Point(116, 30);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(100, 26);
            this.MemoryTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(8, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Click Next to Confirm Your Selection";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.AnotherProductButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ToolbarMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ToolbarMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.ToolbarMenuStrip.ResumeLayout(false);
            this.ToolbarMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.MenuStrip ToolbarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button AnotherProductButton;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox WebcamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnotherProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProceedMenuItem;
        private System.Windows.Forms.Label label1;
    }
}