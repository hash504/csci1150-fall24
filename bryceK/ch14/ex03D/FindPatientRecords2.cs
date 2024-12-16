using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords2
{
    static void Main()
    {
        FileStream patientFile = new FileStream("Patient.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(patientFile);

        Write("Enter minimum balance >> ");
        double minBal = Convert.ToDouble(ReadLine());
        bool patientFound = false;
        bool tabDisplayed = false;
        string recordIn = reader.ReadLine();
        while (recordIn != null)
        {
            string[] fields = recordIn.Split(',');
            Patient p = new Patient() { IdNum = fields[0], Name = fields[1], Balance = Convert.ToDouble(fields[2]) };
            if (p.Balance > minBal)
            {
                if (tabDisplayed == false) { WriteLine("IdNumber\tName\t\tBalance"); } // If a balance higher than the minimum balance is found, this tab is displayed once
                tabDisplayed = true;
                patientFound = true;
                WriteLine(p.ToString());
            }
            recordIn = reader.ReadLine();
        }
        if (patientFound == false) { WriteLine("No patients found with balance higher than " + minBal.ToString("C", CultureInfo.GetCultureInfo("en-US"))); } // If no balance higher than the minimum balance is found, this is outputted

        reader.Close();
        patientFile.Close();
    }
}

public class Patient
{
    public string IdNum { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }

    public override string ToString()
    {
        return IdNum + "\t\t" + Name + "\t\t" + Balance.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
   