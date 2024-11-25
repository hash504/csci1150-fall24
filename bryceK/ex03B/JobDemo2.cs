using System;
using static System.Console;
using System.Globalization;
class JobDemo2
{
	static void Main()
	{
		Job[] jobs = new Job[5];

		for (int i = 0; i < jobs.Length; i++) {
			Write("Enter job number ");
			int num = Convert.ToInt32(Console.ReadLine());
			Write("Enter customer name ");
			string name = Console.ReadLine();
			Write("Enter job description ");
			string description = Console.ReadLine();
			Write("Enter estimated hours for job ");
			int hours = Convert.ToInt32(Console.ReadLine());
			jobs[i] = new Job { JobNumber = num, Customer = name, Description = description, Hours = hours };
		}
		Console.WriteLine("\tSummary:\t");
		for (int i = 0; i < jobs.Length; i++) {
			double sum = 0;
			sum += jobs[i].Price;
			WriteLine(jobs[i].ToString());
			if (i < jobs.Length - 1)
				WriteLine("\tTotal for all jobs is " + sum.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}
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