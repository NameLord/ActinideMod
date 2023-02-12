using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class MagnesiumItem : Craftable
    {
        public static TechType magnesium;
        public MagnesiumItem() : base(
        classId: "MagnesiumItem",
        friendlyName: "Magnesium",
        description: "Magnesium was an item for subnautica BUT it was removed for unknown reason, i added back so repair tool can have its fully potential recipe.")
        {
            OnFinishedPatching += () =>
            {
                magnesium = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources" , "AdvancedMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.Salt;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "MagnesiumItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 2,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.Salt, 3),
                    new Ingredient(TechType.Titanium, 1),
                })
            };

            return recipe;
        }

    }
}