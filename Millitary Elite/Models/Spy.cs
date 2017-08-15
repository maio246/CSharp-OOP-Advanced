using System;
using System.Text;

public class Spy : Soldier, ISpy
{
    public int CodeNumber { get; private set; }

    public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        var spyBuilder = new StringBuilder(base.ToString() + Environment.NewLine);
        spyBuilder.AppendLine($"Code Number: {CodeNumber}");
        return spyBuilder.ToString().Trim();
    }
}

