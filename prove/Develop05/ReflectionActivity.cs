using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Queue<string> _shuffledPrompts; // This queue shuffles the prompts to make it so they are random but does not repeat until list is complete
    private Queue<string> _shuffledQuestions; // This queue shuffles the Questions just like my previous comment.

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you to recognize the power you have and how you can use it in other aspects of your life. Please take the first step now and drop your personal judgement and open yourself to the posibility you are something more.";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone esle.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you stepped out of your comfort zone and did something truly good and unexpected.",
            "Think of a time when you were pushed into something you did not want to do but succeeded",
            "Think of a time when you volunteered for something you got nothing in return.",
            "Think of a time when you felt fear and showed strength and faced it.",
            "Think of a time when you felt alone, that you didn't matter and choose to share that pain.",
            "Think of a time when you felt light and love as if you were next to God, or on a mountain far above the world, or with someone you love.",
            "Think of a time when you let someone care for you.",
            "Think of a time when you met your Demon and won."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningfull to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "Did you give it everything you had?",
            "What if you failed, could you still find strength in hope?",
            "How did you accomplish it and if so did you grow?"
        };

        // Initialize shuffled queues
        _shuffledPrompts = ShuffleList(_prompts);
        _shuffledQuestions = ShuffleList(_questions);
    }

    public void PerformActivity()
    {
        StartMessage();

        Console.WriteLine("Consider the following Prompt: ");
        Console.WriteLine($"--- {GetNextPrompt()} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, reflect on the following question: ");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {GetNextQuestion()}");
            AnimatePause(4); // Adjust if more time is needed between prompts or less
        }

        EndMessage();
    }

    private Queue<string> ShuffleList(List<string> list)
    {
        var random = new Random();
        var shuffledList = new List<string>(list);
        for (int i = 0; i < shuffledList.Count; i++)
        {
            int j = random.Next(i, shuffledList.Count);
            (shuffledList[i], shuffledList[j]) = (shuffledList[j], shuffledList[i]);
        }
        return new Queue<string>(shuffledList); // Convert the shuffled list to queue
    }

    private string GetNextPrompt()
    {
        if (_shuffledPrompts.Count == 0)
            _shuffledPrompts = ShuffleList(_prompts); // This will reshuffle the prompts when it has gone through the list

        return _shuffledPrompts.Dequeue();
    }

    private string GetNextQuestion()
    {
        if (_shuffledQuestions.Count == 0)
            _shuffledQuestions = ShuffleList(_questions); // This will reshuffle the questions when it has gone through the list

        return _shuffledQuestions.Dequeue();
    }
}