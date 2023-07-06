using System.Reflection.Metadata;
using static System.Console;

namespace PerseusReach;

public class PartOne
{
    public static void RunPartOne()
    {
        Console.Clear();
        
        Program.ShowStats();
        Console.WriteLine("Press any key to start 'PART ONE - THE HERO'S RISE'");
        ReadKey(true);

        string text1 = TextContent.ReturnLine(0, 1);
        string[] option1 = { "Yes, I will restore glory to the cities", "I can not son" };
        OptionsMenu choice1 = new OptionsMenu(option1, text1);
        int selectedchoice1 = choice1.Run();

        switch (selectedchoice1)
        {
            case 0:
                // Add Hero Point for accepting the quest
                Program.ChangeHeroPoints(5);
                break;
            case 1:
                string text2 = TextContent.ReturnLine(1, 1);
                string[] option2 = { "You are right boy" };
                OptionsMenu choice2 = new OptionsMenu(option2, text2);
                choice2.Run();
                break;
        }

        string text3 = TextContent.ReturnLine(2, 1);
        string[] option3 = { "Of course!", "I will take the long road" };
        OptionsMenu choice3 = new OptionsMenu(option3, text3);
        int selectedchoice3 = choice3.Run();

        switch (selectedchoice3)
        {
            case 0:
                string text4 = TextContent.ReturnLine(3, 1);
                string[] option4 =
                    { "I must help that man.", "Pff, don't even bother.", "Let me look around first." };
                OptionsMenu choice4 = new OptionsMenu(option4, text4);
                int selectedchoice4 = choice4.Run();
                var inventory = Program.GetInventory();
                string weapon = inventory.First().ToLower();
                switch (selectedchoice4)
                {
                    case 0:
                        string text5 = TextContent.ReturnLine(weapon == "longsword" ? 4 : 5, 1);
                        string[] option5 =
                            { "Im Perseus, I was on my way home.", "Im Marcus, a greek War hero. My troops are right behind me, you better cut me loose." };
                        OptionsMenu choice5 = new OptionsMenu(option5, text5);
                        int selectedchoice5 = choice5.Run();
                        break;
                    case 1:
                        Program.ChangeHeroPoints(-15);
                        break;
                    case 2:
                        string text6 = TextContent.ReturnLine(weapon == "longsword" ? 6 : 7, 1);
                        string[] option6 =
                            { "Im Perseus, I was on my way home.", "Im Marcus, a greek War hero. My troops are right behind me, you better cut me loose." };
                        OptionsMenu choice6 = new OptionsMenu(option6, text6);
                        int selectedchoice6 = choice6.Run();
                        break;
                }
                break;
            case 1:
                break;

        }
    }
}
