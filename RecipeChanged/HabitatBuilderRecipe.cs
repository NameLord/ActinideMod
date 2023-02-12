using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class HabitatBuilderRecipe
    {
        public static void ApplyHabitatBuilderRecipe()
        {
            var changehabitatriflerecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.Battery, 1),
                    new Ingredient(BasicCpuItem.basiccpu, 1),
                    new Ingredient(IronPipeItem.ironpipe, 2),
                    new Ingredient(TechType.WiringKit, 1)}};

            CraftDataHandler.SetTechData(TechType.Builder, changehabitatriflerecipe);
        }
    }
}
