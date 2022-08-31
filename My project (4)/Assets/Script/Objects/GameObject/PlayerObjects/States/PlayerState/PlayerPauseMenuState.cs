using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPauseMenuState : PlayerMainState
{
    public PlayerResource CurrentPlayerMainInfo;

    private string PlayerPauseStatePath = "PlayerPauseStatePath";

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerMainInfo; set => CurrentPlayerMainInfo = value; }

    public override string StatePath { get => PlayerPauseStatePath; protected set => PlayerPauseStatePath = value; }

    public GameObject CurrentPauseMenu;

    private FindObjects findObjects = new FindObjects();

    public override void ChangeCurrentInfo(Resource newInfo)
    {
        base.ChangeCurrentInfo(newInfo);
    }
    public override void ChangeStatePath(string NewStatePath)
    {
        base.ChangeStatePath(NewStatePath);
    }
    public override Resource StartFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;

        return this.CurrentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            LoadPauseMenu();
        }

        return this.CurrentInfo;
    }

    public override void StopState()
    {
        if (!CurrentPlayerMainInfo.IsOpenPauseMenu)
        {
          Time.timeScale = 0;

          if(CurrentPauseMenu != null)  Destroy(CurrentPauseMenu);

          CurrentPlayerMainInfo.IsOpenPauseMenu = true;
        }
    }

    private void LoadPauseMenu()
    {
        if (CurrentPlayerMainInfo.IsOpenPauseMenu)
        {
           CurrentPauseMenu = Resources.Load<GameObject>("Prefabs/MenuPrefabs/" + CurrentPlayerMainInfo.PauseMenuLoadPath);

           CurrentPauseMenu = Instantiate(CurrentPauseMenu, CurrentPauseMenu.transform.parent);

           UIInfo.ChangeCurrentPlayer(CurrentPlayerInfo.CurrentPlayer);

           Time.timeScale = 0;

            CurrentPlayerMainInfo.IsOpenPauseMenu = false;          
        }
                      
    }

}
