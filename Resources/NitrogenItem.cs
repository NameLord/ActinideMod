using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class NitrogenItem : Craftable
    {
        public static TechType nitrogen;
        public NitrogenItem() : base(
        classId: "NitrogenItem",
        friendlyName: "Nitrogen",
        description: "Substance for cooling things sub zero")
        {
            OnFinishedPatching += () =>
            {
                nitrogen = TechType;
            };
        }
        public override float CraftingTime => 3f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "AdvancedMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.Nickel;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "NitrogenItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.AcidMushroom, 1),
                    new Ingredient(TechType.Silver, 2),
                    new Ingredient(TechType.Salt, 2),
                })
            };

            return recipe;
        }

    }
}