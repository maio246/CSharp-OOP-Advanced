using System;

public class TupleTask
{
    public static void Main()
    {
        //for (int i = 0; i < 3; i++)
        //{
        //    var input = Console.ReadLine();
        //
        //    var adres = input.Substring(input.LastIndexOf(" ") + 1);
        //    input = input.Substring(0, input.LastIndexOf(" "));
        //
        //    var value = input.Substring(input.LastIndexOf(" ") + 1);
        //    input = input.Substring(0, input.LastIndexOf(" "));
        //
        //    var name = input;
        //
        //    if (adres == "drunk")
        //    {
        //        adres = "True";
        //    }
        //    else if (adres == "not")
        //    {
        //        adres = "False";
        //    }
        //    Tuple<string, string, string> turple = new Tuple<string, string, string>(name, value, adres);
        //    Console.WriteLine(turple);
        //}

        var input1 = Console.ReadLine().Split();

        var name1 = input1[0] + " " + input1[1];
        var value1 = input1[2];
        var adres1 = input1[3];

        Tuple<string, string, string> turple1 = new Tuple<string, string, string>(name1, value1, adres1);
        Console.WriteLine(turple1);

        var input2 = Console.ReadLine().Split();
        var name2 = input2[0];
        var value2 = input2[1];
        var adres2 = input2[2];

        if (adres2 == "drunk")
        {
            adres2 = "True";
        }
        else if (adres2 == "not")
        {
            adres2 = "False";
        }
        Tuple<string, string, string> turple2 = new Tuple<string, string, string>(name2, value2, adres2);
        Console.WriteLine(turple2);

        var input3 = Console.ReadLine().Split();
        var name3 = input3[0];
        var value3 = double.Parse(input3[1]);
        var adres3 = input3[2];

        Tuple<string, double, string> turple3 = new Tuple<string, double, string>(name3, value3, adres3);
        Console.WriteLine(turple3);

    }
}

