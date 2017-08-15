using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecialSoldier, ICommando
{
    public List<IMissions> Missions { get; private set; }

    public void CompleteMission()
    {
    }

    public Commando(string id, string firstName, string lastName, double salary, string corp, List<IMissions> missions) : base(id, firstName, lastName, salary, corp)
    {
        this.Missions = missions;
    }

    public override string ToString()
    {
        var commandoBuilder = new StringBuilder(base.ToString() + Environment.NewLine);
        commandoBuilder.AppendLine("Missions:");
        commandoBuilder.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
        return commandoBuilder.ToString().Trim();

    }
}

