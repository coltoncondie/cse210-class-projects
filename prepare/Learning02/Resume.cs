using System;

class Resume
{
    public string _userName;

    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine("jobs:");

        foreach (Job job in _jobs)
        {

            job.Display();
        }
    }

}   
