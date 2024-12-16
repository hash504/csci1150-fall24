using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
    static void Main()
    {
        string dirName = "";
        while (dirName != "end")
        {
            Write("Enter a directory name or end to exit >> ");
            dirName = ReadLine();
            if (dirName != "end")
            {
                if (Directory.Exists(dirName))
                {
                    string[] dirFiles = Directory.GetFiles(dirName);
                    WriteLine("{0} contains the following files", dirName);
                    for (int i = 0; i < dirFiles.Length; i++)
                    {
                        WriteLine("\t" +  dirFiles[i]);
                    }
                }
                else
                {
                    WriteLine("Directory {0} does not exist", dirName);
                }
            }
        }
    }
}