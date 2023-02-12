using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class SulphurItem : Craftable
    {
        public static TechType sulphur;
        public SulphurItem() : base(
        classId: "SulphurItem",
        friendlyName: "Sulphur",
        description: "Sulphur is used for making car batteries, fertilizer, oil refining, water processing, and mineral extraction")
        {
            OnFinishedPatching += () =>
            {
                sulphur = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources" , "BasicMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.CrashPowder;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "SulphurItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 8,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.Salt, 4),
                    new Ingredient(TechType.CrashPowder, 2),
                    new Ingredient(TechType.Silver, 2),
                    new Ingredient(TechType.Copper, 1),
                })
            };

            return recipe;
        }

    }
}