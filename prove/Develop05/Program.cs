using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Activity Class...");

        //Create an instance of the Activity Class
        Activity testActivity = new Activity("Test Activity", "This is a test description.");

        // Test the StartMessage method
        Console.WriteLine("Testing StartMessage...");
        testActivity.StartMessage();

        // Pause to observe
        Console.WriteLine("Did the StartMessage display correctly? (y/n)");
        string response = Console.ReadLine();
        if (response.ToLower() != "y")
        {
            Console.WriteLine("Check your StartMessage logic!");
        }

        //Test the AnimatePause Method
        Console.WriteLine("Testing AnimatePause...");
        testActivity.AnimatePause(5); // Pretend the activity was 5 seconds

        // Test the EndMessage Method
        Console.WriteLine("Testing EndMessage...");
        testActivity.EndMessage(); // pretend the activity was 5 seconds

        // Pause for feedback
        Console.WriteLine("Did everything work as expected? (y/n)");
        response = Console.ReadLine();
        if (response.ToLower() != "y")
        {
            Console.WriteLine("Debug the methods to find the issue.");
        }
        else
        {
            Console.WriteLine("Activity class passed all tests!");
        }

    }
}