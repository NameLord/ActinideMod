using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class BatteryRecipe
    {
        public static void ApplyBatteryRecipe()
        {
            var changebatteryrecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(PolimerBatteryItem.polimerbattery, 1),
                    new Ingredient(GraphiteItem.graphite, 1),
                    new Ingredient(TechType.Titanium, 1)}};
            CraftDataHandler.SetTechData(TechType.Battery, changebatteryrecipe);
        }
    }
}
