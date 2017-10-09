using System.Collections.Generic;

public class RecipeCommand : Command
    {
        public RecipeCommand(List<string> argsList, IManager manager) : base(argsList, manager)
        {
            
        }
        public override string Execute()
        {
            AbstractHero hero = (AbstractHero)this.Manager.heroes[ArgsList[1]];
            ArgsList.RemoveAt(1);
            return Manager.AddRecipeToHero(ArgsList, hero);
        }
    }