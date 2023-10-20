namespace SkillManager
{
    internal class Settings : JsonModSettings
    {
        internal static Settings Instance { get; } = new();

        [Section("General")]

        [Name("Toggle Mod")]
        public bool EnableMod           = true;

        #region Quick Witted
        [Section("Skills Rate")]

        [Name("Archery")]
        [Slider(0, 25)]
        public int Archery              = 1;

        [Name("Carcass Harvesting")]
        [Slider(0, 25)]
        public int CarcassHarvesting    = 1;

        [Name("Clothing Repair")]
        [Slider(0, 25)]
        public int ClothingRepair       = 1;

        [Name("Cooking")]
        [Slider(0, 25)]
        public int Cooking              = 1;

        [Name("Fire Starting")]
        [Slider(0, 25)]
        public int FireStarting         = 1;

        [Name("Gun Smithing")]
        [Slider(0, 25)]
        public int GunSmithing          = 1;

        [Name("Ice Fishing")]
        [Slider(0, 25)]
        public int IceFishing           = 1;

        [Name("Revolver")]
        [Slider(0, 25)]
        public int Revolver             = 1;

        [Name("Rifle")]
        [Slider(0, 25)]
        public int Rifle                = 1;

        [Name("Tool Repair")]
        [Slider(0, 25)]
        public int ToolRepair           = 1;
        #endregion
        
        internal static void OnLoad()
        {
            Instance.AddToModSettings($"{BuildInfo.GUIName}");
        }
    }
}