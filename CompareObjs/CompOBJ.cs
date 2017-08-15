using System;
using System.Collections.Generic;

public class CompOBJ
{
    public static void Main()
    {
        var peoples = new Dictionary<int, Person>();
        var counter = 1;
        string person;

        while ((person = Console.ReadLine()) != "END")
        {
            var personParams = person.Split();

            var name = personParams[0];
            var age = int.Parse(personParams[1]);
            var town = personParams[2];

            Person currPerson = new Person(name, age, town);

            peoples.Add(counter, currPerson);
            counter++;
        }
        var index = int.Parse(Console.ReadLine());
        var personToCompare = peoples[index];
        //peoples.Remove(index);

        var equal = 0;
        var notEqual = 0;

        foreach (Person currPerson in peoples.Values)
        {
            var result = personToCompare.CompareTo(currPerson);

            if (result == 0)
            {
                equal++;
            }
            else
            {
                notEqual++;
            }
        }
        var totalNumberOfPeople = equal + notEqual;
        if (equal > 1)
        {
            Console.WriteLine($"{equal} {notEqual} {totalNumberOfPeople}");
        }
        else
        {
            Console.WriteLine("No matches");            
        }
    }
}