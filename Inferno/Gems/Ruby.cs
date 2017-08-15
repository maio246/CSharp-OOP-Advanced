using System;

public class Ruby : IGem
{
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Vitality { get; private set; }

    public object GemQuality { get; private set; }

    public Ruby(string quality)
    {
        this.GemQuality = Enum.Parse(typeof(GemQuality), quality);
        this.Strength = 7 + (int)GemQuality;
        this.Agility = 2 + (int)GemQuality;
        this.Vitality = 5 + (int)GemQuality;
    }
}