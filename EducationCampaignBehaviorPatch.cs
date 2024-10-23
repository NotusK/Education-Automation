using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using HarmonyLib;

namespace EducationAutomation
{
    [HarmonyPatch(typeof(EducationCampaignBehavior), "RegisterEvents")]
    public static class EducationCampaignBehaviorPatch
    {
        // Prefix method to disable RegisterEvents
        [HarmonyPrefix]
        public static bool RegisterEventsDisabled()
        {
            // Returning false prevents the original method from being executed
            return false;
        }
    }
}
