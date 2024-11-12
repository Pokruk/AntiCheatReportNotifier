using System.Runtime.CompilerServices;
using BepInEx.Bootstrap;
using HarmonyLib;
using Photon.Pun;
using PokrukMenu;
using PokrukMenu.Classes;
using PokrukMenu.Menu;
using PokrukNotifyLib.Notifications;

namespace ReportNotifier {
    [HarmonyPatch(typeof(GorillaNot), nameof(GorillaNot.SendReport))]
    public static class ReportsNotifier {
        public static bool notifiEnabled = false;
        public static bool Prefix(string susReason, string susId, string susNick) {
            var toPrevent = PhotonNetwork.PlayerList.Length == 1;
            if (notifiEnabled) 
                NotifiLib.Send(susNick + " reported for " + susReason + (toPrevent ? " (but prevented as you are solo)" : ""));
            return toPrevent == false;
        }
        
        private static bool? _enabled;
        public static bool enabled {
            get {
                if (_enabled == null)
                    _enabled = Chainloader.PluginInfos.ContainsKey("org.pokruk.gorillatag.pokrukmenu");
                return (bool)_enabled;
            }
        }
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void InitButtons() {
            PokrukMenuAPI.AddButtonToPage(Buttons.PageNames.MainMods, Buttons.toToggleButton(
                "RPCReportNotifierEnabled",
                () => notifiEnabled, 
                val => notifiEnabled = val, 
                true));
        }
    }
}
