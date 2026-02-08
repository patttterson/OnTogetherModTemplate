using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace OnTogetherModTemplate;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    public static Plugin Instance { get; private set; }

    // ReSharper disable once InconsistentNaming
    private const string PluginGUID = "com.example.ontogethermodtemplate";
    private const string PluginName = "On-Together Mod Template";
    private const string PluginVersion = "1.0.0";
    private const string PluginAuthor = "Example"; // change to thunderstore team name
    
    private ConfigEntry<bool> _configExampleVar;

    private readonly Harmony _harmony = new Harmony(PluginGUID);
    
    public static ManualLogSource Log;

    private void Awake()
    {
        Instance = this;
        Log = Logger;
        
        _configExampleVar = Config.Bind(
            "General",
            "ExampleConfigVar",
            true,
            "This is an example config variable. Read more at https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/4_configuration.html"
        );

        Logger.LogInfo($"Plugin {PluginGUID} is loaded!");
        _harmony.PatchAll();
    }
}