using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage? ");
        string studentInput = Console.ReadLine() ;
        int number = int.Parse(studentInput);
        
        if (number >= 97)
        {
            Console.WriteLine("Your Grade is: A+");
        }
        else if (number >= 90)
        {
            Console.WriteLine("Your Grade is: A");
        }
        else if (number >= 87)
        {
            Console.WriteLine("Your Grade is: B+");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your Grade is: B");
        }
        else if (number >= 77)
        {
            Console.WriteLine("Your Grade is: C+");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your Grade is: C");
        }
        else if (number >= 67)
        {
            Console.WriteLine("Your Grade is: D+");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your Grade is: D");
        }
        else
        {
            Console.WriteLine("Your Grade is: F");
        }
        if (number >= 70)
        {
            Console.WriteLine("Great Job! You Have a Passing Grade!");
        }
        else
        {
            Console.WriteLine("You have a Failing Grade. Take note of your Struggles, study them and Try again! YOU CAN DO IT!!!");
        }

    }
}