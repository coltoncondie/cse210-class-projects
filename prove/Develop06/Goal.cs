using System;


public abstract class Goal
{
    // Attributes
    protected string _shortName; // The short name of the goal
    protected string _description; // Description of the goal
    protected int _points; // Points awarded for completing the goals

    // Constructor
    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // methods
    public abstract void RecordEvent(); // Records the Completion of the goal
    public abstract bool IsComplete(); // Checks if the goal is complete
    public virtual string GetDetailsString() // Returns goal details
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }
    public abstract string GetStringRepresentation(); // For saving/loading goal data
}