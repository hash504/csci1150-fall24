using System;
using static System.Console;
using System.Globalization;
class AutomobileDemo3
{
    static void Main()
    {
        FinancedAutomobile[] cars = new FinancedAutomobile[4];

        for (int i = 0; i < cars.Length; i++) {
            
            Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            // I could not find a way to check for duplicate IDs.
            Write("Enter make: ");
            string make = Console.ReadLine();
            Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Write("Enter amount financed: ");
            double amtFinanced = Convert.ToDouble(Console.ReadLine());
            while (amtFinanced > price)
            {
                WriteLine("Amount financed must not be greater than the price.");
                Write("Enter amount financed: ");
                amtFinanced = Convert.ToDouble(Console.ReadLine());
            }
            cars[i] = new FinancedAutomobile { IdNumber = id, Make = make, Year = year, Price = price, AmtFinanced = amtFinanced };
        }

        Array.Sort(cars);

        double sum = 0;
        double sumFinanced = 0;
        WriteLine("Summary:");
        for (int i = 0; i < cars.Length; i++)
        {
            WriteLine(cars[i].ToString());
            sum += cars[i].Price;
            sumFinanced += cars[i].AmtFinanced;
        }
        WriteLine("\nTotal for all Automobiles is " + sum.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("\nTotal financed all Automobiles is " + sumFinanced.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}

public class Automobile : IComparable
{
    public int IdNumber { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return (GetType() + " " + IdNumber + " " + Year + " " + Make + " Price is " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    int IComparable.CompareTo(Object o)
    {
        Automobile car = (Automobile)o;
        if (IdNumber > car.IdNumber) { return 1; }
        else if (IdNumber == car.IdNumber) { return 0; }
        else { return -1; }
    }
}

public class FinancedAutomobile : Automobile
{
    public double AmtFinanced { get; set; }

    public override string ToString()
    {
        return (base.ToString() + " Amount financed " + AmtFinanced.ToString("C", CultureInfo.GetCultureInfo("en-US")) + " Monthly payment due " + getPaymentAmount().ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    public double getPaymentAmount()
    {
        return AmtFinanced / 24;
    }
}