using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); //Creating Journal instance
        PromptGenerator promptGenerator = new PromptGenerator(); //creating PromptGenerator instance
        bool running = true;

        //Display Welcome
        Console.WriteLine("=========================================");
        Console.WriteLine("          Welcome To, My Journal         ");
        Console.WriteLine("=========================================");
        Console.WriteLine();

        while (running)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would tou like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Add a new Journal Entry
                    //Generate a random prompt using the PromptGenerator
                    string randomPrompt = promptGenerator.GetRandomPrompt();

                    //Display the prompt and collect the response
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your Response: ");
                    string response = Console.ReadLine();

                    //Create a new journal entry and add it to the journal
                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(new Entry(date, randomPrompt, response));
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    //Display the journal
                    journal.DisplayAll();
                    break;

                case "3":
                    //Save the journal
                    Console.Write("Enter a filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    //Load the Journal
                    Console.Write("Enter a filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "5":
                    //Quit
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}