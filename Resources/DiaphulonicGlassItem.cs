using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RecipeData = SMLHelper.V2.Crafting.TechData;

namespace ActinideMod.Resources
{

    public class DiaphulonicGlassItem : Craftable
    {
        public static TechType diaphulonicglass;
        public DiaphulonicGlassItem() : base(
        classId: "DiaphulonicGlassItem",
        friendlyName: "Diaphulonic Glass",
        description: "")
        {
            OnFinishedPatching += () =>
            {
                diaphulonicglass = TechType;
            };
        }
        public override float CraftingTime => 6f;
        public override string[] StepsToFabricatorTab => new string[] { "Resources", "BasicMaterials" };
        public override Vector2int SizeInInventory => new Vector2int(1, 1);
        public override TechType RequiredForUnlock => TechType.EnameledGlass;
        public override TechGroup GroupForPDA => TechGroup.Uncategorized;
        public override TechCategory CategoryForPDA => TechCategory.Workbench;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;
        public override string AssetsFolder => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets");
        public override string IconFileName => "DiaphulonicGlassItem.png";

        protected override RecipeData GetBlueprintRecipe()
        {
            RecipeData recipe = new RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[]
                {
                    new Ingredient(TechType.EnameledGlass, 2),
                    new Ingredient(TechType.PlasteelIngot, 1),
                    new Ingredient(TechType.Salt, 4),
                })
            };

            return recipe;
        }

    }
}