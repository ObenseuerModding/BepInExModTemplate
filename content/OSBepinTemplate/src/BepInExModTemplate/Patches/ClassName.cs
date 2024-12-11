/*
It is considered good practice to put any Harmony or Mono patches
in their own classes under a Patches folder like this

You name the file after the base class it patches so if this patch
was for PowerSource then you'd call it PowerSource.cs to help keep
thing organized

Note that the way I structure this class is entirely my preference
and there are more ways to do it but this way specifically allows
you granular control over when and what specifically is patched

The below example file is commented out so it won't build into your
project but you may reference it or uncomment it to Intellisense
work on it
*/

/*
using HarmonyLib;

namespace BepInExModTemplate.Patches;

public class PowerSourcePatches
{
    //This tells Harmony what method we are patching on
    //what type. This reads as PowerSource.Init() being patched
    [HarmonyPatch(typeof(PowerSource), nameof(PowerSource.Init))]
    //Here we tell Harmony our code should run after (post) the
    //Original method has completely finished
    [HarmonyPostfix]

    //Here we use what Harmony calls an "injector" to get information
    //from either the instance running the method or the original
    //arguments passed to is
    //Read more here: https://harmony.pardeike.net/articles/patching-injections.html
    public static void PowerSource_Init_Postfix(PowerSource __instance)
    {
        //Here we just access some random variable from the instance that is
        //Currently calling Init()
        Plugin.Log.LogInfo($"A power source has initialized\n  FurniturePower: {__instance.furniturePower.enabled}");
    }
}
*/
