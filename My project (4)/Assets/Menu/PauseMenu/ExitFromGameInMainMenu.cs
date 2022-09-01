using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFromGameInMainMenu : UiFacade
{
    private string DeffaultLinkToMainMenu = "MainMenu";

    public void ExitinMainMenu()
    {       
        SceneInfo.SaveInfo();

        LoadMainMenu();
    }
    public void LoadMainMenu()
    {
        UIInfo.Save();
        SceneManager.LoadScene(DeffaultLinkToMainMenu);
    }
       
}
