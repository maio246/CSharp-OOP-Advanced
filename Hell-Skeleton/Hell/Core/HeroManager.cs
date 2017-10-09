using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager : IManager
{
    public Dictionary<string, IHero> heroes { get; }

    public HeroManager()
    {
        this.heroes = new Dictionary<string, IHero>();
    }

    public string AddHero(List<String> arguments)
    {
        string result = null;

        string heroName = arguments[0];
        string heroType = arguments[1].Trim();

        
        try
        {
            Type clazz = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == heroType);

            object[] heroParams =
            {
                heroName
            };

            var newHero = (AbstractHero)Activator.CreateInstance(clazz, heroParams);

            heroes.Add(heroName, newHero);

            result = string.Format(Constants.HeroCreateMessage, newHero.GetType().Name, heroName);
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return result;
    }

    public string AddItemToHero(List<String> arguments, AbstractHero hero)
    {
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        IItem newItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus);

        hero.inventory.AddCommonItem(newItem);

        string result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);

        return result;
    }

    public string AddRecipeToHero(List<String> arguments, AbstractHero hero)
    {

        var recipeName = arguments[0];
        var strength = long.Parse(arguments[1]);
        var agility = long.Parse(arguments[2]);
        var intelligence = long.Parse(arguments[3]);
        var hitPoints = long.Parse(arguments[4]);
        var damage = long.Parse(arguments[5]);
        string[] reqItems = arguments.Skip(6).ToArray();

        var recipe = new Recipe(recipeName, strength, agility, intelligence, hitPoints, damage, reqItems);

        hero.AddRecipe(recipe);
        var result = string.Format(Constants.RecipeCreatedMessage, recipe.Name, hero.Name);
        return result;
    }

    public string Inspect(List<String> arguments)
    {
        string heroName = arguments[0];

        return this.heroes[heroName].ToString();
    }

    public string Quit()
    {
        var counter = 1;
        var sb = new StringBuilder();

        var sortedHeroes = heroes.Values.OrderByDescending(h => h.Strength + h.Agility + h.Intelligence)
            .ThenByDescending(h => h.HitPoints + h.Damage);

        foreach (var hero in sortedHeroes)
        {
            sb.AppendLine($"{counter}. {hero.GetType().Name}: {hero.Name}");
            sb.AppendLine($"###HitPoints: {hero.HitPoints}");
            sb.AppendLine($"###Damage: {hero.Damage}");
            sb.AppendLine($"###Strength: {hero.Strength}");
            sb.AppendLine($"###Agility: {hero.Agility}");
            sb.AppendLine($"###Intelligence: {hero.Intelligence}");
            if (hero.Items.Count == 0)
            {
                sb.AppendLine("###Items: None");
            }
            else
            {
                sb.AppendLine($"###Items: {string.Join(", ", hero.Items)}");
            }
            counter++;
        }

        return sb.ToString().Trim();
    }
}
