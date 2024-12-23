using System;


public interface IGoalManager
{
    // Attributes
    List<Goal> Goals { get; } // Public property to expose the list of goals
    int Score { get; set;} // public property to manage the total score

    // Methods
    void Start();                       // Placeholder for starting the manager
    void DisplayPlayerInfo();           // Display score/player info
    void ListGoalNames();               // Display names of goals
    void ListGoalDetails();             // Display detailed goal info
    void CreateGoal();                  // Create a new goal
    void RecordEvent();                 // Record goal events
    void SaveGoals(string fileName);    // Save goals to a file
    bool LoadGoals(string fileName);    // Load goals from a file
}