using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        DisplayFractionInfo(fraction1);
        DisplayFractionInfo(fraction2);
        DisplayFractionInfo(fraction3);
        DisplayFractionInfo(fraction4);

        fraction1.SetNumerator(5);
        fraction1.SetDenominator(8);
        DisplayFractionInfo(fraction1);
    }

    static void DisplayFractionInfo(Fraction fraction)
    {
        Console.WriteLine($"{fraction.GetFractionString()} = {fraction.GetDecimalValue()}");
    }
}
