using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace proyecto_final
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;

        }

        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string CurrentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix}<<{CurrentOption}>>");
            }
            ResetColor();

        }

        public int Run()
        {
            ConsoleKey KeyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo Keyinfo = ReadKey(true);
                KeyPressed = Keyinfo.Key;

                // update selected index with arrow keys.
                if (KeyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    
                    }
                }

                else if (KeyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0; 
                    }
                  
                }
            } while (KeyPressed != ConsoleKey.Enter);
            return SelectedIndex;

        
        
        }
    }
}
