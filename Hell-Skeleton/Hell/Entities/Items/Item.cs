﻿    public abstract class Item : IItem
    {
        protected Item(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus)
        {
            this.Name = name;
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

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }