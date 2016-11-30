using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace USB_Rubber_Ducky_Toolkit
{
    class DuckyScriptProcessing
    {

        bool defaultdelay = false;
        int defaultdelayvalue;
        string lastCommand;
        string lastKey;
        string[] validCommands = new string[24] { "TAB","REM", "DEFAULT_DELAY", "DEFAULTDELAY", "DELAY", "STRING", "WINDOWS", "GUI", "MENU", "APP", "SHIFT", "ALT","CONTROL" , "CTRL", "DOWN",
            "DOWNARROW", "UP", "UPARROW", "LEFT", "LEFTARROW", "RIGHT", "RIGHTARROW","REPLAY", "ENTER"}; //array of valid commands
        string[] validKeys = new string[29] { "SHIFT" ,"HOME", "DELETE","INSERT","PAGEUP","PAGEDOWN","WINDOWS","GUI","UPARROW","DOWNARROW","LEFTARROW","RIGHTARROW","TAB","END","ESCAPE","SPACE","TAB",
        "F1","F2","F3","F4","F5","F6","F7","F8","F9","F10","F11","F12"}; //array of valid keys 
        public void SetDelay(int delay)
        {
            if (delay > 1)
            {
                defaultdelay = true; //this is to let the emulator know after each command it must delay
            }
            defaultdelayvalue = delay;
        }

        public void ReadFile(String FilePath)
        {
            string[] duckyFile = File.ReadAllLines(FilePath);
            foreach (var currentLine in duckyFile)
            {
                Calculate(currentLine);
            }
        }

        public void Calculate(string currentLine)
        {
            string[] words = currentLine.Split(' ');
            string command = words[0];
            string keys = "";
            //Console.WriteLine(command);
            int flag = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (flag == 0)
                {
                    keys += words[i];
                    flag++;
                }
                else
                {
                    keys += " " + words[i];
                }
            }
            //Console.WriteLine(keys);
            KeyboardAction(command, keys);
        }
        private void CheckDefaultSleep() //checks if their is a delay set. If so, delays
        {
            if (defaultdelay == true)
            {
                Thread.Sleep(defaultdelayvalue);
            }
        }
        private void setLastCommand(string command, string keys)
        {
            lastCommand = command;
            lastKey = keys;

        }
        public bool validateCode(string FilePath) //validates the commands in a duckyscript
        {
            string[] duckyFile = File.ReadAllLines(FilePath);
            int currentLineNum = 1;
            foreach (var currentLine in duckyFile)
            {
                string[] words = currentLine.Split(' ');
                string command = words[0];

                if (!validCommands.Contains(command))
                {
                    MessageBox.Show("Error in code. Please check line " + currentLineNum);
                    return false;
                }
                currentLineNum++;
            }
            return true;
        }

        private void KeyboardAction(string command, string keys) //executes the code line by line.
        {
            string keyboardkey = keys.ToUpper();
            VirtualKeyCode code;
            switch (command)
            {
                case "DEFAULT_DELAY":
                case "DEFAULTDELAY":
                    defaultdelay = true;
                    defaultdelayvalue = Convert.ToInt32(keys);
                    break;
                case "DELAY":
                    CheckDefaultSleep();
                    Thread.Sleep(Convert.ToInt32(keys));
                    break;
                case "STRING":
                    CheckDefaultSleep();
                    InputSimulator.SimulateTextEntry(keys);
                    break;
                case "WINDOWS":
                case "GUI":
                    CheckDefaultSleep();
                    if (Enum.TryParse<VirtualKeyCode>("VK_" + keyboardkey, out code))
                    {
                        InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, code);
                    }
                    break;
                case "ENTER":
                    CheckDefaultSleep();
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                    break;
                case "APP":
                case "MENU":
                    CheckDefaultSleep();
                    InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.F10);
                    break;
                case "SHIFT":
                    CheckDefaultSleep();
                    switch (keys)
                    {
                        case "WINDOWS":
                        case "GUI":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.LWIN);
                            break;
                        case "UPARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.UP);
                            break;
                        case "DOWNARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.DOWN);
                            break;
                        case "LEFTARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.LEFT);
                            break;
                        case "RIGHTARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.RIGHT);
                            break;
                        default:
                            if (Enum.TryParse<VirtualKeyCode>("" + keyboardkey, out code))
                            {
                                InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, code);
                            }
                            break;
                    }

                    break;

                case "ALT":
                    CheckDefaultSleep();
                    switch (keys)
                    {
                        case "WINDOWS":
                        case "GUI":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.LWIN);
                            break;
                        case "UPARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.UP);
                            break;
                        case "DOWNARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.DOWN);
                            break;
                        case "LEFTARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.LEFT);
                            break;
                        case "RIGHTARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.RIGHT);
                            break;
                        default:
                            if (keyboardkey.Length > 1)
                            {
                                //For support for keys such as "end"
                                if (Enum.TryParse<VirtualKeyCode>("" + keyboardkey, out code))
                                {
                                    InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, code);

                                }
                            }
                            else
                            {
                                if (Enum.TryParse<VirtualKeyCode>("VK_" + keyboardkey, out code))
                                {
                                    InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LMENU, code);
                                }

                            }
                            break;
                    }
                    break;
                case "CONTROL":
                case "CTRL":
                    CheckDefaultSleep();
                    switch (keys)
                    {
                        case "PAUSE":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.PAUSE);
                            break;
                        case "UPARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.UP);
                            break;
                        case "DOWNARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.DOWN);
                            break;
                        case "LEFTARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.LEFT);
                            break;
                        case "RIGHTARROW":
                            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.RIGHT);
                            break;
                        default:
                            if (keyboardkey.Length > 1)
                            {
                                //For support for keys such as "end"
                                if (Enum.TryParse<VirtualKeyCode>("" + keyboardkey, out code))
                                {
                                    InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, code);

                                }
                            }
                            else
                            {
                                if (Enum.TryParse<VirtualKeyCode>("VK_" + keyboardkey, out code))
                                {
                                    InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, code);
                                }

                            }
                            break;
                    }
                    break;
                case "TAB":
                    CheckDefaultSleep();
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.TAB);
                    break;
                case "DOWNARROW":
                case "DOWN":
                    CheckDefaultSleep();
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.DOWN);
                    break;
                case "LEFTARROW":
                case "LEFT":
                    CheckDefaultSleep();
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.LEFT);
                    break;
                case "RIGHTARROW":
                case "RIGHT":
                    CheckDefaultSleep();
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.RIGHT);
                    break;
                case "UPARROW":
                case "UP":
                    CheckDefaultSleep();
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.UP);
                    break;
                case "REPLAY":
                    CheckDefaultSleep();
                    for (int i = 0; i < Convert.ToInt32(keys); i++)
                    {
                        KeyboardAction(lastCommand, lastKey);
                    }
                    break;
            }
            if (command != "REPLAY") //Basically if the last function wasn't replay. Make the current command the last one
            {
                setLastCommand(command, keys);  //Used for the repeat function

            }

        }

    }
}
