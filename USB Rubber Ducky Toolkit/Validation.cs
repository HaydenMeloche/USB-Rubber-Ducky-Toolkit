using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Rubber_Ducky_Toolkit
{
    class Validation
    {
        //This class is going to be used to validate the DuckyScript (instead of just checking the 1st word like before)

        private string[] validCommands = new string[24] { "TAB","REM", "DEFAULT_DELAY", "DEFAULTDELAY", "DELAY", "STRING", "WINDOWS", "GUI", "MENU", "APP", "SHIFT", "ALT","CONTROL" , "CTRL", "DOWN",
            "DOWNARROW", "UP", "UPARROW", "LEFT", "LEFTARROW", "RIGHT", "RIGHTARROW","REPLAY", "ENTER"}; //array of valid commands


        public bool LineCheck(string command, string keys, int currentLine)
        {
            switch (command)
            {
                case "STRING":
                    if (keys.Length <= 0)
                    {
                        MessageBox.Show("On line " + currentLine + " your STRING command is empty. This means it will type nothing." +
                            " This isn't a compile error. Just thought I'd let you know");
                    }
                    break;
                case "DEFAULT_DELAY":
                case "DEFAULTDELAY":
                    try
                    {
                        Convert.ToInt32(keys);
                    } catch
                    {
                        MessageBox.Show("On line " + currentLine + ", the command following defaultdelay is not a integer (ex 500)");
                    }
                    break;

                case "DELAY":
                    try
                    {
                        Convert.ToInt32(keys);
                    }
                    catch
                    {
                        MessageBox.Show("On line " + currentLine + ", the command following delay is not a integer (ex 500)");
                    }
                    break;

                case "WINDOWS":
                case "GUI":
                    
                    break;

                case "ENTER":
                    
                    break;

                case "APP":
                case "MENU":
                    
                    break;

                case "SHIFT":
                    break;

                case "ALT":
                                           
                    break;

                case "CONTROL":
                case "CTRL":
                    
                    break;

                case "TAB":
                   
                    break;

                case "DOWNARROW":
                case "DOWN":
                   
                    break;

                case "LEFTARROW":
                case "LEFT":
                    
                    break;

                case "RIGHTARROW":
                case "RIGHT":
                    
                    break;

                case "UPARROW":
                case "UP":
                    
                    break;

                case "REPLAY":
                    
                    break;
                default:
                    MessageBox.Show("On line " + currentLine + ", the command you are trying to run was not reconized");
                    return false;
            }
            return true;
        }

    }
}
