using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace Lumberjack_Typing_Adventure_ConsoleApp.Menus
{


    public class Menu
    {
        public int SelectedIndex;                          // Selected Index will be the current option
        public string[] Options;
        public string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt + "\n----------------------------------\n";
            Options = options;
            SelectedIndex = 0;                              // Selected Index starts at the top of the options
        }

        public void DisplayOptions()                        // Display Options shows menu prompt and lists menu options, highlighting current option
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];          // Current Option is the selected index

                if (i == SelectedIndex)                     // This if/else statement sets the color of current option and default color for remaining options
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"{currentOption}");              // Writes menu options
            }
            ResetColor();
        }


        public int Run()                                 // Run method calls Display Options method and allows arrow keys to flip through menu option before option selection
        {
            ConsoleKey keyPressed;
            do                                           // This do/while loop keeps options displayed until enter key is pressed, which will select the current highlighted option
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)    // If the up arrow is pressed, move highlight to the option above the current option
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)             // If the current option is at the top of the list and up arrow is pressed, move highlight to bottom of menu
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)  // If the down arrow is pressed, move highlight to the option below the current option
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) // If the current option is at the bottom of the list and down arrow is pressed, move highlight to top of the menu
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;                        // Returns int value of selected option
        }
    }


}