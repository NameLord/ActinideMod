using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class LaserCutterRecipe
    {
        public static void ApplyLaserCutterRecipe()
        {
            var changelasercutterrecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.Battery, 1),
                    new Ingredient(GraphiteItem.graphite, 1),
                    new Ingredient(IronPipeItem.ironpipe, 1),
                    new Ingredient(TechType.Diamond, 2),
                    new Ingredient(TechType.Titanium, 1),
                    new Ingredient(TechType.CrashPowder, 1)}};

            CraftDataHandler.SetTechData(TechType.LaserCutter, changelasercutterrecipe);
        }
    }
}
