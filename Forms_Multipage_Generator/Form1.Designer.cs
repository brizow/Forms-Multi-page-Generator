﻿namespace Forms_Multipage_Generator
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textSpacingNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bottomTopPosNumA = new System.Windows.Forms.NumericUpDown();
            this.leftRightPosNumA = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numOPgsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityStZipTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bottomTopPosNumB = new System.Windows.Forms.NumericUpDown();
            this.leftRightPosNumB = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSpacingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label13);
            this.settingsPanel.Controls.Add(this.panel1);
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
            this.settingsPanel.Controls.Add(this.saveBtn);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Location = new System.Drawing.Point(11, 27);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(344, 233);
            this.settingsPanel.TabIndex = 0;
            this.settingsPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Pixels";
            // 
            // textSpacingNum
            // 
            this.textSpacingNum.Location = new System.Drawing.Point(152, 173);
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
            this.textSpacingNum.Size = new System.Drawing.Size(56, 20);
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
            this.label11.Location = new System.Drawing.Point(44, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Text Group Spacing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Default: 170, 650";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Settings";
            // 
            // bottomTopPosNumA
            // 
            this.bottomTopPosNumA.Location = new System.Drawing.Point(152, 60);
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
            this.bottomTopPosNumA.Size = new System.Drawing.Size(56, 20);
            this.bottomTopPosNumA.TabIndex = 13;
            this.bottomTopPosNumA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // leftRightPosNumA
            // 
            this.leftRightPosNumA.Location = new System.Drawing.Point(152, 33);
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
            this.leftRightPosNumA.Size = new System.Drawing.Size(56, 20);
            this.leftRightPosNumA.TabIndex = 12;
            this.leftRightPosNumA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(8, 207);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pixels";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Label Top, Bottom Position A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pixels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Label Left RIght Position A";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numOPgsTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cityStZipTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 175);
            this.panel1.TabIndex = 0;
            // 
            // numOPgsTextBox
            // 
            this.numOPgsTextBox.Location = new System.Drawing.Point(104, 108);
            this.numOPgsTextBox.MaxLength = 4;
            this.numOPgsTextBox.Name = "numOPgsTextBox";
            this.numOPgsTextBox.Size = new System.Drawing.Size(58, 20);
            this.numOPgsTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of pages:";
            // 
            // cityStZipTextBox
            // 
            this.cityStZipTextBox.Location = new System.Drawing.Point(104, 80);
            this.cityStZipTextBox.Name = "cityStZipTextBox";
            this.cityStZipTextBox.Size = new System.Drawing.Size(179, 20);
            this.cityStZipTextBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(104, 47);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(179, 20);
            this.addressTextBox.TabIndex = 13;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(104, 13);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(179, 20);
            this.titleTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "City, State, Zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Default: 170, 650";
            // 
            // bottomTopPosNumB
            // 
            this.bottomTopPosNumB.Location = new System.Drawing.Point(151, 129);
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
            this.bottomTopPosNumB.Size = new System.Drawing.Size(56, 20);
            this.bottomTopPosNumB.TabIndex = 24;
            this.bottomTopPosNumB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // leftRightPosNumB
            // 
            this.leftRightPosNumB.Location = new System.Drawing.Point(151, 102);
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
            this.leftRightPosNumB.Size = new System.Drawing.Size(56, 20);
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
            this.label14.Location = new System.Drawing.Point(209, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Pixels";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Label Top, Bottom Position B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(209, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Pixels";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Label Left RIght Position B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 271);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multi-page Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSpacingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomTopPosNumB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightPosNumB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown leftRightPosNumA;
        private System.Windows.Forms.NumericUpDown bottomTopPosNumA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown textSpacingNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox numOPgsTextBox;
        private System.Windows.Forms.Label label4;
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
    }
}

