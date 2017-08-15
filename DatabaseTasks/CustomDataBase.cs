using System;
using System.Linq;

public class CustomDatabase
{
    public int[] ints;

    public CustomDatabase()
    {
        this.ints = new int[16];
    }

    public void Add(int number)
    {
        var index = Array.FindIndex(ints, n => n == 0);

        if (index < 0 || index >= ints.Length)
        {
            throw new InvalidOperationException("Array is full!");
        }
        ints[index] = number;
    }
    public void Remove()
    {
        var index = Array.FindLastIndex(ints, n => n != 0);

        if (index < 0 || index >= ints.Length)
        {
            throw new InvalidOperationException("Array is full!");
        }
        ints[index] = 0;
    }

    public int[] Fetch()
    {
        return ints;
    }
}