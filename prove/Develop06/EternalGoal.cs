using System;
using System.Net.NetworkInformation;
// I feel like this class is incorrect in tracking points I will fix later note to self.
public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        // No additional attributes needed
    }

    // RecordEvent method to log progress
    public override void RecordEvent()
    {
        Console.WriteLine($"You made progress on the Eternal goal: {_shortName}! You earned {_points} points, Congrats!");
    }

    // IsComplete method always returns false since these goals are never completed
    public override bool IsComplete()
    {
        return false; // Eternal goals are never "complete"
    }

    // GetStringRepresentation method for saving/loading goal data
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";   
    }

    // (Optional) Override GetDetailsString for better display
    public override string GetDetailsString()
    {
        return $"[E] {_shortName}: {_description} ({_points} points per record)";   
    }
}