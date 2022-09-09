using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentPhysicalMainState : PlayerMainState
{
    public PlayerResource CurrentPlayerMainInfo;

    private string PlayerPauseStatePath = "TreatmentPhysicalMainStatePath";

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerMainInfo; set => CurrentPlayerMainInfo = value; }

    public override string StatePath { get => PlayerPauseStatePath; protected set => PlayerPauseStatePath = value; }

   
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

        PhysicalSystem();

        return this.CurrentInfo;
    }

    public override void StopState()
    {
        Debug.Log("stopstate");
    }

    protected void PhysicalSystem()
    {
        UpdateRaycast();
    }

    protected void UpdateRaycast()
    {
        CurrentPlayerMainInfo.CurrentColiders = Physics2D.OverlapCircleAll(CurrentPlayerMainInfo.CurrentPlayer.gameObject.transform.position, CurrentPlayerMainInfo.SizeOfFirstCircleDetecter);
    }
}
