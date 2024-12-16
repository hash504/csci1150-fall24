using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords
{
    static void Main()
    {
        FileStream patientFile = new FileStream("Patient.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(patientFile);

        Write("Enter patient ID number to find >> ");
        string id = ReadLine();

        bool idFound = false;
        string recordIn = reader.ReadLine();
        while (recordIn != null)
        {
            string[] fields = recordIn.Split(',');
            Patient p = new Patient() { IdNum = fields[0], Name = fields[1], Balance = Convert.ToDouble(fields[2]) };
            if (p.IdNum == id)
            {
                idFound = true;
                WriteLine("IdNumber\tName\t\tBalance");
                WriteLine(p.ToString());
            }
            recordIn = reader.ReadLine();
        }
        if (idFound == false) { WriteLine("No records found for " + id); }

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
