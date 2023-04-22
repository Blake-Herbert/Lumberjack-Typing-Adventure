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
        public int SelectedIndex;                          
        public string[] Options;
        public string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt + "\n----------------------------------\n";
            Options = options;
            SelectedIndex = 0;                                    
        }

        public void DisplayOptions()                       
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];         
                if (i == SelectedIndex)                                    
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"{currentOption}");              
            }
            ResetColor();
        }


        public int Run()                                 
        {
            ConsoleKey keyPressed;
            do                                           
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)    
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)             
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)  
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) 
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;                        
        }
    }
}