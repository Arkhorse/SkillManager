namespace SkillManager
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.IncrementPointsAndNotify), new Type[] { typeof(SkillType), typeof(int), typeof(SkillsManager.PointAssignmentMode) })]
    public class SkillsManager_IncrementPointsAndNotify
    {
        public static bool Prefix()
        {
            if (!Settings.Instance.EnableMod) return true;
            return false;
        }
        public static void Postfix(SkillsManager __instance, SkillType skillType, int numPoints, SkillsManager.PointAssignmentMode mode)
        {
            if (!Settings.Instance.EnableMod) return;
            Skill skill = GameManager.GetSkillsManager().GetSkill(skillType);
            if ((bool)skill && skill.GetPoints() != skill.GetMaxPoints())
            {
                int currentTierNumber = skill.GetCurrentTierNumber();
                numPoints *= Main.GetSkillUpgrade(skillType); // modded
                skill.IncrementPoints(numPoints, mode);
                int currentTierNumber2 = skill.GetCurrentTierNumber();
                GameManager.GetSkillNotify().MaybeShowPointIncrease(skill.m_SkillIcon);
                if (currentTierNumber2 > currentTierNumber)
                {
                    GameManager.GetAchievementManagerComponent().UpdateAchievements();
                    GameManager.GetSkillNotify().MaybeShowLevelUp(skill.m_SkillIconBackground, skill.m_DisplayName, __instance.GetTierName(currentTierNumber2), currentTierNumber2 + 1);
                }
            }
        }
    }
}
