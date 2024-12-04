using System;


public class WritingAssignment : Assignment
{
    
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;

    }
    public string GetWritingInformation()
    {
        // I had to use GetStudentName Getter to make it work correctly.
        return$"{_title} by {GetStudentName()}";
    }
}