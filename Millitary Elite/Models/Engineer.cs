using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialSoldier
{
    public List<IRepair> Repairs { get; }

    public Engineer(string id, string firstName, string lastName, double salary, string corp, List<IRepair> repairs) : base(id, firstName, lastName, salary, corp)
    {
        this.Repairs = repairs;
    }

    public override string ToString()
    {
        var engineerBuilder = new StringBuilder(base.ToString() + Environment.NewLine);
        engineerBuilder.AppendLine("Repairs:");
        engineerBuilder.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Repairs)}");


        return engineerBuilder.ToString().Trim();
    }

}

