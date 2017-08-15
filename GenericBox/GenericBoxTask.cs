using System;
using System.Collections.Generic;
using System.Linq;

public class GenericBoxTask
{
    public static void Main()
    {
        var boxes = int.Parse(Console.ReadLine());

        Box<double> box = new Box<double>(boxes);

        var elements = new List<double>();

        for (int i = 0; i < boxes; i++)
        {
            elements.Add(double.Parse(Console.ReadLine()));
        }
        var comparer = double.Parse(Console.ReadLine());//.Split().Select(int.Parse).ToArray();
        
        Console.WriteLine(box.GetCount(elements, comparer));
    }
}
