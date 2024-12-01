using System;


public class Comment
{
    public string _name; // The person's name
    public string _text; // What they said

    // Constructor to initialize the name and text
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    // Getter for name
    public string GetName()
    {
        return _name;
    }

    // Getter for text
    public string GetText()
    {
        return _text;
    }
}