using System;
using static System.Console;
using System.Globalization;
using System.Diagnostics;
class BookExceptionDemo
{
    static void Main()
    {
        Book[] books = new Book[2];
        for (int i = 0; i < books.Length; i++) {
            Write("Enter Book {0} title: ", i + 1);
            string title = ReadLine();
            Write("Enter Book {0} author: ", i + 1);
            string author = ReadLine();
            Write("Enter Book {0} page count: ", i + 1);
            int pages = Convert.ToInt32(ReadLine());
            Write("Enter Book {0} price: ", i + 1);
            double price = Convert.ToDouble(ReadLine());
            try
            {
                books[i] = new Book(title, author, pages, price);
            }
            catch (BookException e)
            {
                WriteLine("For " + title + e.Message + "\nPrice set to " + (pages * 0.1).ToString("C", CultureInfo.GetCultureInfo("en-US")));
                books[i] = new Book(title, author, pages, pages * 0.1);
            }
        }
        for (int i = 0; i < books.Length; i++) {
            WriteLine(books[i].ToString());
        }
            
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, int pages, double price)
    {
        Title = title; Author = author; Pages = pages;
        if (price / (double)pages > 0.1)
        {
            Price = pages * 0.1;
            throw (new BookException());
        }
        else
        {
            Price = price;
        }
    }

    public override string ToString()
    {
        return (Title + " by " + Author + "\nPrice is " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")) + " for " + Pages + " pages.\n");
    }
}

class BookException : Exception
{
    private static string msg = ", ratio is invalid.";
    public BookException() : base(msg) { }
}