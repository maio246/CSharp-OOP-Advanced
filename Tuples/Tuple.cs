public class Tuple<T, U, V>
{
    public T item1;
    public U item2;
    public V item3;

    public Tuple(T item1, U item2, V item3)
    {
        this.item1 = item1;
        this.item2 = item2;
        this.item3 = item3;
    }

    public override string ToString()
    {
        return $"{item1} -> {item2} -> {item3}";
    }
}

