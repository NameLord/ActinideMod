using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class SeaglideRecipe
    {
        public static void ApplySeaglideRecipe()
        {
            var changeseagliderecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.Battery, 1),
                    new Ingredient(BasicCpuItem.basiccpu, 1),
                    new Ingredient(BasicGpuItem.basicgpu, 1),
                    new Ingredient(TechType.Titanium, 1),
                    new Ingredient(TechType.Glass, 1)}};

            CraftDataHandler.SetTechData(TechType.Seaglide, changeseagliderecipe);
        }
    }
}
