using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public abstract class AbstractHero
    : IHero, IComparable<AbstractHero>
{
    public IInventory inventory { get; set; }
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    public AbstractHero(string name)
    {
        this.Name = name;
        this.inventory = new HeroInventory();
        
    }

    public string Name { get; protected set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        protected set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        protected set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        protected set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        protected set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        protected set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            var type = this.inventory.GetType();
            FieldInfo fiel = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(f => f.GetCustomAttributes(typeof(ItemAttribute), true).Length != 0);
            var newKvp = (Dictionary<string, IItem>) fiel.GetValue(this.inventory);

            return newKvp.Select(x => x.Value).ToList();
        }
    }

    public void AddRecipe(Recipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
        this.inventory.CheckRecipes();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Hero: {this.Name}, Class: {this.GetType().Name}");
        sb.AppendLine($"HitPoints: {this.HitPoints}, Damage: {this.Damage}");
        sb.AppendLine($"Strength: {this.Strength}");
        sb.AppendLine($"Agility: {this.Agility}");
        sb.AppendLine($"Intelligence: {this.Intelligence}");

        if (Items.Count == 0)
        {
            sb.AppendLine("Items: None");
        }
        else
        {
            sb.AppendLine("Items:");

            foreach (var item in Items)
            {
                sb.AppendLine($"###Item: {item.Name}");
                sb.AppendLine($"###+{item.StrengthBonus} Strength");
                sb.AppendLine($"###+{item.AgilityBonus} Agility");
                sb.AppendLine($"###+{item.IntelligenceBonus} Intelligence");
                sb.AppendLine($"###+{item.HitPointsBonus} HitPoints");
                sb.AppendLine($"###+{item.DamageBonus} Damage");

            }
        }
        return sb.ToString().Trim();
    }

    public int CompareTo(AbstractHero other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var strengthComparison = strength.CompareTo(other.strength);
        if (strengthComparison != 0) return strengthComparison;
        var agilityComparison = agility.CompareTo(other.agility);
        if (agilityComparison != 0) return agilityComparison;
        var intelligenceComparison = intelligence.CompareTo(other.intelligence);
        if (intelligenceComparison != 0) return intelligenceComparison;
        var hitPointsComparison = hitPoints.CompareTo(other.hitPoints);
        if (hitPointsComparison != 0) return hitPointsComparison;
        var damageComparison = damage.CompareTo(other.damage);
        if (damageComparison != 0) return damageComparison;
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}