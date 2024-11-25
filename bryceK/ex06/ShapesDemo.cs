using System;
using static System.Console;
using System.Globalization;
class ShapesDemo
{
    static void Main()
    {
        
    }
}

public abstract class GeometricFigure
{
    public abstract double height { get; set; }
    public abstract double width { get; set; }
    public abstract double area { get; }
    protected abstract double ComputeArea();

}

public class Rectangle : GeometricFigure {
    public override double height { get; set; }
    public override double width { get; set; }
    public override double area {
        get { return ComputeArea(); }
    }

    protected override double ComputeArea()
    {
        return height * width;
    }
}
class Square : GeometricFigure {
    public override double height { get; set; }
    public override double width { get; set; }
    public override double area
    {
        get { return ComputeArea(); }
    }

    protected override double ComputeArea()
    {
        return height * width;
    }
}
public class Triangle : GeometricFigure {
    public override double height { get; set; }
    public override double width { get; set; }
    public override double area
    {
        get { return ComputeArea(); }
    }

    protected override double ComputeArea()
    {
        return height * width * 0.5;
    }
}