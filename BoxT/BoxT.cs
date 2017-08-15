using System;

public class Program
{
    public static void Main()
    {
        var box1 = new Box<int>();

        box1.Add(30);
        Console.WriteLine(box1.Remove());
    }
}

