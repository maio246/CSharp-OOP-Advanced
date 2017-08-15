using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        List<Citizen> citizens = new List<Citizen>();
        List<Rebel> rebels = new List<Rebel>();

        var numberOfPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPeople; i++)
        {
            var habitantTokens = Console.ReadLine().Split();

            if (habitantTokens.Length == 3)
            {
                Rebel rebel = new Rebel(habitantTokens[0], int.Parse(habitantTokens[1]), habitantTokens[2]);
                rebels.Add(rebel);
            }
            if (habitantTokens.Length == 4)
            {
                Citizen citizen = new Citizen(habitantTokens[0], int.Parse(habitantTokens[1]), habitantTokens[2], habitantTokens[3]);
                citizens.Add(citizen);
            }
        }

        string buyer;
        List<string> names = new List<string>();
        while ((buyer = Console.ReadLine()) != "End")
        {
            names.Add(buyer);
        }

        BuyFood(citizens, names);

        Console.WriteLine();
    }

    private static void BuyFood(List<Citizen> citizens, List<string> names)
    {
        foreach (var citizen in citizens)
        {
            foreach (var name in names)
            {

            }
        }
    }
}
