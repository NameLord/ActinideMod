using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class FlashlightRecipe
    {
        public static void ApplyFlashlightRecipe()
        {
            var changeflashlightrecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.Battery, 1),
                    new Ingredient(TechType.Glass, 1),
                    new Ingredient(TechType.Titanium, 1)}};
            CraftDataHandler.SetTechData(TechType.Flashlight, changeflashlightrecipe);
        }
    }
}
