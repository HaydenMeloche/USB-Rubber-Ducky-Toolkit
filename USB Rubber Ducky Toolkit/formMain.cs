using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Rubber_Ducky_Toolkit
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        //Variables
        string FilePath = "";
        string directoryPath = "";
        DuckyScriptProcessing keyboard = new DuckyScriptProcessing();
        formEncoding formEncoding = new formEncoding();
        //BUTTONS
        private void btnPath_Click(object sender, EventArgs e)
        {
            FindFile(); //Opens file browser
        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            int DefaultDelay;
            if (int.TryParse(SetDelayTextBox.Text, out DefaultDelay))
            {
                DefaultDelay = Convert.ToInt32(SetDelayTextBox.Text);
                keyboard.SetDelay(DefaultDelay);
                MessageBox.Show("The delay between each command is now set to " + DefaultDelay + "ms");
            }
            else
            {
                MessageBox.Show("Not a valid number. Please enter non decimal numbers (100, 500, 1000)");
            }
        }

        private void btnEncodeForm_Click(object sender, EventArgs e)
        {
            formEncoding.Show();//show encoding form
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (keyboard.validateCode(FilePath) == true) //Validate code
            {
                btnExecuteButton.Enabled = true;
                btnEncodeForm.Enabled = true;
                MessageBox.Show("No problems found in code");
            }
        }
        private void btnExecuteButton_Click(object sender, EventArgs e)
        {
            keyboard.ReadFile(FilePath); //emulate code
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createRestorePointToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //END OF BUTTONS
        public string getDuckyScriptLocation()
        {
            return FilePath; //Give file path to different forms
        }
        private void FindFile() //Lets user select script file
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open DuckyScript Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            theDialog.RestoreDirectory = true;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            FilePath = theDialog.FileName;
                            directoryPath = Path.GetDirectoryName(FilePath);
                            formEncoding.getScriptDirectory(directoryPath);
                            btnDebug.Enabled = true; //enable validate button
                            btnEncodeForm.Enabled = true; //enable encoder button
                            PathLabel.Text = FilePath; //display path

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
