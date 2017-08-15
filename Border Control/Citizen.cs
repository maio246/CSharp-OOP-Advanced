public class Citizen : IHabitant, IBuyer
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get; private set; }
    public string Birthdate { get; private set; }
    public int Food { get; private set; }

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.Birthdate = birthdate;
    }

    public void BuyFood()
    {
        Food += 10;
    }
}

