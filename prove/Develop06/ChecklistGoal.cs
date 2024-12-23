using System;


public class ChecklistGoal : Goal
{
    // Attributes specific to ChecklistGoal
    private int _amountCompleted; // Track progress
    private int _target;          // Total number required to complete the goal
    private int _bonus;           // Bonus points for completeing the goal

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0; // Initialize as incomplete
        _target = target;
        _bonus = bonus;
    }

    // RecordEvent method
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded for: {_shortName}. You earned {_points} points, Congrats!");
        
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You've completed {_shortName} and earned a bonus of {_bonus} points!");
        }
    }

    // IsComplete method
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // GetDetailsString method for displaying goal information
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description} (Completed {_amountCompleted}/{_target}, {_points} points each, {_bonus} bonus on completion)";
    }

    // GetStringRepresentation method for saving/loading goal data
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}