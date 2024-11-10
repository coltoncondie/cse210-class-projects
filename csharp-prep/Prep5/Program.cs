using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        
        {
            DisplayMessage();
            string username = GetUserName();
            int favoriteNumber = GetFavoriteNumber();
            int squaredNumber = SquareNumber(favoriteNumber);
            DisplayResult(username, squaredNumber);
        }
        
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string GetUserName()
        {
            Console.Write("Please enter your Username here: ");
            string username = Console.ReadLine();
            return username;
        }
        static int GetFavoriteNumber()
        {
            Console.Write("Please enter your favorite number here: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string username, int squaredNumber)
        {
            Console.WriteLine($"{username}, your favorite number squared is: {squaredNumber}");
        }
        

    }
}