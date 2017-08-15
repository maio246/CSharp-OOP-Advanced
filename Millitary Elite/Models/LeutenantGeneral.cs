using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public List<ISoldier> Privates { get; private set; }

    public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<ISoldier> privates) : base(id, firstName, lastName, salary)
    {
        this.Privates = privates;
    }

    public override string ToString()
    {
        var leutenantBuilder = new StringBuilder(base.ToString() + Environment.NewLine);
        leutenantBuilder.AppendLine("Privates:");
        leutenantBuilder.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");
        //foreach (var personPrivate in Privates)
        //{
        //    leutenantBuilder.AppendLine(personPrivate.ToString());
        //}
        return leutenantBuilder.ToString().Trim();
    }
}