using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class AntiMatterDeviceItem : Craftable
    {
        public AntiMatterDeviceItem() : base(
        classId: "AntiMatterDeviceItem",
        friendlyName: "Anti Matter Device",
        description: "A Device that can be used to trasmute objects into nothing, Its just a device, it needs to be forged into a weapon first.")
        {}
        public override float CraftingTime => 15f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources" , "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(2, 2);
        public override TechType RequiredForUnlock => TechType.PrecursorIonCrystal;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "AntiMatterDeviceItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(QuantumWiringKitItem.quantumwiringkit, 1),
                    new Ingredient(SuperCondensatorItem.supercondensator, 2),
                    new Ingredient(NitrogenItem.nitrogen, 8),
                    new Ingredient(QuantumGpuItem.quantumgpu, 1),
                    new Ingredient(QuantumCpuItem.quantumcpu, 1),
                })
            };

            return recipe;
        }

    }
}