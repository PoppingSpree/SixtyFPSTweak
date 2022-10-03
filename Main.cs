using MelonLoader;
using UnityEngine;

namespace SixtyFPSTweak.RisingSlash
{
    public static class BuildInfo
    {
        public const string Name = "Sixty FPS Tweak"; // Name of the Mod.  (MUST BE SET)

        public const string Description =
            "A mod that attempts to enforce a more stable 60 frames per second by overwriting " +
            "Freedom Planet 2's Vsync and TargetFrameRate values and using coroutines to " +
            "stall the CPU for the appropriate amount of time. " +
            "This is heavily based on ForceRenderRate.cs written by ToulouseUnity and can be found here: " +
            "<https://github.com/Unity-Technologies/GenLockProofOfConcept/blob/master/Assets/ForceRenderRate.cs>"; // Description for the Mod.  (Set as null if none)

        public const string Author = "Catssandra Ann"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://risingslash.net/downloads/mods/fp2/sixtyfpstweak/"; // Download Link for the Mod.  (Set as null if none)
    }

    public class SixtyFPSTweak : MelonMod
    {
        public static GameObject goSixtyFPSTweak;
        public static ForceRenderRate frrSixtyFPSTweak;
        
        public static MelonPreferences_Category PrefsSixtyFPSTweak;
        public static MelonPreferences_Entry<float> TargetFrameRate;
        
        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonLogger.Msg("60 FPS Tweak is active.");
            MelonPreferences.Load();
            PrefsSixtyFPSTweak = MelonPreferences.CreateCategory("SixtyFPSTweak");
            TargetFrameRate = PrefsSixtyFPSTweak.CreateEntry("TargetFrameRate", 60f);
            MelonPreferences.Save();
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            if (goSixtyFPSTweak == null)
            {
                goSixtyFPSTweak = new GameObject();
                GameObject.DontDestroyOnLoad(goSixtyFPSTweak);
                frrSixtyFPSTweak = goSixtyFPSTweak.AddComponent<ForceRenderRate>();
                frrSixtyFPSTweak.ChangeTargetFramerate(TargetFrameRate.Value);
            }
            
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 9999;
            MelonLogger.Msg($"SixtyFPSHack refreshed with scene load. Target Framerate: {frrSixtyFPSTweak.Rate}");
        }
    }
}