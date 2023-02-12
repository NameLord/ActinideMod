using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class SuperCondensatorItem : Craftable
    {
        public static TechType supercondensator;
        public SuperCondensatorItem() : base(
        classId: "SuperCondensatorItem",
        friendlyName: "Super Condensator",
        description: "Outputs a LOT of Energy at a fast rate")
        {
            OnFinishedPatching += () =>
            {
                supercondensator = TechType;
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
        public override string IconFileName => "SuperCondensatorItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(PolimerBatteryItem.polimerbattery, 4),
                    new Ingredient(TechType.AdvancedWiringKit, 2),
                    new Ingredient(TechType.Titanium, 4),
                    new Ingredient(TechType.CopperWire, 2),
                    new Ingredient(TechType.Salt, 2),
                })
            };

            return recipe;
        }

    }
}