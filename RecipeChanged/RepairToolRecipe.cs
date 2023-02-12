using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class RepairToolRecipe
    {
        public static void ApplyRepairToolRecipe()
        {
            var changerepairtoolrecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.Battery, 1),
                    new Ingredient(GraphiteItem.graphite, 1),
                    new Ingredient(MagnesiumItem.magnesium, 1),
                    new Ingredient(TechType.Titanium, 2),
                    new Ingredient(TechType.Silicone, 1)}};
            CraftDataHandler.SetTechData(TechType.Welder, changerepairtoolrecipe);
        }
    }
}
