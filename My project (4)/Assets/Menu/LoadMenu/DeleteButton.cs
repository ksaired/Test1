using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DeleteButton : UiFacade
{
       
    public void Delete()
    {
        if (File.Exists(UIInfo.CurrentGameSavePath))
        {
            DelateFailes();
            Destroy(transform.parent.gameObject);

            UIInfo.ActivingAnotherButton();
          
            CheckGameSaveInfo();
        }
    }
    private void DelateFailes()
    {
        File.Delete(UIInfo.CurrentGameSavePath);
        File.Delete(UIInfo.CurrentGameSavePath + "SpareSave");
    }
    private void CheckGameSaveInfo()
    {
        foreach (var i in FindObjectsOfType<GameSaveButtonFacade>())
        {
            i.LoadTextOfGameSaveButton();
        }
    }

}
