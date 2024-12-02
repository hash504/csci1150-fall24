using System;
using static System.Console;
using System.Globalization;
class FindSquareRoot
{
    static void Main()
    {
        double sqrt;
        try
        {
            Write("Enter a number ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num >= 0)
                sqrt = Math.Sqrt(num);
            else
                throw new ApplicationException("Error: Number can't be negative.");
        }
        catch (FormatException e)
        {
            WriteLine(e.Message);
            sqrt = 0;
            
        }
        catch (ApplicationException e)
        {
            WriteLine(e.Message);
            sqrt = 0;
        }
        WriteLine("Square root is {0}", sqrt);
    }
}