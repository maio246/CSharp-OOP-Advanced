using System;
using System.Text;

public class Seat : ICar
{
    public string Model { get; private set; }
    public string Color { get; private set; }

    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }
    public override string ToString()
    {
        var seatBuilder = new StringBuilder();

        seatBuilder.AppendLine($"{this.Color} {GetType().Name} {this.Model}");
        seatBuilder.AppendLine(Start());
        seatBuilder.AppendLine(Stop());

        return seatBuilder.ToString().Trim();

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

