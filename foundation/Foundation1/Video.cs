using System.Collections.Generic;


public class Video
{
    private string _title; // video's title
    private string _author; // Creator of the video
    private int _lengthInSec; // Video's length in seconds
    private List<Comment> _comments; // List of comments on the video


    // Constructor to initialize video attributes
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSec = length;
        _comments = new List<Comment>(); // Initialize the comments list
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    
    //Method to get the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Getter for title
    public string GetTitle()
    {
        return _title;
    }

    // Getter for the author
    public string GetAuthor()
    {
        return _author;
    }

    // Getter for length in seconds
    public int GetLengthInSeconds()
    {
        return _lengthInSec;
    }
}