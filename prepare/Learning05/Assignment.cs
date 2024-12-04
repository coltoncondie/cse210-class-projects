using System;


public class Assignment
{
    private string _studentName; // Private for encapsulation
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter to provide access to _studentName
    public string GetStudentName()
    {
        return _studentName;
    }
}