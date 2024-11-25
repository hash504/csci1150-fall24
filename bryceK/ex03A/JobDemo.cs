using System;
using static System.Console;
using System.Globalization;
class JobDemo
{
    static void Main()
    {
        
    }
}

public class Job
{
    public int JobNumber { get; set; }
    public string Customer { get; set; }
    public string Description { get; set; }

    private double hours;
    public double Hours
    {
        get { return hours; }
        set {
            hours = value;
            setPrice();
        }
    }

    private double price;
    public double Price
    {
        get { return price; }
    }

    private void setPrice()
    {
        price = hours * 45;
    }

    public override bool Equals(Object o)
    {
        Job job = (Job)o;
        if (JobNumber == job.JobNumber)
            return true;
        else
            return false;
    }

    public override int GetHashCode()
    {
        return JobNumber;
    }

    public override string ToString()
    {
        return (GetType() + " " + JobNumber + " " + Customer + " " + Description + " " + Hours + " hours @$45.00 per hour. Total price is " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}