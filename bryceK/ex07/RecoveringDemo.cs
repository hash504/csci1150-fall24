using System;
using static System.Console;
using System.Globalization;
class RecoveringDemo
{
    static void Main()
    {
		
    }
}

public interface IRecoverable
{
    string Recover();
}

public class Patient : IRecoverable
{
    public string Recover() { return "I am getting better"; }
}

public class Upholsterer : IRecoverable
{
    public string Recover() { return "I have new material for the couch"; }
}
public class FootballPlayer : IRecoverable
{
    public string Recover() { return "I picked up the ball after a fumble"; }
}