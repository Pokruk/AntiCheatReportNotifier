using BepInEx;
using System;
using UnityEngine;

namespace ReportNotifier {
    [BepInDependency("org.pokruk.gorillatag.pokrukmenu", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("org.pragmate.pokruk.notifications")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin {
        void OnEnable() {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable() {
            HarmonyPatches.RemoveHarmonyPatches();
        }
    }
}
