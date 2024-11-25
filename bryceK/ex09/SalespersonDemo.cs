using System;
using static System.Console;
using System.Globalization;
class SalespersonDemo
{
    static void Main()
    {
        RealEstateSalesperson sp1 = new RealEstateSalesperson("John", "Doe", 600) { TotalCommissionEarned = 6600, TotalValueSold = 10000 };
        GirlScout sp2 = new GirlScout("Jenny", "Doe") { TotalBoxes = 45 };
        WriteLine(sp1.SalesSpeech());
        WriteLine(sp1.MakeSale() + "\n");
        WriteLine(sp2.SalesSpeech());
        WriteLine(sp2.MakeSale());
    }
}

interface ISellable
{
    string SalesSpeech();
    string MakeSale();
}

public abstract class Salesperson
{
    protected string firstName;
    protected string lastName;

    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }

    public Salesperson(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string GetName()
    {
        return (firstName + " " + lastName);
    }
}

public class RealEstateSalesperson : Salesperson, ISellable
{
    public RealEstateSalesperson(string firstName, string lastName, double commissionRate) : base(firstName, lastName)
    {
        CommissionRate = commissionRate;
    }

    public override string FirstName { get; set; }
    public override string LastName { get; set; }

    public int TotalValueSold { get; set; } = 0;
    public int TotalCommissionEarned { get; set; } = 0;
    public double CommissionRate { get; set; }

    public string SalesSpeech()
    {
        return "Hello sir, would you like to buy this product?";
    }
    public string MakeSale()
    {
        return (base.GetName() + "'s Sale Summary\nTotal value sold: " + TotalValueSold + "\nTotal Commission Earned: " + TotalCommissionEarned.ToString("C", CultureInfo.GetCultureInfo("en-US")) + " at a commission rate of " + CommissionRate.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}

public class GirlScout : Salesperson, ISellable
{
    public GirlScout(string firstName, string lastName) : base(firstName, lastName) { }

    public override string FirstName { get; set; }
    public override string LastName { get; set; }

    public int TotalBoxes { get; set; } = 0;

    public string SalesSpeech()
    {
        return "Wanna buy some cookies?";
    }
    public string MakeSale()
    {
        return (base.GetName() + " sold " + TotalBoxes + " boxes of cookies.");
    }
}