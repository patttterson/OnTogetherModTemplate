using HarmonyLib;
using System.Collections.Generic;

namespace OnTogetherModTemplate.Patches;

[HarmonyPatch(typeof(MultiplayerManager), "CreateLobby")]
public class AddModdedTag
{
    // ReSharper disable once InconsistentNaming
    public static void Postfix( ref List<bool> ___FilterSocialTags )
    {
        if (___FilterSocialTags != null && ___FilterSocialTags.Count > 4)
        {
            ___FilterSocialTags[4] = true;
        }
    }
}