using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class BerylliumItem : Craftable
    {
        public static TechType beryllium;
        public BerylliumItem() : base(
        classId: "BerylliumItem",
        friendlyName: "Beryllium",
        description: "Can be used in Gears and Cogs in the Aviation Industry")
        {
            OnFinishedPatching += () =>
            {
                beryllium = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "BasicMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.Silver;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "BerylliumItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 2,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.Titanium, 3),
                    new Ingredient(TechType.Silver, 1),
                    new Ingredient(TechType.Salt, 2),
                    new Ingredient(TechType.Copper, 1),
                })
            };

            return recipe;
        }

    }
}