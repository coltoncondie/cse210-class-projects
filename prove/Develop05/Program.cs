using System;

class Program
{
    static void Main(string[] args)
    {
       // Create an instance of the Activity class
       Activity testActivity = new Activity("spinner Test", "This is a test of the spinner animation");
       
       // Start the activity and show the spinner
       Console.WriteLine("Start test Activity...");
       testActivity.StartMessage();

       // Simulate activity duration with the spinner
       Console.WriteLine("Spinner animation in progress...");
       testActivity.AnimatePause(5); // This will test the spinner for 5 seconds

       // End the Activity
       Console.WriteLine("Ending test Activity...");
       testActivity.EndMessage();
    }
}