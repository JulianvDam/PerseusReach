namespace PerseusReach;

public class TextContent
{
    private static bool setupComplete;
    private static string[] Intro;
    private static string[] partOne;
    private static string[] partTwo;
    private static string[] partThree;

    
    private static void RenderText()
    {
        // Intro text
        Intro = new string[]
        {
            "Blacksmith: 'Perseus, what weapon will you choose?'", "Blacksmith: 'Excellent choice.'"
        };
        
        // Part One Text
        partOne = new string[]
        {
            "Blacksmith: 'Perseus, now that you have your weapon, I must tell you something important. Have you heard about the horrifying creature that is attacking the cities? It is said that the creature can stone anyone who looks into it's eyes. You are the only one in this town that stands a chance, will you help?'",
            "Blacksmith: 'You can't be serious! The people are counting on you! You are the strongest man I know, you have to try!'",
            "You are walking home to make yourself ready for the journey up ahead. Will you take the shortcut?",
            "While making your way through narrow alleys you notice a man lying on the ground crying for help. Will you help him?",
            "As you come closer to the man you notice a dagger lying by his side. Suddenly the man screams and stabs you in the arm. The man steals steals your new longsword and runs off. You can't let him get away. You run after the man through the alleys. The man suddenly goes around the corner. As you follow him, you begin to feel like it's a trap, but you keep running anyway. A feeling of naivety gushed through you, it reminded you of your childhood. Father Zeus used to play small tricks on you, with the goal to make you a wiser and more competent man. A big strike on your head snapped you out of your thoughts, as you fell onto the ground.\nYou wake up and notice you are tied down. You notice the man walking towards you. ???: 'Who are you, what were you doing here?!'",
            "As you come closer to the man you notice a dagger lying by his side. Suddenly the man screams and stabs you in the arm. The man steals steals your new bow and runs off. You can't let him get away. You run after the man through the alleys. The man suddenly goes around the corner. As you follow him, you begin to feel like it's a trap, but you keep running anyway. A feeling of naivety gushed through you, it reminded you of your childhood. Father Zeus used to play small tricks on you, with the goal to make you a wiser and more competent man. A big strike on your head snapped you out of your thoughts, as you fell onto the ground.\nYou wake up and notice you are tied down. You notice the man walking towards you. ???: 'Who are you, what were you doing here?!'",
            "As you look around you notice that the man suddenly screams. You walk over to the man to see what is going on, when the man jump to his feet and steals your new longsword and runs off. You can't let him get away. You run after the man through the alleys. The man suddenly goes around the corner. As you follow him, you begin to feel like it's a trap, but you keep running anyway. A feeling of naivety gushed through you, it reminded you of your childhood. Father Zeus used to play small tricks on you, with the goal to make you a wiser and more competent man. A big strike on your head snapped you out of your thoughts, as you fell onto the ground.\nYou wake up and notice you are tied down. You notice the man walking towards you. ???: 'Who are you, what were you doing here?!'",
            "As you look around you notice that the man suddenly screams. You walk over to the man to see what is going on, when the man jump to his feet and steals your new bow and runs off. You can't let him get away. You run after the man through the alleys. The man suddenly goes around the corner. As you follow him, you begin to feel like it's a trap, but you keep running anyway. A feeling of naivety gushed through you, it reminded you of your childhood. Father Zeus used to play small tricks on you, with the goal to make you a wiser and more competent man. A big strike on your head snapped you out of your thoughts, as you fell onto the ground.\nYou wake up and notice you are tied down. You notice the man walking towards you. ???: 'Who are you, what were you doing here?!'",

        };
        partTwo = new string[]
        {
            
        };
        partThree = new string[]
        {
        };
        setupComplete = true;
    }

    public static string ReturnLine(int number, int partnumber)
    {   
        // Only render the TextContent once.
        if (!setupComplete)
            RenderText();
        
        // Switch case to return the TextContent based on the part of the story.
        switch (partnumber)
        {
            case 0:
                return Intro.ElementAt(number);
            case 1:
                return partOne.ElementAt(number);
        }
        return "";
    }
}


