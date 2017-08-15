using System;
public class Person : IComparable<Person>
{
    private string name;
    private int age;
    private string town;

    public Person(string name, int age, string town)
    {
        this.name = name;
        this.age = age;
        this.town = town;
    }
    public int CompareTo(Person other)
    {
        var result = this.name.CompareTo(other.name);

        if (result == 0)
        {
            if (this.age.Equals(other.age))
            {
                if (this.town.CompareTo(other.town) == 0)
                {
                    result = 0;
                }
            }
        }
        return result;
    }
}