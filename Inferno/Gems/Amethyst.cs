using System;

public class Amethyst : IGem
{
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Vitality { get; private set; }

    public object GemQuality { get; private set; }

    public Amethyst(string quality)
    {
        this.GemQuality = Enum.Parse(typeof(GemQuality), quality);
        this.Strength = 2 + (int)GemQuality;
        this.Agility = 8 + (int)GemQuality;
        this.Vitality = 4 + (int)GemQuality;
    }
}