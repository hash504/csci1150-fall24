using System;
using static System.Console;
using System.Globalization;
class SubscriptExceptionTest
{
    static void Main()
    {
        double[] array = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10};
        int value = -1;
        try
        {
            while (value != 99)
            {
                Write("Enter a subscript or 99 to exit: ");
                value = Convert.ToInt32(ReadLine());
                WriteLine(array[value]);
            }
        }
        catch (IndexOutOfRangeException e)
        {
            if (value != 99)
                WriteLine(e.Message);
        }
    }
}