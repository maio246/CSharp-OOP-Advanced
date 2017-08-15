using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomStack<T> : IEnumerable<T>
{
    private readonly List<T> stackList;

    public CustomStack()
    {
        this.stackList = new List<T>();
    }

    public T Pop()
    {
        var result = stackList.LastOrDefault();

        if (stackList.Count == 0)
        {
            Console.WriteLine("No elements");
        }
        else
        {
            stackList.RemoveAt(stackList.Count - 1);
        }
        return result;

    }

    public void Push(T item)
    {
        this.stackList.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = stackList.Count - 1; i >= 0; i--)
        {
            yield return stackList[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

}
