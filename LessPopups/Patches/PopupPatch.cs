using HarmonyLib;

namespace LessPopups.Patches;

[HarmonyPatch(typeof(HUDManager))]
public class PopupPatch
{
    
    [HarmonyPatch("AddNewScrapFoundToDisplay")]
    [HarmonyPrefix]
    public static bool SuppressPopup()
    {
        return false;
    }

    [HarmonyPatch("DisplayNewScrapFound")]
    [HarmonyPrefix]
    public static bool KillPopup()
    {
        return false;
    }
    
}