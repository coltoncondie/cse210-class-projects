using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to display the scripture
    public void Display()
    {
        Console.WriteLine(_reference.GetFormattedReference()); // Show the reference

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " "); // Show each word with spaces
        }
        Console.WriteLine(); // Move to the next line
    }
    // Method to hide a random number of words
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count); // Get a random index
            if (!_words[index].GetDisplayText().Contains("_")) // Only hide visible words
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    // Method to check if all words are hidden
    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetDisplayText().Contains("_")) // If any word is visible
            {
                return false;
            }
        }
        return true;
    }
}