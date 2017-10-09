using System.Collections.Generic;

public class QuitCommand : Command
{
    public QuitCommand(List<string> argsList, IManager manager) : base(argsList, manager)
    {
        
    }
    public override string Execute()
    {
        return base.Manager.Quit();
    }
}