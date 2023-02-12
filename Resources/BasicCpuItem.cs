using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class BasicCpuItem : Craftable
    {
        public static TechType basiccpu;
        public BasicCpuItem() : base(
        classId: "BasicCpuItem",
        friendlyName: "Basic Cpu",
        description: "A normal Central Processing Unit for processing data")
        {
            OnFinishedPatching += () =>
            {
                basiccpu = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.WiringKit;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "BasicCpuItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.Copper, 1),
                    new Ingredient(TechType.ComputerChip, 1),
                    new Ingredient(TechType.Silicone, 1),
                    new Ingredient(TechType.CopperWire, 2),
                })
            };

            return recipe;
        }

    }
}