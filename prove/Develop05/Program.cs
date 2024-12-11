using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Select an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Please make your selection here: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RunBreathingActivity();
                    break;

                case "2":
                    RunReflectionActivity();
                    break;

                case "3":
                    RunListingActivity();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness program. Keep us in Mind, Goodbye...");
                    return;
            
                default:
                    Console.WriteLine("Invalid Choice. Please select a valid option.");
                    PauseBeforeContinuing();
                    break;
            }
        }
    }

    private static void RunBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.PerformActivity();
        PauseBeforeContinuing();
    }

    private static void RunReflectionActivity()
    {
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.PerformActivity();
        PauseBeforeContinuing();
    }

    private static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.PerformActivity();
        PauseBeforeContinuing();
    }

    private static void PauseBeforeContinuing()
    {
        Console.WriteLine("\nPress Enter to Return to Menu...");
        Console.ReadLine();
    }
}