using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager : IGoalManager
{
    public List<Goal> Goals { get; private set; } = new List<Goal>();
    public int Score { get; set; } = 0;

    public GoalManager()
    {
        // Initialize default values if necessary
    }

    public void Start()
    {
        // Placeholder for starting the manager, if needed
        Console.WriteLine("Goal Manager started...");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {Score}");
    }

    public void ListGoalNames()
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet.");
        }
        else
        {
            for (int i = 0; i < Goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Goals[i].ShortName}");
            }
        }
    }

    public void ListGoalDetails()
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            foreach (Goal goal in Goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals to choose from are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.WriteLine("What would you like the point value to be?");
        Console.WriteLine("1. 50 points");
        Console.WriteLine("2. 75 points");
        Console.WriteLine("3. 100 points");
        int points = int.Parse(Console.ReadLine()) switch
        {
            1 => 50,
            2 => 75,
            3 => 100,
            _ => throw new ArgumentException("Invalid choice for point value.")
        };

        Goal goal;
        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("What is the target number for this goal? ");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the bonus for completing this goal?");
                Console.WriteLine("1. 500");
                Console.WriteLine("2. 750");
                Console.WriteLine("3. 1000");
                int bonus = int.Parse(Console.ReadLine()) switch
                {
                    1 => 500,
                    2 => 750,
                    3 => 1000,
                    _ => throw new ArgumentException("Invalid choice for bonus value.")
                };
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                throw new ArgumentException("Invalid goal type.");
        }

        Goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.");
            return;
        }

        Console.WriteLine("Which goal do you wish to mark as done?");
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].ShortName}");
        }

        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > Goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goals[choice - 1].RecordEvent();
        Console.WriteLine("Event recorded!");
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in Goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}");
    }

    public bool LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            return false;
        }

        Goals.Clear();
        foreach (string line in File.ReadAllLines(fileName))
        {
            // Assuming you have a method to parse goal strings
            Goal goal = ParseGoalFromString(line);
            if (goal != null)
            {
                Goals.Add(goal);
            }
        }
        return true;
    }

    private Goal ParseGoalFromString(string data)
    {
        // Implement Parsing logic based on your string representation format
        return null; // placeholder
    }
}