using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class TungstenItem : Craftable
    {
        public static TechType tungsten;
        public TungstenItem() : base(
        classId: "TungstenItem",
        friendlyName: "Tungsten",
        description: "Has a Huge Melting Point about 3422*C")
        {
            OnFinishedPatching += () =>
            {
                tungsten = TechType;
            };
        }
        public override float CraftingTime => 3f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources" , "AdvancedMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.PlasteelIngot;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "TungstenItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.Lead, 2),
                    new Ingredient(TechType.PlasteelIngot, 1),
                    new Ingredient(TechType.Diamond, 2),
                    new Ingredient(TechType.Magnetite, 2),
                })
            };

            return recipe;
        }

    }
}