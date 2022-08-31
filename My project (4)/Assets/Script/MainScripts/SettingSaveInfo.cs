using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SettingSaveInfo
{
    public Dictionary<string, float> SoundsVolume = new Dictionary<string, float>();

    public Dictionary<string, string> IsActiveGraphicks = new Dictionary<string, string>();

    public Dictionary<string, float> LevelOfGhraphicks = new Dictionary<string, float>();

    public Dictionary<string, Dictionary<string, KeyCode>> InputSettings = new Dictionary<string, Dictionary<string, KeyCode>>();
  
    public readonly List<string> AllLanguage = new List<string>();

    public string CurrentLanguage;

   

    public SettingSaveInfo(DeffaultSettingsInfo settingsInfo)
    {
        SoundsVolume = settingsInfo.SoundsVolume;
        IsActiveGraphicks = settingsInfo.IsActiveGraphicks;
        LevelOfGhraphicks = settingsInfo.LevelOfGhraphicks;
        InputSettings = settingsInfo.InputSettings;
        AllLanguage = settingsInfo.AllLanguage;
        CurrentLanguage = settingsInfo.CurrentLanguage;

      
    }

}
