using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoseOfDifficult : ActiveFacade
{
    private string CurrentGameSavePath = "GameSave1";

    private SaveAndLoad SaveAndLoadScript = new SaveAndLoad();
    
    private GameSaveInfo CurrentGameInfo = new GameSaveInfo(new DeffaultGameSaveInfo());
         
    public override void StartFacade()
    {
        StartChildrenfacade();
    }
    public override void Load()
    {
        CurrentGameSavePath = UIInfo.CurrentGameSavePath;
        CurrentGameInfo = SaveAndLoadScript.Load(CurrentGameInfo,CurrentGameSavePath);
    }
    public override void Save()
    {
        SaveAndLoadScript.Save(CurrentGameInfo, CurrentGameSavePath);
    }

    public void ChoseDifficult(LevelOfDificult currentDifficult)
    {
        CurrentGameInfo.DefficultOfGame = currentDifficult.LevelOf;
        CreateNewGameSaveInfo();
    }

    private void StartChildrenfacade()
    {
        foreach (var i in gameObject.GetComponentsInChildren<LevelOfDificult>())
        {
            i.StartFacade();
        }
    }
  
    private void CreateNewGameSaveInfo()
    {
        UIInfo.Save();
        SceneManager.LoadScene(CurrentGameInfo.LatestLevel);
    }

    
}
