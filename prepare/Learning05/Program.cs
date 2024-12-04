using System;

class Program
{
    
    static void Main(string[] args)
    {
       // create a base assignment and print its summary
       Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
       Console.WriteLine(assignment.GetSummary());

       Console.WriteLine(); // Add spacing between Outputs

       // Create a math assignment and print its details
       MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
       Console.WriteLine(math.GetSummary());
       Console.WriteLine(math.GetHomeworkList());

       Console.WriteLine(); // Round 2 Spacing ... Fight

       // Create a writing assignment and print its details
       WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");
       Console.WriteLine(writing.GetSummary());
       Console.WriteLine(writing.GetWritingInformation());

    }

    
}