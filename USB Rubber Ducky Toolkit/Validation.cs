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

        private string[] validFKeys = new string[12] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" };
        private string[] validShiftKeys = new string[12] { "DELETE", "HOME", "INSERT", "PAGEUP", "PAGEDOWN", "WINDOWS", "GUI", "UPARROW", "DOWNARROW", "LEFTARROW", "RIGHTARROW", "TAB" };
        private string[] validCTRLkeys = new string[4] { "BREAK", "PAUSE", "ESCAPE", "ESC" };
        private string[] validAltKeys = new string[6] { "ALT", "END", "ESC", "ESCAPE", "SPACE", "TAB" };

        public bool LineCheck(string command, string keys, int currentLine)
        {
            switch (command)
            {
                case "REM":
                    break;
                case "STRING":
                    if (keys.Length <= 0)
                    {
                        MessageBox.Show("On line " + currentLine + " your STRING command is empty. This means it will type nothing." +
                            " This isn't a compile error. Just thought I'd let you know");
                    }
                    break;
                case "DEFAULT_DELAY":
                case "DEFAULTDELAY":
                    if (currentLine == 1)
                    {
                        try
                        {
                            Convert.ToInt32(keys);
                        }
                        catch
                        {
                            MessageBox.Show("Error. On line " + currentLine + ", the command following defaultdelay is not a integer (ex 500)");
                            return false;
                        }
                    } else
                    {
                        MessageBox.Show("Error. DEFAULTDELAY is currently on line " + currentLine + ". It needs to be on line 1.");
                        return false;
                    }
                    
                    break;

                case "DELAY":
                    try
                    {
                        Convert.ToInt32(keys);
                    }
                    catch
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", the command following delay is not a integer (ex 500)");
                        return false;
                    }
                    break;

                case "WINDOWS":
                case "GUI":
                    if (keys.Length > 2)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", the command following GUI/WINDOWS is more than 2 characters. " );
                        return false;
                    }
                    break;

                case "ENTER":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", their is a command following ENTER. ENTER function doesn't support keyboard combos");
                        return false;
                    }
                    break;

                case "APP":
                case "MENU":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", their is a command following MENU/APP. MENU function doesn't support keyboard combos");
                        return false;
                    }
                    break;

                case "SHIFT":
                    if (keys.Length > 0 && !validShiftKeys.Contains(keys))
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", the command following SHIFT is invalid. Please look at DuckyScript documentation for more info");
                        return false;
                    }
                    break;

                case "ALT":
                    if (!validAltKeys.Contains(keys) && !validFKeys.Contains(keys) && keys.Length > 0 && keys.Length < 2 && !Char.IsLetter(Convert.ToChar(keys)))
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", the command follwing ALT is not valid. See official DuckyScript documentation for compatible functions");
                        return false;
                    }                      
                    break;

                case "CONTROL":
                case "CTRL":
                    if (!validCTRLkeys.Contains(keys) && !validFKeys.Contains(keys) && keys.Length > 0 && keys.Length < 2 && !Char.IsLetter(Convert.ToChar(keys)))
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", the command following CTRL is not valid. See official DuckyScript documentation for compatitble functions" );
                        return false;
                    }
                    break;

                case "TAB":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following TAB.");
                        return false;
                    }
                    break;

                case "DOWNARROW":
                case "DOWN":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following DOWN.");
                        return false;
                    }
                    break;

                case "LEFTARROW":
                case "LEFT":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following LEFT.");
                        return false;
                    }
                    break;

                case "RIGHTARROW":
                case "RIGHT":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following RIGHT.");
                        return false;
                    }
                    break;

                case "UPARROW":
                case "UP":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following UP.");
                        return false;
                    }
                    break;

                case "REPLAY":
                    try
                    {
                        Convert.ToInt32(keys);
                    }
                    catch
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", the command following REPLAY is not a integer (ex 500)");
                        return false;
                    }
                    break; 
                case "DELETE":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following DELETE.");
                        return false;
                    }
                    break;
                case "CAPS":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following CAPS.");
                        return false;
                    }
                    break;
                case "SPACE":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following SPACE.");
                        return false;
                    }
                    break;
                case "PRINTSCREEN":
                    if (keys.Length > 0)
                    {
                        MessageBox.Show("Error. On line " + currentLine + ", there is a command following PRINTSCREEN.");
                        return false;
                    }
                    break;
                default:
                    MessageBox.Show("Error. On line " + currentLine + ", the command you are trying to run was not reconized.");
                    return false;
            }
            return true;
        }

    }
}
