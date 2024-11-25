using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
       bool programRunning = true;

       while (programRunning)
       {
            Console.Clear(); //This is the menu design
            Console.WriteLine("//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\");
            Console.WriteLine("||       Scripture Memorizer Menu      ||");
            Console.WriteLine("||   1. Reapeat the same scripture     ||");
            Console.WriteLine("||      2. Add a new Scripture         ||");
            Console.WriteLine("||             3. Quit                 ||");
            Console.Write("||        Choose an option (1-3): ");

            string menuChoice = Console.ReadLine();

            //Menu Options
            switch (menuChoice)
            {
                case "1":
                    RepeatScripture();
                    break;

                case "2":
                    AddNewScripture();
                    break;

                case "3":
                    programRunning = false; // Exit the loop and program
                    Console.WriteLine("GoodBye!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please Choose a valid option.");
                    Console.ReadLine(); // Pause before re-displaying the menu
                    break;
            }
       }
    }

    static void RepeatScripture()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding");

        MemorizeScripture(scripture);
    }
    static void AddNewScripture()
    {
        Console.Clear();
        Console.WriteLine("Add a New Scripture");

        Console.Write("Enter the Book Name: ");
        string book = Console.ReadLine();

        Console.Write("Enter the Chapter Number: ");
        if (!int.TryParse(Console.ReadLine(), out int chapter))
        {
            Console.WriteLine("Invalid Chapter number. Returning to menu...");
            Console.ReadLine();
            return;
        }

        Console.Write("Enter the Start Verse: ");
        if (!int.TryParse(Console.ReadLine(), out int startVerse))
        {
            Console.WriteLine("Invalid start verse. Returning to menu...");
            Console.ReadLine();
            return;
        }

        Console.Write("Enter the End Verse (or press Enter to Skip): ");
        int? endVerse = null; // Declare endVerse here
        string endVerseInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(endVerseInput) && int.TryParse(endVerseInput, out int parsedEndVerse))
        {
           endVerse = parsedEndVerse; // Assign value to endVerse if input is valid
        }

        Console.Write("Enter the Scripture Text: ");
        string scriptureText = Console.ReadLine();

        if (string.IsNullOrEmpty(scriptureText))
        {
            Console.WriteLine("Scripture text cannot be empty. Returning to menu...");
            Console.ReadLine();
            return;
        }

        // Create the new Reference and Scripture
        Reference reference = new Reference(book, chapter, startVerse, endVerse ?? startVerse);
        Scripture scripture = new Scripture(reference, scriptureText);

        MemorizeScripture(scripture);
    }

    static void MemorizeScripture(Scripture scripture)
    {
        while (!scripture.IsFullyHidden())
        {
            SafeConsoleClear(); // Clear the screen
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return; // Exit back to the menu
            }

            scripture.HideRandomWords(3);
        }

        SafeConsoleClear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Returning to the menu...");
        Console.ReadLine();
    }
    static void SafeConsoleClear()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            Console.WriteLine("[Console.Clear() not supported in this enviroment.]");
        }
    }
}
