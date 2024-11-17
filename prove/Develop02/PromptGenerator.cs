using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PromptGenerator
{
        
     private List<string> _prompts = new List<string>
     {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Was there someone who impressed you today with their kindness?",
        "Did you feel the Spirit today, why?",
        "Was there a moment today that you wish gone another way?",
        "Did you do your best today to be a deciple of Christ?",
        "Are you having a ruff day, could you turn it around?"
     };

     public string GetRandomPrompt()
     {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
     }
        
    
   
}