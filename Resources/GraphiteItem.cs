using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class GraphiteItem : Craftable
    {
        public static TechType graphite;
        public GraphiteItem() : base(
        classId: "GraphiteItem",
        friendlyName: "Graphite",
        description: "Can be used for many things.")
        {
            OnFinishedPatching += () =>
            {
                graphite = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.None;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "GraphiteItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 6,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.TitaniumIngot, 1),
                    new Ingredient(TechType.Salt, 4),
                })
            };

            return recipe;
        }

    }
}