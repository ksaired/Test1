using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneInfo 
{
   public static string SettingsSavePath { private set ; get ;} 
   public static string SaveInfoPath { private set; get; }
   public static string GameSaveInfoScenePath { private set ; get ;}
   public static string GameSaveInfoPath { private set; get; }

   public static GameSaveInfo CurrentGameSaveInfo { private set; get; }
   public static GameSaveSceneInfo CurrentGameSceneInfo { private set; get; }
   public static SettingSaveInfo CurrentSettingsSaveInfo { private set; get; }
   public static SaveInformation CurrentSaveInfo { private set; get; }
   public static PlayerSpawner CurrentPlayerSpawners { private set; get; }

   public static readonly DeffaultLinkToObjectAssets CurentDeffaultLinkToObjectAssets = new DeffaultLinkToObjectAssets();

   private static FindObjects CurrentFindObject = new FindObjects();
   private static SaveAndLoad saveAndLoadScript = new SaveAndLoad();

   private static DeffaultSettingsInfo CurrentDeffaultSettingsInfo = new DeffaultSettingsInfo();
   private static DeffaultSaveInfo CurrentDeffaultSaveInfo = new DeffaultSaveInfo();
   private static DeffaultGameSaveInfo CurrentDeffaultGameSaveInfo = new DeffaultGameSaveInfo();
  
   private static string DeffaultSettingsSavePath = "settingssave.grafeteecv18999884744789999";
   private static string DeffaultSaveInfoPath = "save.gamessereecv18999884744789999";
   private static string DeffaultGameSaveInfoScenePath = "GameSaveInfoScenePath178744789999";
   
   public static void StartScene()
   {
        StartSpawners();
        StartPlayersSpawner();
        Debug.Log("1");
   }
   public static void LoadInfo(GameSaveSceneInfo LoadGameSaveSceneInfo)
   {
        Debug.Log(SaveInfoPath);
        SaveInfoPath = Application.persistentDataPath + DeffaultSaveInfoPath;
        SettingsSavePath = Application.persistentDataPath + DeffaultSettingsSavePath;
        GameSaveInfoScenePath = Application.persistentDataPath + DeffaultGameSaveInfoScenePath;

        CurrentGameSceneInfo = LoadGameSaveSceneInfo;
        CurrentSaveInfo = saveAndLoadScript.Load(new SaveInformation(CurrentDeffaultSaveInfo), SaveInfoPath);
        CurrentGameSaveInfo = saveAndLoadScript.Load(new GameSaveInfo(CurrentDeffaultGameSaveInfo), Application.persistentDataPath + CurrentSaveInfo.LatestLoadedSave);
        CurrentSettingsSaveInfo = saveAndLoadScript.Load(new SettingSaveInfo(CurrentDeffaultSettingsInfo),SettingsSavePath);
        
        Debug.Log(CurrentGameSaveInfo.Test);

        GameSaveInfoPath = CurrentSaveInfo.LatestLoadedSave;

        LoadSpawnerFacades();
        LoadPlayerSpawnerInfo();
   }
   public static void SaveInfo()
   {
        SaveSpawnersInfo();
        SavePlayerSpawnerInfo();
                
        saveAndLoadScript.Save(CurrentGameSceneInfo,GameSaveInfoScenePath);

        saveAndLoadScript.Save(CurrentGameSaveInfo,GameSaveInfoPath);
   }
  
   public static void ChangeGameSaveInfo(GameSaveInfo NewGameSaveInfo)
   {
        CurrentGameSaveInfo = NewGameSaveInfo;
   }
   public static void ChangeGameSceneSaveInfo(GameSaveSceneInfo NewGameSceneInfo)
   {
      CurrentGameSceneInfo = NewGameSceneInfo;
   }
   public static void ChangeSettingsSaveInfo(SettingSaveInfo NewSettingsSaveInfo)
   {
        CurrentSettingsSaveInfo = NewSettingsSaveInfo;
   }
   public static void ChangeSaveInfo(SaveInformation NewSaveInfo)
   {
        CurrentSaveInfo = NewSaveInfo;
   }
   public static void ChangeSettingsSavePath(string NewSettingsSavePath)
   {
       SettingsSavePath = Application.persistentDataPath + NewSettingsSavePath;
   }
   public static void ChangeSaveInfoPath(string NewSaveInfoPath)
   {
        SaveInfoPath = Application.persistentDataPath + NewSaveInfoPath;
   }
   public static void ChangeGameSavePath(string NewGameSaveInfoPath)
   {
        GameSaveInfoPath = Application.persistentDataPath + NewGameSaveInfoPath;
   }
   public static void ChangeGameSaveScenePath(string NewGameSaveInfoScenePath)
   {
        GameSaveInfoScenePath = Application.persistentDataPath + NewGameSaveInfoScenePath;
   }
   public static void ChangePlayerSpawner(PlayerSpawner NewPlayerSpawner)
   {
        CurrentPlayerSpawners = NewPlayerSpawner;
   }

   public static string GetLinkToAssets(string Key)
   {
        string Result = string.Empty;

        if (CurentDeffaultLinkToObjectAssets.LinksToAssets.TryGetValue(Key, out string value))
        {
            Result = value;
        }
       
        
        return Result;
   }

   private static void LoadSpawnerFacades()
   {
        foreach (var i in  CurrentFindObject.FindSpawners())
        {
           if (CurrentGameSceneInfo.SpawnersInfo.TryGetValue(i.LoadSpawnInfoPath,out SpawnSaveInfo CurrentInfo) )
           {
                i.LoadSpawnInfo(CurrentInfo);
           }
           else
           {
                i.LoadDeffaultSpawnInfo();
           }
        }
   }
   private static void LoadPlayerSpawnerInfo()
   {
        foreach (var i in CurrentFindObject.FindPlayerSpawners())
        {
            if (CurrentGameSceneInfo.PlayerSpawnersInfo.TryGetValue(i.CurrentPlayerSpawnerPath, out PlayerSpawnInfo CurrentPlayerSpawnInfo))
            {
                i.LoadPlayerSpawnInfo(CurrentPlayerSpawnInfo);
            }
            else
            {
                i.DeffaultPlayerSpawnInfo();
            }
        }
   }
   private static void StartSpawners()
   {
      foreach (var i in CurrentFindObject.FindSpawners())
      {
         i.StartFacade();
      }
   }
   private static void StartPlayersSpawner()
   {
       CurrentFindObject.FindPlayerSpawner(CurrentPlayerSpawners).StartFacade();
        
}
   private static void SaveSpawnersInfo()
   {
        foreach (var i in CurrentFindObject.FindSpawners())
        {
           if (CurrentGameSceneInfo.SpawnersInfo.ContainsKey(i.LoadSpawnInfoPath))
           {
              CurrentGameSceneInfo.SpawnersInfo.Remove(i.LoadSpawnInfoPath);
              CurrentGameSceneInfo.SpawnersInfo.Add(i.LoadSpawnInfoPath,i.SaveSpawnInfo());
           }
           else
           {
              CurrentGameSceneInfo.SpawnersInfo.Add(i.LoadSpawnInfoPath, i.SaveSpawnInfo());
           }
        }
   }
    private static void SavePlayerSpawnerInfo()
    {
        foreach (var i in CurrentFindObject.FindPlayerSpawners())
        {
            if (CurrentGameSceneInfo.PlayerSpawnersInfo.ContainsKey(i.CurrentPlayerSpawnerPath))
            {
                CurrentGameSceneInfo.PlayerSpawnersInfo.Remove(i.CurrentPlayerSpawnerPath);
                CurrentGameSceneInfo.PlayerSpawnersInfo.Add(i.CurrentPlayerSpawnerPath,i.CurrentPlayerSpawnInfo);
            }
            else
            {
                CurrentGameSceneInfo.PlayerSpawnersInfo.Add(i.CurrentPlayerSpawnerPath, i.CurrentPlayerSpawnInfo);
            }
        }

        SavePlayersInfo();
    }

    private static void SavePlayersInfo()
    {
       CurrentGameSaveInfo = CurrentFindObject.FindPlayerSpawner(CurrentPlayerSpawners).SavePlayerInfo(CurrentGameSaveInfo);
    }
}
