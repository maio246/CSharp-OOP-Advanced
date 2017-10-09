    using System.Collections.Generic;

public class HeroCommand : Command
    {
        public HeroCommand(List<string> argsList, IManager manager) : base(argsList, manager)
        {

        }
        public override string Execute()
        {
            return Manager.AddHero(this.ArgsList);
        }
    }
