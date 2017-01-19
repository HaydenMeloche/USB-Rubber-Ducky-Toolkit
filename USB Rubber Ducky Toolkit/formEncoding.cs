using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace USB_Rubber_Ducky_Toolkit
{
    public partial class formEncoding : Form
    {
        public formEncoding()
        {
            InitializeComponent();
        }
        //Varibles
        string FilePath = "";
        string outPutFilePath = "";
        string outputName = "inject.bin";
        
        //BUTTONS
        private void btnOutputButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog1.SelectedPath;
                Console.WriteLine(FilePath+ " Chosen for Output Path");
                btnEncode.Enabled = true;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            EncodeToBin();
        }
        //END OF BUTTONS
        private void EncodeToBin()
        {
            if (!File.Exists("script.txt"))
            {
                MessageBox.Show("Error. The script was copied to the same location but is now not there. Did you delete it?");
                Close();
                return;
                
            }
            string outputfilename = txtboxFileName.Text;
            if (outputfilename.Substring(Math.Max(0, outputfilename.Length - 4)) != ".bin" || outputfilename==".bin")
            {
                DialogResult dialogResult = MessageBox.Show("Please select a valid name for your file ending in .bin");
            }
            else
            {
                //start cmd and run java file passing duckyscript to it
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardError = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                outputName = txtboxFileName.Text;
                outPutFilePath = Path.Combine(FilePath, outputName);
                cmd.StandardInput.WriteLine("java -jar duckencode.jar -i \"" + "script.txt" + "\" -o \"" + outPutFilePath + "\"");


                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                MessageBox.Show(File.Exists(outPutFilePath) ? "Bin file created sucessfully." : "Error creating file. Possible file permissions problem. Try running program in admin privleges");
                outPutFilePath = "";
            }
        }
        

        private void lblPath_Click(object sender, EventArgs e)
        {

        }

        private void txtboxFileName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
