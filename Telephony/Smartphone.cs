using System;
using System.Linq;

public class Smartphone : IBrowseWeb, ICall
{
    private string number;
    private string webSite;

    public string WebSite
    {
        get { return this.webSite; }

        set{this.webSite = value;}
    }
    public string Number
    {
        get { return this.number; }

        set { this.number = value; }
    }

    public void Browse()
    {
        Console.WriteLine($"Browsing: {this.webSite}!");
    }

    public void Call()
    {
        Console.WriteLine($"Calling... {this.Number}");
    }
}

