using System;
using static System.Console;
using System.Globalization;
class CookieDemo
{
    static void Main()
    {
        SpecialCookieOrder order = new SpecialCookieOrder() { OrderNum = 15, Name = "Bryce", Dozens = 3 , CookieType = "Chocolate Chip", Description = "Sugar-Free"};
        WriteLine("Order #" + order.OrderNum + "\t" + order.Name + "\n   type: " + order.Description + " " + order.CookieType + "\n   " + order.Dozens + " dozen --- $" + order.Price);
    }
}

public class CookieOrder
{
    public int OrderNum { get; set; }
    public string Name { get; set; }
    public string CookieType { get; set; }
    private int dozens;
    public int Dozens {
        get { return dozens; }
        set
        {
            dozens = value;
            setPrice();
        }
    }
    private int price;
    public int Price
    {
        get { return price; }
        protected set {  price = value; }
    }

    protected virtual void setPrice()
    {
        if (Dozens <= 2)
            price = 15 * Dozens;
        else
        {
            price = 30 + (13 * (Dozens - 2));
        }
    }
}

public class SpecialCookieOrder : CookieOrder
{
    public string Description { get; set; }
    protected override void setPrice()
    {
        base.setPrice();
        if (Price <= 40)
            Price += 10;
        else
            Price += 8;
    }
}