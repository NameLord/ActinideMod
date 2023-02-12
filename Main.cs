using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ActinideMod.Resources;
using ActinideMod.RecipeChanged;

namespace ActinideMod
{
    [BepInPlugin(myGUID, pluginName, versionString)]
    public class Main : BaseUnityPlugin
    {
        private const string myGUID = "com.ngeorge.Actinide";
        private const string pluginName = "Actinide SN2.0";
        private const string versionString = "1.0.4";

        private static readonly Harmony harmony = new Harmony(myGUID);
        public static ManualLogSource logger;

        public void Awake()
        {
            harmony.PatchAll();
            Logger.LogInfo(pluginName + " " + versionString + " " + "Has been loaded!");
            logger = Logger;

            var tungsten = new TungstenItem();
            var kyrectorn = new KyrectornItem();
            var kyaniteshard = new KyaniteShardItem();
            var metalcable = new MetalCableItem();
            var superconductorcable = new SuperConductorCableItem();
            var quantumwiringkit = new QuantumWiringKitItem();
            var polimerbattery = new PolimerBatteryItem();
            var basiccpu = new BasicCpuItem();
            var quantumcpu = new QuantumCpuItem();
            var basicgpu = new BasicGpuItem();
            var quantumgpu = new QuantumGpuItem();
            var nitrogen = new NitrogenItem();
            var diaphulonicglass = new DiaphulonicGlassItem();
            var antimatterdevice = new AntiMatterDeviceItem();
            var obsidian = new ObsidianItem();
            var obsidianshard = new ObsidianShardItem();
            var supercondensator = new SuperCondensatorItem();
            var graphite = new GraphiteItem();
            var beryllium = new BerylliumItem();
            var ironpipe = new IronPipeItem();
            var ironpipefitting = new IronPipeFittingItem();
            var bromine = new BromineItem();
            var sulphur = new SulphurItem();
            var magnesium = new MagnesiumItem();

            //Now were patching everything so it goes in the game.
            // It also hard to sort what i need first.. GOD DAMMET SML...........
            // If you find this Ping me on Discord, you know my name and you know how to ping.
            // Now i have to work on 2 SITES....... DAMMNN Submodica and Nexus.

            kyrectorn.Patch();
            kyaniteshard.Patch();
            sulphur.Patch();
            magnesium.Patch();
            polimerbattery.Patch();
            metalcable.Patch();
            superconductorcable.Patch();
            basiccpu.Patch();
            basicgpu.Patch();
            nitrogen.Patch();
            quantumgpu.Patch();
            quantumcpu.Patch();
            tungsten.Patch();
            diaphulonicglass.Patch();
            quantumwiringkit.Patch();
            graphite.Patch();
            beryllium.Patch();
            obsidian.Patch();
            ironpipe.Patch();
            ironpipefitting.Patch();
            bromine.Patch();
            obsidianshard.Patch();
            supercondensator.Patch();
            antimatterdevice.Patch();

            // Apply Changes to Some items recipe
            // BatteryRecipe.ApplyBatteryRecipe();
            // RepairToolRecipe.ApplyRepairToolRecipe();
            // LaserCutterRecipe.ApplyLaserCutterRecipe();
            // FlashlightRecipe.ApplyFlashlightRecipe();
            // StasisRifleRecipe.ApplyStasisRifleRecipe();
            // HabitatBuilderRecipe.ApplyHabitatBuilderRecipe();
            // BeaconRecipe.ApplyBeaconRecipe();
            // MobileVehicleBayRecipe.ApplyMobileVehicleBayRecipe();
            // SeaglideRecipe.ApplySeaglideRecipe();

        }

    }
}
