using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class PolimerBatteryItem : Craftable
    {
        public static TechType polimerbattery;
        public PolimerBatteryItem() : base(
        classId: "PolimerBatteryItem",
        friendlyName: "Polimer Battery",
        description: "Battery made of Polimer used to create batteries.")
        {
            OnFinishedPatching += () =>
            {
                polimerbattery = TechType;
            };
        }
        public override float CraftingTime => 1f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "Electronics" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.CrashPowder;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "PolimerBatteryItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 2,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(SulphurItem.sulphur, 1),
                    new Ingredient(TechType.Copper, 1),
                    new Ingredient(TechType.Salt, 1),
                    new Ingredient(TechType.Titanium, 1),
                })
            };

            return recipe;
        }

    }
}