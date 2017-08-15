using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Battery { get; private set; }

    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public override string ToString()
    {
        var teslaBuilder = new StringBuilder();

        teslaBuilder
            .AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
        teslaBuilder.AppendLine(Start());
        teslaBuilder.AppendLine(Stop());

        return teslaBuilder.ToString().Trim();
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }
}

