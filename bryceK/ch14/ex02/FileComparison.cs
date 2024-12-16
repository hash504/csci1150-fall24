using System;
using static System.Console;
using System.IO;
class FileComparison
{
    static void Main()
    {
        // I put Quote.docx and Quote.txt in the file location that Visual Studio reads for file paths, which is ex02\ex02\bin\Debug\net8.0
        // Also, i created my own Quote.docx and Quote.txt files
        FileInfo docxInfo = new FileInfo("Quote.docx");
        FileInfo txtInfo = new FileInfo("Quote.txt");
        WriteLine("The size of the Word file is {0}", docxInfo.Length);
        WriteLine("The size of the Notepad file is {0}", txtInfo.Length);
        double sizeComparison = (Convert.ToDouble(txtInfo.Length) / Convert.ToDouble(docxInfo.Length));
        WriteLine("The notepad file is {0} of the size of the Word file", sizeComparison.ToString("0.###%"));
    }
}