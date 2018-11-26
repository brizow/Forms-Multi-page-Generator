namespace Forms_Multipage_Generator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createPDFBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bottomTopPosNumB = new System.Windows.Forms.NumericUpDown();
            this.leftRightPosNumB = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textSpacingNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bottomTopPosNumA = new System.Windows.Forms.NumericUpDown();
            this.leftRightPosNumA = new System.Windows.Forms.NumericUpDown();
            this.saveSetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pageBlanksTextBox = new System.Windows.Forms.TextBox();
            this.numOPgsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityStZipTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSpacingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createPDFBtn
            // 
            this.createPDFBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createPDFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPDFBtn.Location = new System.Drawing.Point(150, 397);
            this.createPDFBtn.Name = "createPDFBtn";
            this.createPDFBtn.Size = new System.Drawing.Size(124, 30);
            this.createPDFBtn.TabIndex = 7;
            this.createPDFBtn.Text = "Create PDF";
            this.createPDFBtn.UseVisualStyleBackColor = false;
            this.createPDFBtn.Click += new System.EventHandler(this.createPDFBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.label21);
            this.settingsPanel.Controls.Add(this.label19);
            this.settingsPanel.Controls.Add(this.label18);
            this.settingsPanel.Controls.Add(this.label13);
            this.settingsPanel.Controls.Add(this.bottomTopPosNumB);
            this.settingsPanel.Controls.Add(this.leftRightPosNumB);
            this.settingsPanel.Controls.Add(this.label14);
            this.settingsPanel.Controls.Add(this.label15);
            this.settingsPanel.Controls.Add(this.label16);
            this.settingsPanel.Controls.Add(this.label17);
            this.settingsPanel.Controls.Add(this.label12);
            this.settingsPanel.Controls.Add(this.textSpacingNum);
            this.settingsPanel.Controls.Add(this.label11);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.bottomTopPosNumA);
            this.settingsPanel.Controls.Add(this.leftRightPosNumA);
            this.settingsPanel.Controls.Add(this.saveSetBtn);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Location = new System.Drawing.Point(472, 27);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(401, 269);
            this.settingsPanel.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(87, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 17);
            this.label21.TabIndex = 28;
            this.label21.Text = "Save Settings:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 16);
            this.label19.TabIndex = 27;
            this.label19.Text = "Odd Pages";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "Even Pages";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Default: 170, 100";
            // 
            // bottomTopPosNumB
            // 
            this.bottomTopPosNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomTopPosNumB.Location = new System.Drawing.Point(191, 154);
            this.bottomTopPosNumB.Maximum = new decimal(new int[] {
            612,
            0,
            0,
            0});
            this.bottomTopPosNumB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomTopPosNumB.Name = "bottomTopPosNumB";
            this.bottomTopPosNumB.Size = new System.Drawing.Size(56, 22);
            this.bottomTopPosNumB.TabIndex = 24;
            this.bottomTopPosNumB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // leftRightPosNumB
            // 
            this.leftRightPosNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftRightPosNumB.Location = new System.Drawing.Point(191, 127);
            this.leftRightPosNumB.Maximum = new decimal(new int[] {
            792,
            0,
            0,
            0});
            this.leftRightPosNumB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leftRightPosNumB.Name = "leftRightPosNumB";
            this.leftRightPosNumB.Size = new System.Drawing.Size(56, 22);
            this.leftRightPosNumB.TabIndex = 23;
            this.leftRightPosNumB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(249, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Pixels";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Label Top, Bottom Position B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(249, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Pixels";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "Label Left RIght Position B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Pixels";
            // 
            // textSpacingNum
            // 
            this.textSpacingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpacingNum.Location = new System.Drawing.Point(192, 197);
            this.textSpacingNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.textSpacingNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textSpacingNum.Name = "textSpacingNum";
            this.textSpacingNum.Size = new System.Drawing.Size(56, 22);
            this.textSpacingNum.TabIndex = 17;
            this.textSpacingNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Text Group Spacing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Default: 170, 100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Settings";
            // 
            // bottomTopPosNumA
            // 
            this.bottomTopPosNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomTopPosNumA.Location = new System.Drawing.Point(192, 73);
            this.bottomTopPosNumA.Maximum = new decimal(new int[] {
            612,
            0,
            0,
            0});
            this.bottomTopPosNumA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomTopPosNumA.Name = "bottomTopPosNumA";
            this.bottomTopPosNumA.Size = new System.Drawing.Size(56, 22);
            this.bottomTopPosNumA.TabIndex = 13;
            this.bottomTopPosNumA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // leftRightPosNumA
            // 
            this.leftRightPosNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftRightPosNumA.Location = new System.Drawing.Point(192, 46);
            this.leftRightPosNumA.Maximum = new decimal(new int[] {
            792,
            0,
            0,
            0});
            this.leftRightPosNumA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leftRightPosNumA.Name = "leftRightPosNumA";
            this.leftRightPosNumA.Size = new System.Drawing.Size(56, 22);
            this.leftRightPosNumA.TabIndex = 12;
            this.leftRightPosNumA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveSetBtn
            // 
            this.saveSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSetBtn.Location = new System.Drawing.Point(191, 231);
            this.saveSetBtn.Name = "saveSetBtn";
            this.saveSetBtn.Size = new System.Drawing.Size(75, 23);
            this.saveSetBtn.TabIndex = 11;
            this.saveSetBtn.Text = "Save";
            this.saveSetBtn.UseVisualStyleBackColor = true;
            this.saveSetBtn.Click += new System.EventHandler(this.saveSetBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pixels";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Label Top, Bottom Position A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pixels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Label Left RIght Position A";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.address2TextBox);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.custIDTextBox);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.pageBlanksTextBox);
            this.panel1.Controls.Add(this.numOPgsTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cityStZipTextBox);
            this.panel1.Controls.Add(this.createPDFBtn);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 432);
            this.panel1.TabIndex = 0;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(135, 156);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(269, 22);
            this.address2TextBox.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(63, 159);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 16);
            this.label26.TabIndex = 35;
            this.label26.Text = "Address2";
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDTextBox.Location = new System.Drawing.Point(135, 46);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.Size = new System.Drawing.Size(269, 22);
            this.custIDTextBox.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(48, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 16);
            this.label23.TabIndex = 33;
            this.label23.Text = "Customer ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(147, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Address Label";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 268);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(124, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "Blank Page Numbers";
            // 
            // pageBlanksTextBox
            // 
            this.pageBlanksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageBlanksTextBox.Location = new System.Drawing.Point(135, 265);
            this.pageBlanksTextBox.MaxLength = 1000;
            this.pageBlanksTextBox.Multiline = true;
            this.pageBlanksTextBox.Name = "pageBlanksTextBox";
            this.pageBlanksTextBox.Size = new System.Drawing.Size(269, 96);
            this.pageBlanksTextBox.TabIndex = 6;
            this.pageBlanksTextBox.Text = "Comma seperated values only.";
            this.pageBlanksTextBox.Enter += new System.EventHandler(this.pageBlanksTextBox_Enter);
            this.pageBlanksTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageBlanksTextBox_KeyPress);
            // 
            // numOPgsTextBox
            // 
            this.numOPgsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOPgsTextBox.Location = new System.Drawing.Point(135, 229);
            this.numOPgsTextBox.MaxLength = 4;
            this.numOPgsTextBox.Name = "numOPgsTextBox";
            this.numOPgsTextBox.Size = new System.Drawing.Size(58, 22);
            this.numOPgsTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of pages*";
            // 
            // cityStZipTextBox
            // 
            this.cityStZipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityStZipTextBox.Location = new System.Drawing.Point(135, 194);
            this.cityStZipTextBox.Name = "cityStZipTextBox";
            this.cityStZipTextBox.Size = new System.Drawing.Size(269, 22);
            this.cityStZipTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(135, 122);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(269, 22);
            this.addressTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(135, 84);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(269, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "City, State, Zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title*";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(758, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 85);
            this.panel2.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(81, 72);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "v: 1.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multi-page Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSpacingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPDFBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveSetBtn;
        private System.Windows.Forms.NumericUpDown leftRightPosNumA;
        private System.Windows.Forms.NumericUpDown bottomTopPosNumA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown textSpacingNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox numOPgsTextBox;
        private System.Windows.Forms.TextBox cityStZipTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown bottomTopPosNumB;
        private System.Windows.Forms.NumericUpDown leftRightPosNumB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox pageBlanksTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label label26;
    }
}

