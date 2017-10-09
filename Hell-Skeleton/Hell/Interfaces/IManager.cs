    using System;
    using System.Collections.Generic;

public interface IManager
{
    Dictionary<string, IHero> heroes { get; }
    string AddHero(List<String> arguments);
    string AddItemToHero(List<String> arguments, AbstractHero hero);
    string AddRecipeToHero(List<String> arguments, AbstractHero hero);
    string Inspect(List<String> arguments);
    string Quit();
}