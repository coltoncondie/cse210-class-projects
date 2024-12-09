using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // This Constructor is to set the name and description
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you to relax by guiding you through slow Breathing. So take a moment clear your mind and focus only on your inhale and exhale.")
    {
    }

    // This is the method to run the Breathing Activity
    public void RunActivity()
    {
        // Display the StartMessage
        StartMessage();

        Console.WriteLine(); // Adding space for better legability
        Console.WriteLine("Let's get started...");
        Console.WriteLine();

        // Calculate the end time based on the Duration
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        // This will loop until the time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in deeply and slowly, focus on the feeling and sound of your breath...");
            AnimatePause(5); // This will pause for 3 seconds
            Console.Write("\r     \r"); // This will clear the line for a clear display

            Console.Write("Breath out smooth and slow, as you breath out push all thoughts out with it...");
            AnimatePause(5); // Another pause for 3 seconds
            Console.Write("\r     \r"); // clear the line for a clean finish
        }

        // Display the EndMessage
        EndMessage();
    }
}