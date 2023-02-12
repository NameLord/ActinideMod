using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class QuantumGpuItem : Craftable
    {
        public static TechType quantumgpu;
        public QuantumGpuItem() : base(
        classId: "QuantumGpuItem",
        friendlyName: "Quantum Gpu",
        description: "A more Advanced Graphics Processing Unit for processing a LOT of graphical data and rendering textures, Supports DX12")
        {
            OnFinishedPatching += () =>
            {
                quantumgpu = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(2, 2);
        public override TechType RequiredForUnlock => TechType.AdvancedWiringKit;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "QuantumGpuItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(BasicGpuItem.basicgpu, 1),
                    new Ingredient(NitrogenItem.nitrogen, 1),
                    new Ingredient(MetalCableItem.metalcable, 2),
                    new Ingredient(TechType.Silver, 1),
                    new Ingredient(TechType.Aerogel, 3),
                })
            };

            return recipe;
        }

    }
}