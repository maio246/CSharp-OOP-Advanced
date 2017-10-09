using System.Collections.Generic;

public class ItemCommand : Command
    {
        public ItemCommand(List<string> argsList, IManager manager) : base(argsList, manager)
        {

        }
        public override string Execute()
        {
            AbstractHero hero = (AbstractHero)this.Manager.heroes[ArgsList[1]];
            return Manager.AddItemToHero(ArgsList, hero);
        }
    }