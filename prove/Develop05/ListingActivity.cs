using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _shuffledPrompts;
    private int _currentPromptIndex;

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you by listing as many things as you can to a given prompt.";
        _prompts = new List<string>
        {
            "Who are the people you admire?",
            "What are your personal strengths?",
            "What are things you are grateful for?",
            "What are moments in life that brought you joy?",
            "What are goals you want to achieve?",
            "What are hobbies you enjoy?",
            "What are acts of Kindness you've recieved or done?",
            "What are things you've done that make you laugh?",
            "What are some things that bring a smile to your face?",
            "What are thing that make you cry because of happiness?",
            "What dreams inspire you to be great?",
            "Who are some people you love?",
            "Who inspired you to dream?",
            "Who made you feel important?",
            "What songs make you want to get up and dance?"
        };
        _shuffledPrompts = new List<string>(_prompts);
        ShuffleList(_shuffledPrompts);
        _currentPromptIndex = 0;
    }

    private void ShuffleList(List<string> list)
    {
        Random random = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    private string GetNextPrompt()
    {
        if (_currentPromptIndex >= _shuffledPrompts.Count)
        {
            ShuffleList(_shuffledPrompts);
            _currentPromptIndex = 0;
        }
        return _shuffledPrompts[_currentPromptIndex++];
    }

    public void PerformActivity()
    {
        StartMessage();

        //Get the next prompt
        string prompt = GetNextPrompt();
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin listing your responses. Press Enter after each response.");
        Console.WriteLine("When you are ready, press Enter to start");
        Console.ReadLine();

        // The timer for the activity
        _userResponses.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _userResponses.Add(response);
            }
        }
        Console.WriteLine($"You listed {_userResponses.Count} items. Great Work!");

        EndMessage();
    }

    private List<string> _userResponses = new List<string>();
}