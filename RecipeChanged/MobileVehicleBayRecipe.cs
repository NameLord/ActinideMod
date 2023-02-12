using SMLHelper.V2.Crafting;
using RecipeData = SMLHelper.V2.Crafting.TechData;
using ActinideMod.Resources;
using SMLHelper.V2.Handlers;

namespace ActinideMod.RecipeChanged
{
    public static class MobileVehicleBayRecipe
    {
        public static void ApplyMobileVehicleBayRecipe()
        {
            var changemobilevehiclebayrecipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = {
                    new Ingredient(TechType.PowerCell, 1),
                    new Ingredient(BasicCpuItem.basiccpu, 1),
                    new Ingredient(BasicGpuItem.basicgpu, 1),
                    new Ingredient(TechType.TitaniumIngot, 1),
                    new Ingredient(TechType.Lubricant, 1)}};

            CraftDataHandler.SetTechData(TechType.Constructor, changemobilevehiclebayrecipe);
        }
    }
}
