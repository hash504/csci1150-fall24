using System;
using static System.Console;
using System.IO;
using System.Globalization;
class WritePatientRecords
{
    static void Main()
    {
        FileStream patientFile = new FileStream("Patient.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(patientFile);
        string id = "";
        while (id != "999") {
            Write("Enter patient ID number or 999 to quit >> ");
            id = ReadLine();
            if (id != "999")
            {
                Write("Enter last name >> ");
                string ln = ReadLine();
                Write("Enter balance >> ");
                double bal = Convert.ToDouble(ReadLine());
                Patient p = new Patient() { IdNum = id, Name = ln, Balance = bal };
                writer.WriteLine(p.ToString());
            }
        }
        writer.Close();
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
        return IdNum + "," + Name + "," + Balance;
    }
}
