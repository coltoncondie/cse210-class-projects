using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    // Property/Private Veriable section
    private string _name;
    private string _description;
    private int _duration;

    // Setting up constructor getter, setters
    public string Name
    {
        get {return _name;}
        set {_name = value;} 
    }

    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }

    public int Duration
    {
        get {return _duration;}
        set
        {
            if (value > 0) // Ensure duration is positive
                _duration = value;
            else
                throw new ArgumentException("Duration must be a positive number!");
        }
    }

    // Methods/functions

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {Name} activity!");
        Console.WriteLine(Description);
        Console.Write("Enter the Duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready to Start...");
        AnimatePause(3); // Pause for 3 seconds
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job! You've Completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds on {Name} activity.");
        AnimatePause(3); // Pause before returning to menu
    }

    public void AnimatePause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("<");
            Thread.Sleep(500);
            Console.Write("^b ^b"); // Clear the previous Character
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write("^b ^b"); // Clear the Previous Character
        }
        Console.WriteLine(); // Move to the next line
    }
}