using System.Collections.Generic;
    public class InspectCommand : Command
    {
        public InspectCommand(List<string> argsList, IManager manager) : base(argsList, manager)
        {
            
        }
        public override string Execute()
        {
            return Manager.Inspect(ArgsList);
        }
    }