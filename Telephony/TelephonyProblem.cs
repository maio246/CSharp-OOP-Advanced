using System;
using System.Linq;

public class TelephonyProblem
{
    public static void Main()
    {
        var numbersParams = Console.ReadLine()
            .Split()
            .ToArray();

        Smartphone phone = new Smartphone();

        for (int i = 0; i < numbersParams.Length; i++)
        {
            var currNumb = numbersParams[i];

            if (currNumb.All(n => char.IsDigit(n)))
            {
                phone.Number = currNumb;
                phone.Call();
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }

        var webSites = Console.ReadLine()
            .Split()
            .ToArray();

        for (int i = 0; i < webSites.Length; i++)
        {
            var currSite = webSites[i];

            if (!currSite.Any(c => char.IsDigit(c)))
            {
                phone.WebSite = currSite;
                phone.Browse();
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}

