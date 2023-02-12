using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class QuantumWiringKitItem : Craftable
    {
        public static TechType quantumwiringkit;
        public QuantumWiringKitItem() : base(
        classId: "QuantumWiringKitItem",
        friendlyName: "Quantum Wiring Kit",
        description: "")
        {
            OnFinishedPatching += () =>
            {
                quantumwiringkit = TechType;
            };
        }
        public override float CraftingTime => 10f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.PrecursorIonCrystal;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "QuantumWiringKitItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(SuperConductorCableItem.superconductorcable, 1),
                    new Ingredient(DiaphulonicGlassItem.diaphulonicglass, 2),
                    new Ingredient(TungstenItem.tungsten, 2),
                    new Ingredient(TechType.AdvancedWiringKit, 1),
                })
            };

            return recipe;
        }

    }
}