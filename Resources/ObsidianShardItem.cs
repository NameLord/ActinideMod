using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class ObsidianShardItem : Craftable
    {
        public static TechType obsidianshard;
        public ObsidianShardItem() : base(
        classId: "ObsidianShardItem",
        friendlyName: "Obsidian Shard",
        description: "")
        {
            OnFinishedPatching += () =>
            {
                obsidianshard = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "AdvancedMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.Kyanite;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "ObsidianShardItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 4,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(ObsidianItem.obsidian, 1),
                })
            };

            return recipe;
        }

    }
}