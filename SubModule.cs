using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using HarmonyLib;

namespace EducationAutomation
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            // Initialize Harmony and apply patches
            var harmony = new Harmony("EducationCampaignBehaviorPatch");
            harmony.PatchAll();
        }
    }
}