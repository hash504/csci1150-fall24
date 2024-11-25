using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
    static void Main()
    {
        Photo p1 = new MattedPhoto() { Width = 8, Height = 10, Color = "Silver" };
        WriteLine(p1.ToString());
        Photo p2 = new FramedPhoto() { Width = 10, Height = 12, Material = "Silver", Style = "Modern" };
        WriteLine(p2.ToString());
    }
}
public class Photo
{
    private double width;
    private double height;
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
            setPrice();
        }
    }
    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
            setPrice();
        }
    }
    protected double price;

    public double getPrice()
    {
        return price;
    }

    protected virtual void setPrice()
    {
        if (Width == 8 && Height == 10)
            price = 3.99;
        else if (Width == 10 && Height == 12)
            price = 5.99;
        else
            price = 9.99;
    }

    public override string ToString()
    {
        return (GetType() + "\t" + Width + " X " + Height + "\t" + "Price: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}

public class MattedPhoto : Photo
{
    public string Color { get; set; }

    protected override void setPrice()
    {
        base.setPrice();
        price += 25;
    }

    public override string ToString()
    {
        return (GetType() + "\t" + Color + " matting\t" + Width + " X " + Height + "\t" + "Price: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}

public class FramedPhoto : Photo
{
    public string Material { get; set; }
    public string Style { get; set; }
    protected override void setPrice()
    {
        base.setPrice();
        price += 25;
    }

    public override string ToString()
    {
        return (GetType() + "\t" + Style + ", " + Material + " frame\t" + Width + " X " + Height + "\t" + "Price: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}