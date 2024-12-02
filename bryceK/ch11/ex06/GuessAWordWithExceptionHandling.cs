using System;
using static System.Console;
using System.Globalization;
class GuessAWordWithExceptionHandling
{
    static void Main()
    {
        // I do not remember what the GuessAWord exercise was, nor do I know how to recreate it
        // So i just made a program that has what is wanted from the exercise instructions
        Write("Enter a letter: ");
        char guess = Convert.ToChar(ReadLine());
        try
        {
            int guessInt = (int)guess;
            if (!((guessInt >= 65 && guessInt <= 90) || (guessInt >= 97 && guessInt <= 122)))
            {
                throw new NonLetterException();
            }
            else
            {
                WriteLine(guess + " is in the word");
            }
        }
        catch (NonLetterException e)
        {
            WriteLine(guess + e.Message);
            WriteLine(guess + " is not in the word");
        }
    }
}
public class NonLetterException : Exception
{
    private static string msg = " is not a letter";
    public NonLetterException() : base(msg)
    {
    }
}