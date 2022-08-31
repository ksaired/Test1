using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeffaultSettingsInfo
{
    private LevelOfGraphic levelOfGraphic;

    
    public Dictionary<string, float> SoundsVolume = new Dictionary<string, float>() 
    {
        {"MusicVolume",100f },
        {"SoundsVolume",100f }
    };

    public Dictionary<string, string> IsActiveGraphicks = new Dictionary<string, string>()
    {
        {"LevelOfTexture", "MinimalLevelOfGraphic"},
        {"OverallLevelOfGraphic", "MinimalLevelOfGraphic"}
    };
    

    public Dictionary<string, float> LevelOfGhraphicks = new Dictionary<string, float>();
   

    public Dictionary<string, Dictionary<string, KeyCode>> InputSettings = new Dictionary<string, Dictionary<string, KeyCode>>()
    {
        {"Keyboard and Mouse", new Dictionary<string,KeyCode>()
          {
            {"Attack1",KeyCode.Mouse0 },
            {"Run",KeyCode.LeftShift }
          }
        }
    };

    public readonly List<string> AllLanguage = new List<string>() 
    {
        {"Русский" },
        {"English"},
        {"Український" },
         
    };


    public string CurrentLanguage = "Український";
   
}
