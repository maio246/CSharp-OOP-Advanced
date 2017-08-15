using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> : ICustomList<T>, IEnumerable<T>
    where T : IComparable<T>
{
    private readonly IList<T> elements;

    public IList<T> Elements { get => elements; }

    public CustomList() : this(Enumerable.Empty<T>())
    {
    }

    public CustomList(IEnumerable<T> elements)
    {
        this.elements = new List<T>(elements);
    }

    public void Add(T element) => elements.Add(element);

    public T Remove(int index)
    {
        var removed = elements[index];
        elements.RemoveAt(index);
        return removed;
    }

    public bool Contains(T element)
    {
        if (elements.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int first, int last)
    {
        var temp = elements[first];
        elements[first] = elements[last];
        elements[last] = temp;
    }

    public int CountGreaterThan(T element) => elements.Count(l => l.CompareTo(element) > 0);

    public T Max() => elements.Max();

    public T Min() => elements.Min();

   // public string Print()
   // {
   //     var listBuilder = new StringBuilder();
   //     foreach (var element in elements)
   //     {
   //         listBuilder.AppendLine(element);
   //     }
   //     return listBuilder.ToString().Trim();
   // }

    public IEnumerator<T> GetEnumerator()
    {
        return this.elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

