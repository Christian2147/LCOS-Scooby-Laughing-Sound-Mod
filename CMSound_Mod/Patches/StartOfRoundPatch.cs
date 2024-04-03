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
            //Creates 15 independent random numbers using the C# random class
            //A new random variable is created each time because it appearently has to do with the systam clock and creating a new one each time ensures that it is fully random
            Random random_number_generator = new Random();
            int random_number_1 = random_number_generator.Next(0, 2);
            Random random_number_generator_2 = new Random();
            int random_number_2 = random_number_generator_2.Next(0, 2);
            Random random_number_generator_3 = new Random();
            int random_number_3 = random_number_generator_3.Next(0, 2);
            Random random_number_generator_4 = new Random();
            int random_number_4 = random_number_generator_4.Next(0, 2);
            Random random_number_generator_5 = new Random();
            int random_number_5 = random_number_generator_5.Next(0, 2);
            Random random_number_generator_6 = new Random();
            int random_number_6 = random_number_generator_6.Next(0, 2);
            Random random_number_generator_7 = new Random();
            int random_number_7 = random_number_generator_7.Next(0, 2);
            Random random_number_generator_8 = new Random();
            int random_number_8 = random_number_generator_8.Next(0, 2);
            Random random_number_generator_9 = new Random();
            int random_number_9 = random_number_generator_9.Next(0, 2);
            Random random_number_generator_10 = new Random();
            int random_number_10 = random_number_generator_10.Next(0, 2);
            Random random_number_generator_11 = new Random();
            int random_number_11 = random_number_generator_11.Next(0, 2);
            Random random_number_generator_12 = new Random();
            int random_number_12 = random_number_generator_12.Next(0, 2);
            Random random_number_generator_13 = new Random();
            int random_number_13 = random_number_generator_13.Next(0, 2);
            Random random_number_generator_14 = new Random();
            int random_number_14 = random_number_generator_14.Next(0, 2);
            Random random_number_generator_15 = new Random();
            int random_number_15 = random_number_generator_15.Next(0, 2);

            //The Ship Intro Speech will always have the scooby laugh. This is how you know the mod is working.
            __instance.shipIntroSpeechSFX = CMSound_Mod_Base.SoundFX[0];

            //The Soocoby Laugh has a random chance to be added to 15 different sounds in the game.
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
