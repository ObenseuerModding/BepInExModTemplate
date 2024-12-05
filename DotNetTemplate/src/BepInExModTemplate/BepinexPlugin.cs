using BepInEx;
using BepInEx.Logging;
using BepInExModTemplate.Settings;
using HarmonyLib;

namespace BepInExModTemplate;

/*
  Here are some basic resources on code style and naming conventions to help
  you in your first CSharp plugin!

  https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
  https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
  https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces
*/

[BepInPlugin(LCMPluginInfo.PLUGIN_GUID, LCMPluginInfo.PLUGIN_NAME, LCMPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log = null!;
    internal static BepInExModTemplateSettings Settings = null!;

    private void Awake()
    {
        /*
          BepinEx makes you a ManualLogSource for free called "Logger"
          and I created a static value above to hold on to it so other
          parts of your plugin's code can find it by using Plugin.Log

          We assign it here
        */
        Log = Logger;

        /*
            BepinEx also gives you a config file based on your plugin's GUID
            in the BepinEx/config folder. We pass that file to our hand-made
            Settings object to bind specific settings to values that appear
            in sections with specific names and Bepin does the rest for us

            If the file doesn't exist it will be created with the defaults
            specified in our settings object, neat!
        */
        Settings = new(Config);

        // Log our awake here so we can see it in LogOutput.txt file
        Log.LogInfo($"Plugin {LCMPluginInfo.PLUGIN_NAME} version {LCMPluginInfo.PLUGIN_VERSION} is loaded!");

    }

}
