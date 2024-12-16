using System;
using System.IO;
using static System.Console;
using System.Globalization;
class ReadPatientRecords
{
    static void Main()
    {
        FileStream patientFile = new FileStream("Patient.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(patientFile);
        WriteLine("IdNumber\tName\t\tBalance");
        string recordIn = reader.ReadLine();
        while (recordIn != null) {
            string[] fields = recordIn.Split(',');
            Patient p = new Patient() { IdNum = fields[0], Name = fields[1], Balance = Convert.ToDouble(fields[2]) };
            WriteLine(p.ToString());
            recordIn = reader.ReadLine();
        }
        reader.Close();
        patientFile.Close();
    }
}

public class Patient // I hope altering the Patient class to be suitable for formatting for file reading but not writing is an acceptable solution
{
    public string IdNum { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }

    public override string ToString()
    {
        return IdNum + "\t\t" + Name + "\t\t" + Balance.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
   

