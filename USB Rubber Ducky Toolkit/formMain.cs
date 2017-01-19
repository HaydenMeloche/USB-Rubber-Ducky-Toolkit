using Microsoft.Win32;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace USB_Rubber_Ducky_Toolkit
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("InputSimulator.dll"))
            {
                MessageBox.Show("Error finding InputSimulator.dll. Please keep this file in the same folder as this program.");
                Close();
            }
            if (!File.Exists("duckencode.jar"))
            {
                MessageBox.Show("Error finding duckencode.jar. Please keep this file in the same folder as this program. The encoding feature has been disabled.");
                duckEncodeFound = false;
            }

            try
            {
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey subKey = rk.OpenSubKey("HKEY_LOCAL_MACHINE\\Software\\JavaSoft");
                                
            }
            catch (Exception)
            {
                MessageBox.Show("No java was detected. Any features that require it have been disbaled.");
                duckEncodeFound = false;
            }

        }

        //Variables
        private string FilePath = "";
        public string directoryPath = "";
        private bool duckEncodeFound = true;
        private DuckyScriptProcessing DuckyScriptProcessing = new DuckyScriptProcessing();
         
        
        //BUTTONS
        private void btnPath_Click(object sender, EventArgs e)
        {
            FindFile(); //Opens file browser
        }

        private void btnDelay_Click(object sender, EventArgs e) 
        {   //When delay button is pressed, validate it, the set it.
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
            
            File.Copy(FilePath,"script.txt", true); //copy the script to exe folder
            formEncoding formEncoding = new formEncoding();
            formEncoding.ShowDialog(); //show encoding form
            if (File.Exists("script.txt"))
            {
                File.Delete("script.txt");
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (DuckyScriptProcessing.validateCode(FilePath) == true) //Validate code
            {
                btnExecuteButton.Enabled = true;
                if (duckEncodeFound == true)
                {
                    btnEncodeForm.Enabled = true;
                }
                MessageBox.Show("No problems found in code");
            }
        }

        private void btnExecuteButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(FilePath))
            {
                Thread.Sleep(500); //gives user a second to take hand off mouse
                InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_D);
                Thread.Sleep(500);
                DuckyScriptProcessing.ReadFile(FilePath); //emulate code
            } else
            {
                MessageBox.Show("Your file " + FilePath + " can longer be found. Please load the script again");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUAC_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("UAC causes problems for DuckyToolkit." +
                " For security reasons Windows doesn't allow programs to say Yes to UAC like a Ducky can. "+
                "It is highly recommended you disable UAC while testing scripts. Optionally, you can wait for UAC to trigger and say yes yourself quickly."
                + "\nWould you like to open the UAC control panel?", "More UAC, More Problems", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\UserAccountControlSettings.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    throw;
                }
            }
            
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
                    System.Diagnostics.Process.Start("notepad++.exe", FilePath);
                }
                catch (Exception)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("notepad.exe", FilePath);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Problem opening notepad. Error = " + exx);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select a file before you try to edit it.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        //END OF MENU STRIP
        public void moveFile()
        {

        }


        private void FindFile() //Lets user select script file
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open DuckyScript Text File";
            theDialog.Filter = "TXT files|*.txt";
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
                            btnDebug.Enabled = true; //enable validate button
                            SetDelayTextBox.Enabled = true; //enable delay txt box
                            btnDelay.Enabled = true; //enable delay button 
                            PathLabel.Text = "DuckyScript Loaded!"; //display path
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