using BepInEx;
using BepInEx.Logging;
using CMSound_Mod.Patches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.PlayerLoop;

namespace CMSound_Mod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class CMSound_Mod_Base : BaseUnityPlugin
    {
        private const string modGUID = "Poseidon.CMSound_Mod";
        private const string modName = "CM Sound Mod";
        private const string modVersion = "1.1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        internal static CMSound_Mod_Base Instance;

        internal static ManualLogSource mls;

        //Creates an AudioClip list which is the list that the sound will be heald in.
        internal static List<AudioClip> SoundFX;
        internal static AssetBundle Bundle;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            //This message is printed in the console when the mod has successfully been detected and activated.
            mls.LogInfo("The Scooby Laugh is Active!!!!!");

            harmony.PatchAll(typeof(CMSound_Mod_Base));
            harmony.PatchAll(typeof(StartOfRoundPatch));

            mls = Logger;

            //Initializes a new list of AudioClips
            SoundFX = new List<AudioClip>();

            //This insures that the folder it will be checking for sound files is the same folder that the dll file is located in.
            string FolderLocation = Instance.Info.Location;
            FolderLocation = FolderLocation.TrimEnd("CMSound_Mod.dll".ToCharArray());

            //Checks for a file named "scoob" which is the name of the audio file containing the scoob sound effect which is to be built in Unity.
            Bundle = AssetBundle.LoadFromFile(FolderLocation + "scoob");

            //Check if it has loaded correctly into the Bundle variable. If it has, it prints that to the console, letting the user know.
            if (Bundle != null)
            {
                mls.LogInfo("Successfully loaded asset bundle!");
                //Appends the audio clip to the list
                //More audio can be added to this list, and it would be accessed as SoundFX[1], SoundFX[2], and so on.
                SoundFX = Bundle.LoadAllAssets<AudioClip>().ToList();
            }
            else
            {
                //Printed if it fails to load the sound file into the game.
                mls.LogError("Failed to load asset bundle!");
            }

        }

    }
}
