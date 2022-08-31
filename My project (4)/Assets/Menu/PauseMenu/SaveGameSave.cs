using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGameSave : UiFacade
{
    private SaveAndLoad SaveScript = new SaveAndLoad();

    public void SaveGameSaveInfo()
    {
        SceneInfo.CurrentGameSaveInfo.Test = 14777;
       
        Debug.Log(345566788909);
       
        SaveScript.Save(SceneInfo.CurrentGameSaveInfo, UIInfo.CurrentGameSavePath);
       
        Destroy(transform.parent.transform.parent.gameObject);
        
        UIInfo.ActivingAnotherButton();
    }
}
