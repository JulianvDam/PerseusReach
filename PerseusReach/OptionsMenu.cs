using static System.Console;

namespace PerseusReach;

public class OptionsMenu
{
    private int selectedOption;
    private string[] menuOptions;
    private string selectedOptionString;

    public OptionsMenu(string[] menuoptions, string selectedoptionstring)
    {
        menuOptions = menuoptions;
        selectedOptionString = selectedoptionstring;
        selectedOption = 0;
    }

    public void DisplayMenu()
    {
        Console.WriteLine($"{selectedOptionString}\n");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            string currentOption = menuOptions[i];
            if (selectedOption == i)
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"<< {currentOption} >>");
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"   {currentOption}   ");
            }
        }

        ResetColor();
    }
    
    public int Run()
    {
        ConsoleKey pressedKey;
        do
        {
            Console.Clear();
            DisplayMenu();
                
            ConsoleKeyInfo keyInfo = ReadKey();
            pressedKey = keyInfo.Key;

            if (pressedKey == ConsoleKey.UpArrow)
            {
                selectedOption--;
                if (selectedOption < 0)
                {
                    selectedOption = menuOptions.Length - 1;
                }
            } else if (pressedKey == ConsoleKey.DownArrow)
            {
                selectedOption++;
                if (selectedOption > menuOptions.Length - 1)
                {
                    selectedOption = 0;
                }
            }
                
        } while (pressedKey != ConsoleKey.Enter);
            
        return selectedOption;
    }
    
}