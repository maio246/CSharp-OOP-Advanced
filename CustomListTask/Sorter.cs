using System;
using System.Linq;

public class Sorter
{
    public static CustomList<T> Sort<T>(CustomList<T> list) 
        where T : IComparable<T>
    {
        var result = list.Elements.OrderBy(e => e);
        return new CustomList<T>(result);
    }
}

