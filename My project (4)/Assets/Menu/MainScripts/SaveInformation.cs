using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveInformation 
{
    
    public Dictionary<string, Dictionary<string,string>> DictionaryOfText = new Dictionary<string,Dictionary<string,string>>();
    public Dictionary<string, string> SpritePath = new Dictionary<string, string>();
    public Dictionary<string, string> GameSavePath = new Dictionary<string, string>();
    public Dictionary<string, string> LoadMenuPaths = new Dictionary<string, string>();

    public string LatestLoadedSave;

    public bool IsLoadPlayerSave;

    public int Test ;

   

    public SaveInformation(DeffaultSaveInfo currentSaveInfo)
    {
        DictionaryOfText = currentSaveInfo.DictionaryOfText;
        SpritePath = currentSaveInfo.SpritePath;
        GameSavePath = currentSaveInfo.GameSavePath;
        LatestLoadedSave = currentSaveInfo.LatestLoadedSave;
        LoadMenuPaths = currentSaveInfo.LoadMenuPaths;

        LatestLoadedSave = currentSaveInfo.LatestLoadedSave;

        IsLoadPlayerSave = currentSaveInfo.IsLoadPlayerSave;
    }
}
