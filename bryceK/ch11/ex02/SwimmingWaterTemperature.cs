using System;
using static System.Console;
using System.Globalization;
class SwimmingWaterTemperature
{
    static void Main()
    {
        int value = -1;
        bool isComfortable = false;
        while (value != 999)
        {
            try
            {
                Write("Enter a temperature value between 32 and 212, or enter 999 to exit: ");
                value = Convert.ToInt32(ReadLine());
                isComfortable = TemperatureCheck(value);
                if (isComfortable)
                    WriteLine("{0} degrees is comfortable for swimming.", value);
                else
                    WriteLine("{0} degrees is not comfortable for swimming.", value);
            }
            catch (ArgumentException e)
            {
                if (value != 999)
                    WriteLine(e.Message);
            }
        }
        

    }

    public static bool TemperatureCheck(int temp)
    {
        if (temp >= 70 && temp <= 85)
        {
            return true;
        }
        else if (temp >= 32 && temp <= 212)
        {
            return false;
        }
        else
        {
            throw new ArgumentException("Value does not fall within the expected range.");
        }
    }
}