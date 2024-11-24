using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Initialize the scripture and reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding");
        
        // Step 2: User interaction loop
        while (!scripture.IsFullyHidden())
        {
            Console.Clear(); // Clear the Screen
            scripture.Display(); // Display the current state of the scripture

            //Prompt the user
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break; // Exit the program
            }
            // Hide random words
            scripture.HideRandomWords(3); // Adjust the number of words to hide at a time
        }
        // Step 3: Final display
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program complete!");

    }
}
