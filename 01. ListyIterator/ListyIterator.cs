using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> elements;
    private int currIndex;

    public ListyIterator(IEnumerable<T> elements)
    {
        this.elements = new List<T>(elements);
    }

    public bool Move()
    {
        return ++this.currIndex < this.elements.Count;
    }

    public bool HasNext()
    {
        return this.currIndex + 1 < this.elements.Count;
    }

    public void Print()
    {
        if (this.elements.Count != 0)
        {
            Console.WriteLine(this.elements[this.currIndex]);
        }
        else
        {
            Console.WriteLine("Invalid Operation!");
        }
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() =>  this.GetEnumerator();
}

