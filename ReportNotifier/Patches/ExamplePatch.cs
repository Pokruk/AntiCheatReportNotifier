using GorillaLocomotion;
using HarmonyLib;
using UnityEngine;

namespace ReportNotifier.Patches {
    [HarmonyPatch(typeof(GorillaTagger))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class ExamplePatch {
        private static void Prefix() {
            if (ReportsNotifier.enabled) {
                ReportsNotifier.InitButtons();
            } else {
                ReportsNotifier.notifiEnabled = true;
            }
        }
    }
}