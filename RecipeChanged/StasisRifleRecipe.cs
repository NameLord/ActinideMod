using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class StasisRifleRecipe
    {
        public static void ApplyStasisRifleRecipe()
        {
            var changestasisriflerecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.Battery, 1),
                    new Ingredient(GraphiteItem.graphite, 1),
                    new Ingredient(BasicCpuItem.basiccpu, 1),
                    new Ingredient(IronPipeItem.ironpipe, 2),
                    new Ingredient(TechType.Titanium, 1),
                    new Ingredient(TechType.Magnetite, 2)}};

            CraftDataHandler.SetTechData(TechType.StasisRifle, changestasisriflerecipe);
        }
    }
}
