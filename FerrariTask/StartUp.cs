using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();
        Ferrari ferrari = new Ferrari(input);

        Console.WriteLine($"{ferrari.Model}/{ferrari.Breaks()}/{ferrari.Gas()}/{ferrari.Driver}");

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

    }
}

