using System;
using Microsoft.Win32.SafeHandles;


public class SimpleGoal : Goal
{
    //Attribute
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; // Intitially set to not complete
    }

    // RecordEvent method to mark the goal as completed
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true; // Mark as completed 
            Console.WriteLine($"You Completed goal: {_shortName}! You earned {_points} points, Congrats!");
        }
        else
        {
            Console.WriteLine($"The goal {_shortName} is already complete!");
        }
    }

    // IsComplete method to check completion status
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // GetStringRepresentation method for saving/loading goal data
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName},{_description},{_points},{_isComplete}";
    }

    // (Optional check later) Override GetDetailsString for more detailed display
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description} ({_points} points)";   
    }
}