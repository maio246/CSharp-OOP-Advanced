using System;
using System.Collections.Generic;
using System.Text;

public class Box<T> where T : IComparable<T>
{
    private T[] elements;

    public Box(int length)
    {
        elements = new T[length];
    }
    public void Add(int index, T element)
    {
        elements[index] = element;
    }

    public int GetCount(List<T> list, T element)
    {
        var count = 0;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }

    public void Swap(int first, int last)
    {
        var temp = elements[first];
        elements[first] = elements[last];
        elements[last] = temp;
    }

    public override string ToString()
    {
        var elementsBuilder = new StringBuilder();
        foreach (var element in elements)
        {
            elementsBuilder.AppendLine($"{element.GetType().FullName}: {element}");
        }
        return elementsBuilder.ToString().Trim();
    }

}

