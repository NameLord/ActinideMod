using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class QuantumCpuItem : Craftable
    {
        public static TechType quantumcpu;
        public QuantumCpuItem() : base(
        classId: "QuantumCpuItem",
        friendlyName: "Quantum Cpu",
        description: "A more advanced of Central Processing Unit for processing lots of data")
        {
            OnFinishedPatching += () =>
            {
                quantumcpu = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(2, 2);
        public override TechType RequiredForUnlock => TechType.AdvancedWiringKit;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "QuantumCpuItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(BasicCpuItem.basiccpu, 1),
                    new Ingredient(NitrogenItem.nitrogen, 1),
                    new Ingredient(TechType.Silver, 2),
                    new Ingredient(TechType.Aerogel, 3),
                    new Ingredient(TechType.Magnetite, 2),
                })
            };

            return recipe;
        }

    }
}