using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int magicNum = randomGen.Next(1, 101);
        
        int guessNum = -1;
        Console.WriteLine("Welcome Player, This is Magic NuMbEr! The name of the game is to guess the Auto generated number. Good Luck! ");

        while (guessNum != magicNum)
        {    
            Console.WriteLine("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());
            if (magicNum > guessNum)
            {
                Console.WriteLine("Bigger");
            }
            else if (magicNum < guessNum)
            {
                Console.WriteLine("smaller");
            }
            else
            {
                Console.WriteLine("Congrats That is the Magic number!");
            }
        }       
    }
}