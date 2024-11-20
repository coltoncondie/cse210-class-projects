using System;

public class Fraction
{
    //The private Variables to store the numerator (or top) and denominator (or bottom).
    private int _numerator;
    private int _denominator;

    //Constructor (no parameter)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    //Constructor (single parameter) Sample 5 would become 5/1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    //Constructor (two parameter) Sample if input 3 and 4 would get 3/4
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    //Adding the getters and setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }
    //Adding Methods for Representations for Fraction and Decimal
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}