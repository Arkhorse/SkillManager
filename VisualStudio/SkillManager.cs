namespace SkillManager
{
    internal class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

        public static int GetSkillUpgrade(SkillType skillType)
        {
            int result = skillType switch
            {
                SkillType.Archery               => Settings.Instance.Archery,
                SkillType.CarcassHarvesting     => Settings.Instance.CarcassHarvesting,
                SkillType.ClothingRepair        => Settings.Instance.ClothingRepair,
                SkillType.Cooking               => Settings.Instance.Cooking,
                SkillType.Firestarting          => Settings.Instance.FireStarting,
                SkillType.Gunsmithing           => Settings.Instance.GunSmithing,
                SkillType.IceFishing            => Settings.Instance.IceFishing,
                SkillType.Revolver              => Settings.Instance.Revolver,
                SkillType.Rifle                 => Settings.Instance.Rifle,
                SkillType.ToolRepair            => Settings.Instance.ToolRepair,
                _ => 1
            };
            return result;
        }
    }
}
