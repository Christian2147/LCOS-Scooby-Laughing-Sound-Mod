using HarmonyLib;
using GameNetcodeStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CMSound_Mod.Patches
{
    [HarmonyPatch(typeof(StartOfRound))]
    internal class StartOfRoundPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void OverrideAudio(StartOfRound __instance)
        {
            Random random_number_generator = new Random();

            int random_number_1 = random_number_generator.Next(0, 2);
            int random_number_2 = random_number_generator.Next(0, 2);
            int random_number_3 = random_number_generator.Next(0, 2);
            int random_number_4 = random_number_generator.Next(0, 2);
            int random_number_5 = random_number_generator.Next(0, 2);
            int random_number_6 = random_number_generator.Next(0, 2);
            int random_number_7 = random_number_generator.Next(0, 2);
            int random_number_8 = random_number_generator.Next(0, 2);
            int random_number_9 = random_number_generator.Next(0, 2);
            int random_number_10 = random_number_generator.Next(0, 2);
            int random_number_11 = random_number_generator.Next(0, 2);
            int random_number_12 = random_number_generator.Next(0, 2);
            int random_number_13 = random_number_generator.Next(0, 2);
            int random_number_14 = random_number_generator.Next(0, 2);
            int random_number_15 = random_number_generator.Next(0, 2);

            __instance.shipIntroSpeechSFX = CMSound_Mod_Base.SoundFX[0];

            if (random_number_1 == 1)
            {
                __instance.playerJumpSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_2 == 1)
            {
                __instance.playedDrowningSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_3 == 1)
            {
                __instance.hitPlayerSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_4 == 1)
            {
                __instance.shipArriveSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_5 == 1)
            {
                __instance.zeroDaysLeftAlertSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_6 == 1)
            {
                __instance.alarmSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_7 == 1)
            {
                __instance.bloodGoreSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_8 == 1)
            {
                __instance.shipDepartSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_9 == 1)
            {
                __instance.disableSpeakerSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_10 == 1)
            {
                __instance.suckedIntoSpaceSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_11 == 1)
            {
                __instance.firedVoiceSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_12 == 1)
            {
                __instance.fallDamageSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_13 == 1)
            {
                __instance.damageSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_14 == 1)
            {
                __instance.changeSuitSFX = CMSound_Mod_Base.SoundFX[0];
            }
            if (random_number_15 == 1)
            {
                __instance.HUDSystemAlertSFX = CMSound_Mod_Base.SoundFX[0];
            }
        }
    }
}
