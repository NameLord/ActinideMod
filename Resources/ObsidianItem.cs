using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class ObsidianItem : Craftable
    {
        public static TechType obsidian;
        public ObsidianItem() : base(
        classId: "ObsidianItem",
        friendlyName: "Obsidian",
        description: "A much stronger Material than Kyanite can withstand dangerous pressure.")
        {
            OnFinishedPatching += () =>
            {
                obsidian = TechType;
            };
        }
        public override float CraftingTime => 5f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "AdvancedMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.Kyanite;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "ObsidianItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.Kyanite, 1),
                    new Ingredient(TechType.AluminumOxide, 2),
                    new Ingredient(TechType.Lead, 2),
                })
            };

            return recipe;
        }

    }
}