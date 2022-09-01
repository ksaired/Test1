using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoadTreeState : PlayersState
{
    public PlayerResource CurrentPlayerTestInfo;

    private string PlayerTreeLoadStatePath = "PlayerTreeLoadStatePath";

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerTestInfo; set => CurrentPlayerTestInfo = value; }

    public override string StatePath { get => PlayerTreeLoadStatePath; protected set => PlayerTreeLoadStatePath = value; }

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
        
        CurrentPlayerTestInfo.CurrentTree.StartFacade();

        return this.CurrentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;
       
        CurrentPlayerTestInfo.CurrentTree.UpdateFacade();
        
        return this.CurrentInfo;
    }

    public override void StopState()
    {
        CurrentPlayerTestInfo.CurrentTree.ReturnAllLevelOfLoadToBaseState();
    }
}
