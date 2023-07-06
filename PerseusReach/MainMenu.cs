using System.Diagnostics;
using static System.Console;

namespace PerseusReach;

public class MainMenu
{
    public static void RunMainMenu()
    {
        string mainLogo = @"
██████╗░███████╗██████╗░░██████╗███████╗██╗░░░██╗░██████╗██╗        ██████╗░███████╗░█████╗░░█████╗░██╗░░██╗
██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝██║░░░██║██╔════╝╚█║        ██╔══██╗██╔════╝██╔══██╗██╔══██╗██║░░██║
██████╔╝█████╗░░██████╔╝╚█████╗░█████╗░░██║░░░██║╚█████╗░░╚╝        ██████╔╝█████╗░░███████║██║░░╚═╝███████║
██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗██╔══╝░░██║░░░██║░╚═══██╗░░░        ██╔══██╗██╔══╝░░██╔══██║██║░░██╗██╔══██║
██║░░░░░███████╗██║░░██║██████╔╝███████╗╚██████╔╝██████╔╝░░░        ██║░░██║███████╗██║░░██║╚█████╔╝██║░░██║
╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═════╝░░░░        ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝
(Use the arrow keys to cycle through the options and press enter to select an option)";
        string[] mainOptions = { "Play", "Credits", "Exit" };
        OptionsMenu mainmenu = new OptionsMenu(mainOptions, mainLogo);
        int selectedIndex = mainmenu.Run();

        switch (selectedIndex)
        {
            case 0:
                Playgame();
                break;
            case 1:
                Credits();
                break;
            case 2:
                ExitGame();
                break;
        }
    }
    public static void Playgame()
    {
        Program.ChooseWeapon();
        PartOne.RunPartOne();
    }

    public static void Credits()
    {
        Console.Clear();
        Console.WriteLine("[~] Programmed by - Julian van Dam  (https://www.linkedin.com/in/julian-van-dam/)");
        Console.WriteLine("[~] Story by - Julian van Dam  (https://www.julianvandam.nl)");
        Console.WriteLine("[~] Tested by - Julian van Dam  (https://github.com/JulianvDam)");
        Console.WriteLine("[~] Main Menu Art by 'fsymbols.com' - 'https://fsymbols.com/generators/carty/'");
        Console.WriteLine("[!] \nPress any key to return to the main menu...");
        ReadKey(true);
        RunMainMenu();
    }

    public static void ExitGame()
    {
        Console.WriteLine("Press any key to exit...");
        ReadKey(true);
        Environment.Exit(0);
    }
}