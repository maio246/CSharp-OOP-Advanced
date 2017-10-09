
    public class Recipe : IRecipe
    {
        public Recipe(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus, params string[] requiredItems)
        {
            this.Name = name;
            this.RequiredItems = requiredItems;
            this.StrengthBonus = strengthBonus;
            this.AgilityBonus = agilityBonus;
            this.IntelligenceBonus = intelligenceBonus;
            this.HitPointsBonus = hitPointsBonus;
            this.DamageBonus = damageBonus;
        }
        public string Name { get; }
        public long StrengthBonus { get; }
        public long AgilityBonus { get; }
        public long IntelligenceBonus { get; }
        public long HitPointsBonus { get; }
        public long DamageBonus { get; }
        public string[] RequiredItems { get; }

    }