using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    // Property/Private Veriable section
    private string _name;
    private string _description;
    private int _duration;

    //Parameterless constructor
    public Activity()
    {
        _name = "Default Name";
        _description = "Default Description";
        _duration = 0; // Initialize with default duration
    }

    // parameterized Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0; // Initialize with default duration
    }

    // Properties with encapsulation
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public int Duration
    {
        get => _duration;
        set
        {
            if (value > 0) // Ensure a positive duration
                _duration = value;
            else
                throw new ArgumentException("Duration must be a positive number!");
        }
    }

    // Methods/functions
    // Start Message
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {Name} activity!");
        Console.WriteLine(Description);

        Console.Write("Enter the Duration (in seconds): ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
            {
                Duration = input;
                break;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        Console.WriteLine("Get ready to start...");
        AnimatePause(3); // 3-second pause
    }
    // End Message
    public void EndMessage()
    {
        Console.WriteLine("Good job! You've Completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds on {Name} activity.");
        AnimatePause(3); // Pause before returning to menu
    }

    public void AnimatePause(int seconds)
    {
        string[] spinner = { "<", "^", ">", "v"}; // My Custom spinner if I wish to change the look all I need to change is this list
        int iterations = seconds * 4; // 4 symbols per second or 1 every 250ms 
        for (int i = 0; i < iterations; i++)
        {
            Console.Write(spinner[i % spinner.Length]); // Display the current spinner character
            Thread.Sleep(250); // pause for 250 micro seconds
            Console.Write("\b \b"); // Erase the spinner character (backspace + overite with space) and or keep symbols in same place
        }
        Console.WriteLine(); // Move to the next line after the spinner
    }
}