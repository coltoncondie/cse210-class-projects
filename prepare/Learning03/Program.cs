using System;

class Program
{
    static void Main(string[] args)
    {
        //Test the no parameter constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString()); // The output Should be 1/1
        Console.WriteLine(fraction1.GetDecimalValue()); //The output should be 1.0

        //Test the Single Parameter Constructor
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString()); // The outout should be 5/1
        Console.WriteLine(fraction2.GetDecimalValue());  // The output should be 5.0
        
        //Test the two parameter Constructor
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());  // The output should be 3/4
        Console.WriteLine(fraction3.GetDecimalValue());  // The output should be 0.75

        //Test The setters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine(fraction3.GetFractionString());  // The output should be 1/3
        Console.WriteLine(fraction3.GetDecimalValue());  // The output should be 0.33333...


    }
}