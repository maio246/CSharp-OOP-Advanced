using System.Collections.Generic;
using System.Linq;

namespace Hell.Entities.Items
{
    public class RecipeItem : Item
    {
        private List<string> requiredItems;

        public RecipeItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus, params string[] requiredItems) : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
        {
            this.requiredItems = requiredItems.ToList();
        }

    }
}
