namespace USB_Rubber_Ducky_Toolkit
{
    partial class formEncoding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEncoding));
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(14, 160);
            this.txtboxFileName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.Size = new System.Drawing.Size(268, 31);
            this.txtboxFileName.TabIndex = 15;
            this.txtboxFileName.Text = "inject.bin";
            this.txtboxFileName.TextChanged += new System.EventHandler(this.txtboxFileName_TextChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(291, 162);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(356, 50);
            this.lblDestination.TabIndex = 14;
            this.lblDestination.Text = "Enter custom name above if desired\r\nExample: mycoolcode.bin\r\n";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEncode
            // 
            this.btnEncode.Enabled = false;
            this.btnEncode.Location = new System.Drawing.Point(62, 218);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(219, 56);
            this.btnEncode.TabIndex = 13;
            this.btnEncode.Text = "Encode to Bin FIle";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(629, 100);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "DuckyScript Encoder";
            // 
            // btnOutputButton
            // 
            this.btnOutputButton.Location = new System.Drawing.Point(288, 218);
            this.btnOutputButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputButton.Name = "btnOutputButton";
            this.btnOutputButton.Size = new System.Drawing.Size(269, 56);
            this.btnOutputButton.TabIndex = 16;
            this.btnOutputButton.Text = "Select Output Location";
            this.btnOutputButton.UseVisualStyleBackColor = true;
            this.btnOutputButton.Click += new System.EventHandler(this.btnOutputButton_Click);
            // 
            // formEncoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 281);
            this.Controls.Add(this.txtboxFileName);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formEncoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuckScript Encoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOutputButton;
    }
}