using MelonLoader;
using ModThatIsNotMod;
using ModThatIsNotMod.BoneMenu;
using ModThatIsNotMod.MonoBehaviours;
using UnityEngine;
using UnityEngine.UI;
using StressLevelZero;
using StressLevelZero.Player;
using StressLevelZero.VRMK;
using System;
using StressLevelZero.Combat;



//  _____       _                 _   __          __        _         
// |  __ \     | |               (_)  \ \        / /       | |        
// | |  | | ___| |__  _   _  __ _ _ _ _\ \  /\  / /__  _ __| | _____  
// | |  | |/ _ \ '_ \| | | |/ _` | | '_ \ \/  \/ / _ \| '__| |/ / __| 
// | |__| |  __/ |_) | |_| | (_| | | | | \  /\  / (_) | |  |   <\__ \ 
// |_____/ \___|_.__/ \__,_|\__, |_|_| |_|\/  \/ \___/|_|  |_|\_\___/ 
//                         __/ |                                    
//                        |___/                                     
//
//                      A NullCorp Product
//                   ©2021 Some Rights Reserved.




namespace DebuginWorks
{

    

    public static class BuildInfo
    {
        public const string Name = "DebuginWorks"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "AccurateIsaiah"; // Author of the Mod.  (Set as null if none)
        public const string Company = "NullCorp MythOS Tools Corp"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.0.3"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class DebuginWorks : MelonMod
    {


        PlayerInventory inventory = GameObject.Find("[RigManager (Default Brett)]").GetComponent<PlayerInventory>();



        public float timeScaleSpeed = 1.0f;
        public Enum ammoWeight;
        public int ammoAmount;

        public override void OnApplicationStart()
        {
            LoggerInstance.Msg("DebuginWorks 0.0.1 Loading.");
     

            // BoneMenu setup
            MenuCategory menu = MenuManager.CreateCategory("DebuginWorks", Color.white);

            MenuCategory playerInfoCategory = menu.CreateSubCategory("Player Tools", Color.white);


            // TODO: WORK ON THIS playerInfoCategory.CreateFunctionElement("Get Current Player Position", Color.white, (() =>

            MenuCategory fpsCategory = menu.CreateSubCategory("Time & FPS Related Tools", Color.yellow);

            fpsCategory.CreateFunctionElement("Get Current DeltaTime", Color.white, () => LoggerInstance.Msg(Time.deltaTime));
            fpsCategory.CreateFunctionElement("Get Current FPS", Color.white, () => LoggerInstance.Msg(Time.captureFramerate));
            fpsCategory.CreateFunctionElement("Get Current TimeScale", Color.white, () => LoggerInstance.Msg(Time.timeScale));
            fpsCategory.CreateFunctionElement("Get Seconds Since Level Load", Color.white, () => LoggerInstance.Msg(Time.timeSinceLevelLoad));
            fpsCategory.CreateFunctionElement("Get Rendered Frame Count", Color.white, () => LoggerInstance.Msg(Time.renderedFrameCount));
            fpsCategory.CreateFloatElement("Set TimeScale of current scene", Color.white, 1.0f, (value) => timeScaleSpeed = Time.timeScale = (value), 0.5f, 0.5f, 5000f, true);

            // really funny shit 
            MenuCategory junkNobodyAskedFor = menu.CreateSubCategory("Extra Junk (WIP)", Color.gray);
            junkNobodyAskedFor.CreateFunctionElement("fuck up game physics", Color.red, (() => fuck()));




        }
        

        public void fuck()
        {
            Physics.gravity = new Vector3(2, 1.5F, 0);
            

        }


        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
           
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            // TODO: make this work
            // some sort of on screen text or fps counter i dunno
            // UnityEngine.UI.Text.
            
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            
        }


        public override void OnUpdate()
        {
            
        }

        public override void OnFixedUpdate()
        {
            
        }

        public override void OnLateUpdate()
        {
            
        }

        public override void OnGUI()
        {
           
        }

        public override void OnApplicationQuit()
        {
           
        }

        public override void OnPreferencesLoaded()
        {
            
        }

    }
}
