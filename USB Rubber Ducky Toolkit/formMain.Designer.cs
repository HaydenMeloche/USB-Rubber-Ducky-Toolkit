using System;

namespace USB_Rubber_Ducky_Toolkit
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelay = new System.Windows.Forms.Button();
            this.SetDelayTextBox = new System.Windows.Forms.TextBox();
            this.btnEncodeForm = new System.Windows.Forms.Button();
            this.btnExecuteButton = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSystemRestorePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUAC = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(9, 31);
            this.btnPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(118, 21);
            this.btnPath.TabIndex = 12;
            this.btnPath.Text = "Load DuckyScript";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(10, 54);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(88, 13);
            this.PathLabel.TabIndex = 18;
            this.PathLabel.Text = "No path selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "This emulator tends to run DuckyScript faster than a Ducky would. \r\nYou can set a" +
    "n additional delay between each function here (in milliseconds)";
            // 
            // btnDelay
            // 
            this.btnDelay.Enabled = false;
            this.btnDelay.Location = new System.Drawing.Point(9, 79);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(79, 20);
            this.btnDelay.TabIndex = 16;
            this.btnDelay.Text = "Set Delay";
            this.btnDelay.UseVisualStyleBackColor = true;
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // SetDelayTextBox
            // 
            this.SetDelayTextBox.Enabled = false;
            this.SetDelayTextBox.Location = new System.Drawing.Point(93, 82);
            this.SetDelayTextBox.Name = "SetDelayTextBox";
            this.SetDelayTextBox.Size = new System.Drawing.Size(82, 20);
            this.SetDelayTextBox.TabIndex = 15;
            // 
            // btnEncodeForm
            // 
            this.btnEncodeForm.Enabled = false;
            this.btnEncodeForm.Location = new System.Drawing.Point(239, 31);
            this.btnEncodeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncodeForm.Name = "btnEncodeForm";
            this.btnEncodeForm.Size = new System.Drawing.Size(143, 21);
            this.btnEncodeForm.TabIndex = 14;
            this.btnEncodeForm.Text = "DuckyScript Encoder";
            this.btnEncodeForm.UseVisualStyleBackColor = true;
            this.btnEncodeForm.Click += new System.EventHandler(this.btnEncodeForm_Click);
            // 
            // btnExecuteButton
            // 
            this.btnExecuteButton.Enabled = false;
            this.btnExecuteButton.Location = new System.Drawing.Point(149, 158);
            this.btnExecuteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecuteButton.Name = "btnExecuteButton";
            this.btnExecuteButton.Size = new System.Drawing.Size(95, 21);
            this.btnExecuteButton.TabIndex = 13;
            this.btnExecuteButton.Text = "Execute Script";
            this.btnExecuteButton.UseVisualStyleBackColor = true;
            this.btnExecuteButton.Click += new System.EventHandler(this.btnExecuteButton_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Enabled = false;
            this.btnDebug.Location = new System.Drawing.Point(13, 158);
            this.btnDebug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(89, 21);
            this.btnDebug.TabIndex = 21;
            this.btnDebug.Text = "Validate Code";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(298, 158);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 21);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createSystemRestorePointToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // createSystemRestorePointToolStripMenuItem
            // 
            this.createSystemRestorePointToolStripMenuItem.Name = "createSystemRestorePointToolStripMenuItem";
            this.createSystemRestorePointToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.createSystemRestorePointToolStripMenuItem.Text = "Create System Restore Point";
            this.createSystemRestorePointToolStripMenuItem.Click += new System.EventHandler(this.createSystemRestorePointToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnUAC
            // 
            this.btnUAC.Location = new System.Drawing.Point(239, 61);
            this.btnUAC.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnUAC.Name = "btnUAC";
            this.btnUAC.Size = new System.Drawing.Size(143, 20);
            this.btnUAC.TabIndex = 23;
            this.btnUAC.Text = "UAC Enabled? Click Here";
            this.btnUAC.UseVisualStyleBackColor = true;
            this.btnUAC.Click += new System.EventHandler(this.btnUAC_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(387, 191);
            this.Controls.Add(this.btnUAC);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.SetDelayTextBox);
            this.Controls.Add(this.btnEncodeForm);
            this.Controls.Add(this.btnExecuteButton);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Rubber Ducky Toolkit";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.TextBox SetDelayTextBox;
        private System.Windows.Forms.Button btnEncodeForm;
        private System.Windows.Forms.Button btnExecuteButton;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSystemRestorePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnUAC;
    }
}

