using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public static class UIInfo
{
    public static string SaveUIInfoPath { private set; get; }
    public static string SettingsSaveInfoPath { private set; get; }
    public static string CurrentGameSavePath { private set; get; }

    public static float TimeValue { private set; get; }

    public static List<string> PreviusMenu { private set; get; }
    public static  GameObject CurrenDeleteMenu { private set; get; }
    public static PlayerObjectFacade CurrentPlayer { private set; get; }
    public static SaveInformation saveInformation { private set; get; }
    public static SettingSaveInfo settingsInformation { private set; get;}

    private static FindOfUI findUI = new FindOfUI();
    private static SaveAndLoad SaveAndLoadScript = new SaveAndLoad();
    private static SaveandLoadAnotherAssets SaveandLoadAnotherassets = new SaveandLoadAnotherAssets();

    private static DeffaultSaveInfo deffaultSaveInfo = new DeffaultSaveInfo();
    private static DeffaultSettingsInfo deffaultSettingsSaveInfo = new DeffaultSettingsInfo();
    private static DeffaultMenuLinkToObjectAssets CurrentDeffaultMenuLinkToObjectAssets = new DeffaultMenuLinkToObjectAssets();

    private static string deffaultUIInfoPath = "save.gamessereecv1899988474478999999";
    private static string deffultSettingsInfoPath = "settingssave.grafeteecv184478999999";
    private static string deffaultCurrentGameSavePath = "GameSave245879999999774478999999";
   
    public static void StartInfo()
    {
        StartChildren();

        PreviusMenu = new List<string>();
    }

    public static void Load()
    {
        LoadInfo();
        LoadChildren();
    }
    public static void LoadInfo()
    {
        SaveUIInfoPath = Application.persistentDataPath + deffaultUIInfoPath;
        SettingsSaveInfoPath = Application.persistentDataPath + deffultSettingsInfoPath;
        CurrentGameSavePath = Application.persistentDataPath + deffaultCurrentGameSavePath;

        saveInformation = SaveAndLoadScript.Load(new SaveInformation(deffaultSaveInfo), SaveUIInfoPath);
        settingsInformation = SaveAndLoadScript.Load(new SettingSaveInfo(deffaultSettingsSaveInfo), SettingsSaveInfoPath);
    }
    public static void Save()
    {
        SaveChildren();
        SaveInfo();       
    }
    public static void SaveInfo()
    {

        SaveAndLoadScript.Save(saveInformation, SaveUIInfoPath);
        SaveAndLoadScript.Save(settingsInformation, SettingsSaveInfoPath);
    }

    public static void ChangesaveInformation(SaveInformation newSaveInformation)
    {
        saveInformation = newSaveInformation;
    }
    public static void ChangesettingsInformation(SettingSaveInfo newSettingInformation)
    {
        settingsInformation = newSettingInformation;
    }
    
    public static void AddToPriviusMenu(string newPreviusMenu)
    {
        PreviusMenu.Add(newPreviusMenu);
    }
    public static void RemoveFromPriviusMenu(string RemovePreviusMenu)
    {
        PreviusMenu.Remove(RemovePreviusMenu);
    }
    public static void ChangeCurrentDeleteMenu(GameObject DeleteMenu)
    {
        CurrenDeleteMenu = DeleteMenu;
    }
    public static void ChangeCurrentPlayer(PlayerObjectFacade newCurrentPlayer)
    {
        if (newCurrentPlayer != null)
        {
            CurrentPlayer = newCurrentPlayer;
        }
    }

    public static string GetLinkToAssets(string Key)
    {
        string Result = string.Empty;

        if (CurrentDeffaultMenuLinkToObjectAssets.LinksToAssets.TryGetValue(Key, out string value))
        {
            Result = value;
        }


        return Result;
    }

    public static void Changefailpath(string newfailpath)
    {
        SaveUIInfoPath = Application.persistentDataPath + newfailpath;
    }
    public static void ChangesettingsFailePath(string newSettingsFailePath)
    {
        SettingsSaveInfoPath = Application.persistentDataPath + newSettingsFailePath;
    }
    public static void ChangeCurrentGameSavePath(string newGameSavePath) 
    {
        CurrentGameSavePath = Application.persistentDataPath + newGameSavePath;
    }
    public static void ChangeCurrentTimeValue(float NewTimeValue)
    {
        TimeValue = NewTimeValue;
    }
    public static void ChangeLatestLoadedGameSave(string newLatestLoadedGameSave)
    {
        saveInformation.LatestLoadedSave = newLatestLoadedGameSave;
    }
      
    public static void DisactiveAnotherButton()
    {
        foreach (var i in findUI.FindAllCanvas())
        {
            i.transform.gameObject.GetComponent<GraphicRaycaster>().enabled = false;
        }
    }
    public static void ActivingAnotherButton()
    {
        foreach (var i in findUI.FindAllCanvas())
        {
            i.transform.gameObject.GetComponent<GraphicRaycaster>().enabled = true;
        }
    }
    public static void ReturnTime()
    {
        Time.timeScale = TimeValue;
    }
    
    private static void StartChildren()
    {
        foreach (var i in findUI.FindActivingFacades())
        {
            i.StartFacade();
        }
    }
    private static void LoadChildren()
    {
        foreach (var i in findUI.FindAllFacade())
        {
            i.Load();
        }

        SaveandLoadAnotherassets.Load();
    }
    private static void SaveChildren()
    {
        foreach (var i in findUI.FindAllFacade())
        {
            i.Save();
        }

        SaveandLoadAnotherassets.Save();
    }

}
