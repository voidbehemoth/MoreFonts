using SML;

namespace MoreFonts
{
    [Mod.SalemMod]
    public class Main
    {
        public static void Start()
        {
            MoreFonts.Utils.Logger.Log(ModInfo.PLUGIN_NAME + " has loaded!");
        }
    }


    public static class ModInfo
    {
        public const string PLUGIN_GUID = "MoreFonts";

        public const string PLUGIN_NAME = "MoreFonts";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}