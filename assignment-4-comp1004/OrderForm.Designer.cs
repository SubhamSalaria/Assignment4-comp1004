namespace assignment_4_comp1004
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.ToolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.PricingGroupBox = new System.Windows.Forms.GroupBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.ToolbarMenuStrip.SuspendLayout();
            this.ComponentsGroupBox.SuspendLayout();
            this.PricingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolbarMenuStrip
            // 
            this.ToolbarMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolbarMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem});
            this.ToolbarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolbarMenuStrip.Name = "ToolbarMenuStrip";
            this.ToolbarMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.ToolbarMenuStrip.Size = new System.Drawing.Size(730, 31);
            this.ToolbarMenuStrip.TabIndex = 0;
            this.ToolbarMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 25);
            this.FileMenuItem.Text = "File";
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.Size = new System.Drawing.Size(113, 26);
            this.PrintMenuItem.Text = "Print";
            this.PrintMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(113, 26);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(48, 25);
            this.EditMenuItem.Text = "Edit";
            // 
            // BackMenuItem
            // 
            this.BackMenuItem.Name = "BackMenuItem";
            this.BackMenuItem.Size = new System.Drawing.Size(112, 26);
            this.BackMenuItem.Text = "Back";
            this.BackMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(54, 25);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(122, 26);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ComponentsGroupBox
            // 
            this.ComponentsGroupBox.Controls.Add(this.OSTextBox);
            this.ComponentsGroupBox.Controls.Add(this.WebcamTextBox);
            this.ComponentsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.ComponentsGroupBox.Controls.Add(this.HDDTextBox);
            this.ComponentsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.ComponentsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.ComponentsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.ComponentsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.ComponentsGroupBox.Controls.Add(this.MemoryTextBox);
            this.ComponentsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.ComponentsGroupBox.Controls.Add(this.OSLabel);
            this.ComponentsGroupBox.Controls.Add(this.WebcamLabel);
            this.ComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.ComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.ComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.ComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.ComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.ComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.ComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.ComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.ComponentsGroupBox.Controls.Add(this.ModelTextBox);
            this.ComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.ComponentsGroupBox.Controls.Add(this.PlatformTextBox);
            this.ComponentsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.ComponentsGroupBox.Controls.Add(this.ConditionTextBox);
            this.ComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.ComponentsGroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ComponentsGroupBox.Location = new System.Drawing.Point(13, 36);
            this.ComponentsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComponentsGroupBox.Name = "ComponentsGroupBox";
            this.ComponentsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComponentsGroupBox.Size = new System.Drawing.Size(407, 376);
            this.ComponentsGroupBox.TabIndex = 1;
            this.ComponentsGroupBox.TabStop = false;
            this.ComponentsGroupBox.Text = "System Components";
            // 
            // PricingGroupBox
            // 
            this.PricingGroupBox.Controls.Add(this.TotalLabel);
            this.PricingGroupBox.Controls.Add(this.TotalTextBox);
            this.PricingGroupBox.Controls.Add(this.TaxTextBox);
            this.PricingGroupBox.Controls.Add(this.PriceTextBox);
            this.PricingGroupBox.Controls.Add(this.TaxLabel);
            this.PricingGroupBox.Controls.Add(this.PriceLabel);
            this.PricingGroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PricingGroupBox.Location = new System.Drawing.Point(428, 239);
            this.PricingGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PricingGroupBox.Name = "PricingGroupBox";
            this.PricingGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PricingGroupBox.Size = new System.Drawing.Size(289, 130);
            this.PricingGroupBox.TabIndex = 2;
            this.PricingGroupBox.TabStop = false;
            this.PricingGroupBox.Text = "Pricing";
            // 
            // FinishButton
            // 
            this.FinishButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FinishButton.BackColor = System.Drawing.Color.SkyBlue;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(642, 382);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 30);
            this.FinishButton.TabIndex = 0;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(559, 382);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 30);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(476, 382);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConditionLabel.Location = new System.Drawing.Point(28, 24);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(64, 16);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConditionTextBox.Location = new System.Drawing.Point(98, 21);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 22);
            this.ConditionTextBox.TabIndex = 3;
            this.ConditionTextBox.TabStop = false;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlatformLabel.Location = new System.Drawing.Point(237, 24);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(57, 16);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManufacturerLabel.Location = new System.Drawing.Point(7, 56);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(85, 16);
            this.ManufacturerLabel.TabIndex = 5;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(98, 53);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.ManufacturerTextBox.TabIndex = 6;
            this.ManufacturerTextBox.TabStop = false;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlatformTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlatformTextBox.Location = new System.Drawing.Point(300, 21);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 22);
            this.PlatformTextBox.TabIndex = 7;
            this.PlatformTextBox.TabStop = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModelLabel.Location = new System.Drawing.Point(248, 56);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(46, 16);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModelTextBox.Location = new System.Drawing.Point(300, 53);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(100, 22);
            this.ModelTextBox.TabIndex = 9;
            this.ModelTextBox.TabStop = false;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCDSizeLabel.Location = new System.Drawing.Point(29, 94);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(63, 16);
            this.LCDSizeLabel.TabIndex = 10;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUNumberLabel.Location = new System.Drawing.Point(5, 206);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(87, 16);
            this.CPUNumberLabel.TabIndex = 11;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MemoryLabel.Location = new System.Drawing.Point(35, 122);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(57, 16);
            this.MemoryLabel.TabIndex = 12;
            this.MemoryLabel.Text = "Memory";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUBrandLabel.Location = new System.Drawing.Point(17, 150);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(75, 16);
            this.CPUBrandLabel.TabIndex = 13;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUTypeLabel.Location = new System.Drawing.Point(21, 178);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(71, 16);
            this.CPUTypeLabel.TabIndex = 14;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(12, 234);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(80, 16);
            this.CPUSpeedLabel.TabIndex = 15;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HDDLabel.Location = new System.Drawing.Point(54, 262);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(38, 16);
            this.HDDLabel.TabIndex = 16;
            this.HDDLabel.Text = "HDD";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GPUTypeLabel.Location = new System.Drawing.Point(20, 290);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(72, 16);
            this.GPUTypeLabel.TabIndex = 17;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WebcamLabel.Location = new System.Drawing.Point(29, 317);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(63, 16);
            this.WebcamLabel.TabIndex = 18;
            this.WebcamLabel.Text = "Webcam";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OSLabel.Location = new System.Drawing.Point(65, 346);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(27, 16);
            this.OSLabel.TabIndex = 19;
            this.OSLabel.Text = "OS";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LCDSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(98, 91);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(302, 22);
            this.LCDSizeTextBox.TabIndex = 20;
            this.LCDSizeTextBox.TabStop = false;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MemoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MemoryTextBox.Location = new System.Drawing.Point(98, 119);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(302, 22);
            this.MemoryTextBox.TabIndex = 21;
            this.MemoryTextBox.TabStop = false;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CPUBrandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(98, 147);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(302, 22);
            this.CPUBrandTextBox.TabIndex = 22;
            this.CPUBrandTextBox.TabStop = false;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(98, 175);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(302, 22);
            this.CPUTypeTextBox.TabIndex = 23;
            this.CPUTypeTextBox.TabStop = false;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CPUNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(98, 203);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.ReadOnly = true;
            this.CPUNumberTextBox.Size = new System.Drawing.Size(302, 22);
            this.CPUNumberTextBox.TabIndex = 24;
            this.CPUNumberTextBox.TabStop = false;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CPUSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(98, 231);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(302, 22);
            this.CPUSpeedTextBox.TabIndex = 25;
            this.CPUSpeedTextBox.TabStop = false;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HDDTextBox.Location = new System.Drawing.Point(98, 259);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(302, 22);
            this.HDDTextBox.TabIndex = 26;
            this.HDDTextBox.TabStop = false;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(98, 287);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(302, 22);
            this.GPUTypeTextBox.TabIndex = 27;
            this.GPUTypeTextBox.TabStop = false;
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WebcamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WebcamTextBox.Location = new System.Drawing.Point(98, 314);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.ReadOnly = true;
            this.WebcamTextBox.Size = new System.Drawing.Size(302, 22);
            this.WebcamTextBox.TabIndex = 28;
            this.WebcamTextBox.TabStop = false;
            // 
            // OSTextBox
            // 
            this.OSTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OSTextBox.Location = new System.Drawing.Point(98, 343);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(302, 22);
            this.OSTextBox.TabIndex = 29;
            this.OSTextBox.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PriceLabel.Location = new System.Drawing.Point(7, 24);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TaxLabel.Location = new System.Drawing.Point(7, 56);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(139, 20);
            this.TaxLabel.TabIndex = 7;
            this.TaxLabel.Text = "Sales Tax (13%)";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.White;
            this.PriceTextBox.Location = new System.Drawing.Point(182, 21);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.PriceTextBox.TabIndex = 1;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.BackColor = System.Drawing.Color.White;
            this.TaxTextBox.Location = new System.Drawing.Point(182, 53);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 26);
            this.TaxTextBox.TabIndex = 2;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.White;
            this.TotalTextBox.Location = new System.Drawing.Point(182, 96);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.TotalTextBox.TabIndex = 3;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalLabel.Location = new System.Drawing.Point(7, 99);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(49, 20);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total";
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.BackgroundImage = global::assignment_4_comp1004.Properties.Resources.outline_computer2;
            this.ComputerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerPictureBox.Location = new System.Drawing.Point(428, 46);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(289, 187);
            this.ComputerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerPictureBox.TabIndex = 12;
            this.ComputerPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 426);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.PricingGroupBox);
            this.Controls.Add(this.ComponentsGroupBox);
            this.Controls.Add(this.ToolbarMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.MainMenuStrip = this.ToolbarMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ToolbarMenuStrip.ResumeLayout(false);
            this.ToolbarMenuStrip.PerformLayout();
            this.ComponentsGroupBox.ResumeLayout(false);
            this.ComponentsGroupBox.PerformLayout();
            this.PricingGroupBox.ResumeLayout(false);
            this.PricingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolbarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.GroupBox ComponentsGroupBox;
        private System.Windows.Forms.GroupBox PricingGroupBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox WebcamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
    }
}