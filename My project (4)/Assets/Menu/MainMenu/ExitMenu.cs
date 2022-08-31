using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitMenu : UiFacade
{
    public void ExitOutGame()
    {
        UIInfo.Save();
        Application.Quit();
    }
}
