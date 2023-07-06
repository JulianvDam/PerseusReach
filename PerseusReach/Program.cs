using static System.Console;

namespace PerseusReach
{
    public class Program
    {
        private static int _hitpoints = 100;
        private static int _heropoints = 20;
        private static List<string> Inventory = new List<string>();
            
        static void Main()
        {
            Console.CursorVisible = false;
            
            // Runs the Main Menu
            MainMenu.RunMainMenu();
            // Runs Part One - "The Hero's Rise"
            PartOne.RunPartOne();
            // Runs Part Two - "Fear and Misery"
            //Part2();
            // Runs Part Three - "The Final quest"
            //Part3();
        }

        public static void ChooseWeapon()
        {
            Console.Clear();
            
            // Get text and make a menu to choose a weapon
            string chooseWeapon = TextContent.ReturnLine(0,0); 
            string[] weaponOptions = { "A Longsword", "A bow with a full Quiver" };
            OptionsMenu weaponMenu = new OptionsMenu(weaponOptions, chooseWeapon);
            int chosenWeapon = weaponMenu.Run();
            switch (chosenWeapon)
            {
                case 0:
                    Inventory.Add("Longsword");
                    break;
                case 1:
                    Inventory.Add("Bow");
                    break;
            }

            WriteTextLine(1,0);
            
            Console.WriteLine("Press Enter to continue...");
            ReadKey(true);
        }
        
        public static void ShowStats()
        {
            string inventoryItems = "";
            foreach (var item in Inventory)
            {
                inventoryItems += $"  - {item}\n";
            }
            Console.WriteLine($"-- Perseus --\nHitpoints: {_hitpoints} \nHeropoints: {_heropoints}\nInventory:\n{inventoryItems}");
        }

        public static void ChangeHeroPoints(int number)
        {
            _heropoints += number;
            Console.WriteLine(number < 0 ? $"Hero Points: {_heropoints} - {number}" : $"Hero Points: {_heropoints} + {number}");
        }
        
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void WriteTextLine(int textnumber, int partnumber)
        {
            Console.WriteLine(TextContent.ReturnLine(textnumber, partnumber));
        }

        public static List<string> GetInventory()
        {
            return Inventory;
        }
    }
}