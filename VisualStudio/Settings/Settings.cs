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
        [Slider(0, 100)]
        public int Archery              = 1;

        [Name("Carcass Harvesting")]
        [Slider(0, 100)]
        public int CarcassHarvesting    = 1;

        [Name("Clothing Repair")]
        [Slider(0, 100)]
        public int ClothingRepair       = 1;

        [Name("Cooking")]
        [Slider(0, 100)]
        public int Cooking              = 1;

        [Name("Fire Starting")]
        [Slider(0, 100)]
        public int FireStarting         = 1;

        [Name("Gun Smithing")]
        [Slider(0, 100)]
        public int GunSmithing          = 1;

        [Name("Ice Fishing")]
        [Slider(0, 100)]
        public int IceFishing           = 1;

        [Name("Revolver")]
        [Slider(0, 100)]
        public int Revolver             = 1;

        [Name("Rifle")]
        [Slider(0, 100)]
        public int Rifle                = 1;

        [Name("Tool Repair")]
        [Slider(0, 100)]
        public int ToolRepair           = 1;
        #endregion


        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
        {
            base.OnChange(field, oldValue, newValue);

            if (field.Name == nameof(EnableMod)) Refresh();
        }

        internal void Refresh()
        {
            SetFieldVisible(nameof(Archery), Instance.EnableMod);
            SetFieldVisible(nameof(CarcassHarvesting), Instance.EnableMod);
            SetFieldVisible(nameof(ClothingRepair), Instance.EnableMod);
            SetFieldVisible(nameof(Cooking), Instance.EnableMod);
            SetFieldVisible(nameof(FireStarting), Instance.EnableMod);
            SetFieldVisible(nameof(GunSmithing), Instance.EnableMod);
            SetFieldVisible(nameof(IceFishing), Instance.EnableMod);
            SetFieldVisible(nameof(Revolver), Instance.EnableMod);
            SetFieldVisible(nameof(Rifle), Instance.EnableMod);
            SetFieldVisible(nameof(ToolRepair), Instance.EnableMod);
        }
        
        internal static void OnLoad()
        {
            Instance.AddToModSettings($"{BuildInfo.GUIName}");
            Instance.Refresh();
        }
    }
}