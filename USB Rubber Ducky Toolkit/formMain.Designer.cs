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
            this.btnPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelay = new System.Windows.Forms.Button();
            this.SetDelayTextBox = new System.Windows.Forms.TextBox();
            this.btnEncodeForm = new System.Windows.Forms.Button();
            this.btnExecuteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRestorePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 38);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(120, 33);
            this.btnPath.TabIndex = 12;
            this.btnPath.Text = "Choose Path";
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
            this.PathLabel.Location = new System.Drawing.Point(14, 74);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(129, 20);
            this.PathLabel.TabIndex = 18;
            this.PathLabel.Text = "No path selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "This emulator tends to run DuckyScript faster than a Ducky would. You can set a d" +
    "elay between each function here (in miliseconds)";
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(14, 98);
            this.btnDelay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(112, 34);
            this.btnDelay.TabIndex = 16;
            this.btnDelay.Text = "Set Delay";
            this.btnDelay.UseVisualStyleBackColor = true;
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // SetDelayTextBox
            // 
            this.SetDelayTextBox.Location = new System.Drawing.Point(138, 103);
            this.SetDelayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SetDelayTextBox.Name = "SetDelayTextBox";
            this.SetDelayTextBox.Size = new System.Drawing.Size(67, 26);
            this.SetDelayTextBox.TabIndex = 15;
            // 
            // btnEncodeForm
            // 
            this.btnEncodeForm.Enabled = false;
            this.btnEncodeForm.Location = new System.Drawing.Point(753, 38);
            this.btnEncodeForm.Name = "btnEncodeForm";
            this.btnEncodeForm.Size = new System.Drawing.Size(201, 33);
            this.btnEncodeForm.TabIndex = 14;
            this.btnEncodeForm.Text = "DuckyScript Encoder";
            this.btnEncodeForm.UseVisualStyleBackColor = true;
            this.btnEncodeForm.Click += new System.EventHandler(this.btnEncodeForm_Click);
            // 
            // btnExecuteButton
            // 
            this.btnExecuteButton.Location = new System.Drawing.Point(696, 167);
            this.btnExecuteButton.Name = "btnExecuteButton";
            this.btnExecuteButton.Size = new System.Drawing.Size(134, 33);
            this.btnExecuteButton.TabIndex = 13;
            this.btnExecuteButton.Text = "Execute Script";
            this.btnExecuteButton.UseVisualStyleBackColor = true;
            this.btnExecuteButton.Click += new System.EventHandler(this.btnExecuteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(999, 35);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createRestorePointToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createRestorePointToolStripMenuItem
            // 
            this.createRestorePointToolStripMenuItem.Name = "createRestorePointToolStripMenuItem";
            this.createRestorePointToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.createRestorePointToolStripMenuItem.Text = "Create Restore Point";
            this.createRestorePointToolStripMenuItem.Click += new System.EventHandler(this.createRestorePointToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Enabled = false;
            this.btnDebug.Location = new System.Drawing.Point(588, 167);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(100, 33);
            this.btnDebug.TabIndex = 21;
            this.btnDebug.Text = "Validate Code";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(836, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 33);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 222);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.SetDelayTextBox);
            this.Controls.Add(this.btnEncodeForm);
            this.Controls.Add(this.btnExecuteButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnExit);
            this.Name = "formMain";
            this.Text = "USB Rubber Ducky Toolkit";
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRestorePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnExit;
    }
}

