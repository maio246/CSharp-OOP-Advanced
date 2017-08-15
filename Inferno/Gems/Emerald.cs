using System;

public class Emerald : IGem
{
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Vitality { get; private set; }

    public object GemQuality { get; private set; }

    public Emerald(string quality)
    {
        this.GemQuality = Enum.Parse(typeof(GemQuality), quality);
        this.Strength = 1 + (int)GemQuality;
        this.Agility = 4 + (int)GemQuality;
        this.Vitality = 9 + (int)GemQuality;
    }
}