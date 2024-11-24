using System;


public class Word
{
    private string _word;
    private bool _isHidden;

    // Constructor
    public Word(string word)
    {
        _word = word;
        _isHidden = false; // By default, the word is not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to display the word or underscores
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length); // Return underscores matching word length
        }
        return _word; // Return the actual word
    }
}