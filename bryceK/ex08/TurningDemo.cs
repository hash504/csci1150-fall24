using System;
using static System.Console;
using System.Globalization;
class TurningDemo
{
    static void Main()
    {
        
    }
}

interface ITurnable
{
    string Turn();
}

public class Page
{
    public string Turn() { return "You turn a page in a book"; }
}

public class Corner
{
    public string Turn() { return "You turn corners to go around the block"; }
}

public class Pancake
{
    public string Turn() { return "You turn a pancake when it's done on one side"; }
}

public class Leaf
{
    public string Turn() { return "A leaf turns colors in the fall"; }
}