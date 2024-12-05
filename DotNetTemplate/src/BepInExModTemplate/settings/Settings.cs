using BepInEx.Configuration;

namespace BepInExModTemplate.Settings;

public class BepInExModTemplateSettings(ConfigFile config)
{
    public ConfigEntry<bool> MySettingsBool = config.Bind<bool>("SectionName", "MySettingsBool", true, "This is an example boolean setting!");
}
