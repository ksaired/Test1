using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayersState
{
    public PlayerResource CurrentPlayerTestInfo;

    private string PlayerTestStatePath = "PlayerTestStatePath";

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerTestInfo; set => CurrentPlayerTestInfo = value; }

    public override string StatePath { get => PlayerTestStatePath; protected set => PlayerTestStatePath = value; }

    int a = 0;

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
              
        if (Input.GetKeyDown(KeyCode.A))
        {
            a = 15;
            this.CurrentInfo.CurrentStateFacade.RemoveFromCurrentState(this);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            CurrentPlayerTestInfo.currentint = 10;

            a = 115;
            CurrentPlayerTestInfo.SaveInfo.IsTreatmentActive = false;
        }

        

        return this.CurrentInfo;
    }

    public override void StopState()
    {
        Debug.Log("stopstate");
    }
}
