using System;
using static System.Console;
using System.Globalization;
class StudentGradeDemo
{
    static void Main()
    {
        try
        {
            ReportCard c1 = new ReportCard("John", 86, 89);
            WriteLine("{0}'s final letter grade is {1}", c1.getName(), c1.getLetterGrade());
        }
        catch (ArgumentException e)
        {
            WriteLine(e.Message);
        }
        
    }
}

public class ReportCard
{
    private string name;
    private int midtermGrade;
    private int finalGrade;
    private char letterGrade;

    public ReportCard(string name, int midtermGrade, int finalGrade)
    {
        this.name = name;
        

        if (midtermGrade < 0 || midtermGrade > 100 || finalGrade < 0 || midtermGrade > 100)
        {
            throw new ArgumentException("Error: Grade is < 0 or > 100.");
        }
        else
        {
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
            double avgGrade = (double)(midtermGrade + finalGrade) / 2;
            if (avgGrade >= 90)
                this.letterGrade = 'A';
            else if (avgGrade >= 80)
                this.letterGrade = 'B';
            else if (avgGrade >= 70)
                this.letterGrade = 'C';
            else if (avgGrade >= 60)
                this.letterGrade = 'D';
            else if (avgGrade < 60)
                this.letterGrade = 'F';
        }
    }

    // The below methods are for displaying name and letter grade
    public string getName() { return name; }
    public char getLetterGrade() { return letterGrade; }
}