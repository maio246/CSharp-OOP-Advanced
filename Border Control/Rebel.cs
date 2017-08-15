public class Rebel : IBuyer
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    private string group;
    public int Food { get; private set; }

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public string Group
    {
        get { return this.group; }
        set { this.group = value; }
    }

    public void BuyFood()
    {
        Food += 5;
    }
}

