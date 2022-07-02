using BepInEx;
using R2API;
using R2API.Utils;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace NoFirstStagePods
{
    [BepInDependency(R2API.R2API.PluginGUID)]
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]

    public class NoFirstStagePods : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "GiGaGon";
        public const string PluginName = "NoFirstStagePods";
        public const string PluginVersion = "1.0.0";

        public void Awake()
        {
            On.RoR2.Stage.Start += (orig, self) =>
            {
                self.SetFieldValue("usePod", false);
                orig(self);
            };
        }
    }
}
