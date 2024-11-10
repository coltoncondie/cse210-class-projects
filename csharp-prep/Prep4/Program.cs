using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello user, Please enter a list of numbers, and when you are done press 0. ");

        List<int> numbers = new List<int>();
        int newNumber;

        do
        {
            Console.WriteLine("What number would you like to add to the list?");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                Console.WriteLine($"Number {newNumber} Successfully Added to list. ");
            }

        } while (newNumber != 0);

        Console.WriteLine("This is the List of Numbers: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The total Sum for all numbers is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average for the list is: {average}");

        int biggestNumber = numbers.Max();
        Console.WriteLine($"The Biggest number in the list is: {biggestNumber}");

    }

}