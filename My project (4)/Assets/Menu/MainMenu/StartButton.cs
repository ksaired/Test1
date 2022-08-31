using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : UiFacade
{
    private GameSaveInfo gameSaveInfo = new GameSaveInfo(new DeffaultGameSaveInfo());
    private SaveAndLoad LoadScript = new SaveAndLoad();
  
    public void LoadScene()
    {
        LoadGameSaveInfo();
        SceneManager.LoadScene(gameSaveInfo.LatestLevel);
        
    }
    private void LoadGameSaveInfo()
    {
        gameSaveInfo = LoadScript.Load(gameSaveInfo, UIInfo.saveInformation.LatestLoadedSave);
    }
}
