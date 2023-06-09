using System;

public class Fraction
{
    private int _top;     // Private attribute for the numerator
    private int _bottom;  // Private attribute for the denominator

    // Default constructor that sets the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that sets the fraction to a whole number (numerator/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that sets the fraction to a specific numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Method to get the fraction representation as a string (e.g., "numerator/denominator")
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
