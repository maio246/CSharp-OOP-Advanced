public class Ferrari : ICar
{
    public string Model { get; private set; }

    public string Driver { get; }

    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        Driver = driver;
    }
    public string Breaks()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }
}

