using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class BeaconRecipe
    {
        public static void ApplyBeaconRecipe()
        {
            var changebeaconrecipe = new RecipeData()
            {
                craftAmount = 3,
                Ingredients = {
                    new Ingredient(TechType.Copper, 1),
                    new Ingredient(TechType.Titanium, 2),
                    new Ingredient(TechType.ComputerChip, 1)}};

            CraftDataHandler.SetTechData(TechType.Beacon, changebeaconrecipe);
        }
    }
}
