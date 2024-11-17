using System;

public class Entry
{
    // Public Properties with Auto Getters and Setters
    public string Date{ get; set; }
    public string Prompt{ get; set;}
    public string Response{ get; set;}
    // Constructor to initialize an entry
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // The Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine(); // Blank line for readability
    }
}