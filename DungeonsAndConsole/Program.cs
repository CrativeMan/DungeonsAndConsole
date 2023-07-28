namespace DungeonsAndConsole;

public static class Program
{
    private static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine("Welcome to Dungeons and Console!");
        Console.WriteLine("Do you dare enter the dungeon? (y/n)");
        
        var input = Console.ReadLine();
        if (input is "y" or "Y")
        {
            Console.WriteLine("You are brave!");
            InitStory();
        }
        else
        {
            Console.WriteLine("You are a coward!");
            return;
        }
    }

    private static void InitStory()
    {
        Console.Clear();
        Console.WriteLine("You are a brave adventurer who has entered the dungeon.");
        Console.WriteLine("You are searching for the legendary treasure of the dungeon.");
        Console.WriteLine("What is your name, adventurer?");
        String input = Console.ReadLine();
        var player = new Player(input, 30, 10, 10, 10, 1);
        Console.Clear();
        Console.WriteLine("Welcome, " + player.Name + "!");
        Console.WriteLine("You have " + player.Health + " health.");
        Console.WriteLine("You have " + player.Attack + " attack.");
        Console.WriteLine("You have " + player.Defense + " defense.");
        Console.WriteLine("You have " + player.Gold + " gold.");
        Console.WriteLine("You are level " + player.Level + ".");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}