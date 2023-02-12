using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class SuperConductorCableItem : Craftable
    {
        public static TechType superconductorcable;
        public SuperConductorCableItem() : base(
        classId: "SuperConductorCableItem",
        friendlyName: "Super Conductor Cable",
        description: "Cable made of Super alloy Material")
        {
            OnFinishedPatching += () =>
            {
                superconductorcable = TechType;
            };
        }
        public override float CraftingTime => 8f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.PrecursorIonCrystal;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "SuperConductorCableItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(MetalCableItem.metalcable, 6),
                    new Ingredient(TechType.PrecursorIonCrystal, 2),
                    new Ingredient(TechType.Nickel, 2),
                    new Ingredient(TechType.Magnetite, 1),
                })
            };

            return recipe;
        }

    }
}