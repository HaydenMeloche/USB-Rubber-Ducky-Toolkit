using System;
using System.IO;
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
        private string FilePath = "";
        public string directoryPath = "";
        private DuckyScriptProcessing DuckyScriptProcessing = new DuckyScriptProcessing();
        private formEncoding formEncoding = new formEncoding();

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
                DuckyScriptProcessing.SetDelay(DefaultDelay);
                MessageBox.Show("The delay between each command is now set to " + DefaultDelay + "ms");
            }
            else
            {
                MessageBox.Show("Not a valid number. Please enter non decimal numbers (100, 500, 1000)");
            }
        }

        private void btnEncodeForm_Click(object sender, EventArgs e)
        {
            //need to copy script over to install folder and then have formEncode use it
            formEncoding.Show();//show encoding form
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (DuckyScriptProcessing.validateCode(FilePath) == true) //Validate code
            {
                btnExecuteButton.Enabled = true;
                btnEncodeForm.Enabled = true;
                MessageBox.Show("No problems found in code");
            }
        }

        private void btnExecuteButton_Click(object sender, EventArgs e)
        {
            DuckyScriptProcessing.ReadFile(FilePath); //emulate code
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
              
        //END OF BUTTONS
        //MENU STRIP
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FindFile();
        }

        private void createSystemRestorePointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("restore.vbs");//Creates system restore point
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Opens current file in notepad
            if (FilePath != "")
            { //Opens file in notepad
                try
                {
                    System.Diagnostics.Process.Start("notepad.exe", FilePath);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Problem opening notepad.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a file before you try to edit it.");
            }
        }

        //END OF MENU STRIP
        

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