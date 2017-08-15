using System;
using System.Collections.Generic;
using StrategyPattern.Comparators;

namespace StrategyPattern
{
    public class StartUp
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            var ageSorted = new SortedSet<Person>(new AgeComparator());
            var nameSorted = new SortedSet<Person>(new NameComparator());

            for (int i = 0; i < lines; i++)
            {
                var personParams = Console.ReadLine().Split();
                var person = new Person(personParams[0], int.Parse(personParams[1]));
                ageSorted.Add(person);
                nameSorted.Add(person);
            }
            Console.WriteLine(string.Join(Environment.NewLine, nameSorted));
            Console.WriteLine(string.Join(Environment.NewLine, ageSorted));

        }
    }
}
