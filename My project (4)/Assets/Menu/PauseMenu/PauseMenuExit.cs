using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuExit : UiFacade
{
    public void ExitFromPauseMenu()
    {
        UIInfo.Save();
        UIInfo.ReturnTime();

        SceneInfo.ChangeSaveInfo(UIInfo.saveInformation);
        SceneInfo.ChangeSettingsSaveInfo(UIInfo.settingsInformation);

        ChangeOpenPauseMenuBool();

        Destroy(transform.parent.transform.parent.gameObject);
    }

    private void ChangeOpenPauseMenuBool()
    {
        foreach (var i in FindObjectsOfType<PlayerObjectFacade>())
        {
            if (i == UIInfo.CurrentPlayer)
            {
               i.CurrentPlayerInfo.IsOpenPauseMenu = true;
            }
        }
    }
}
