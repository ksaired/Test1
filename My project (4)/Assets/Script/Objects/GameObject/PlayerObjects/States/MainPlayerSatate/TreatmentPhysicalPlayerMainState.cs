using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentPhysicalPlayerMainState : PlayerMainState
{
    public PlayerResource CurrentPlayerMainInfo;

    private string PlayerTreatmentPhysicalStatePath = "TreatmentPhysicalPlayerMainState";

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerMainInfo; set => CurrentPlayerMainInfo = value; }

    public override string StatePath { get => PlayerTreatmentPhysicalStatePath; protected set => PlayerTreatmentPhysicalStatePath = value; }

   
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

        foreach (var i in CurrentPlayerInfo.CurrentColiders)
        {
            Debug.Log(i.gameObject);
        }
    }

    protected void UpdateRaycast()
    {
        CurrentPlayerMainInfo.CurrentColiders = Physics2D.OverlapCircleAll(CurrentPlayerMainInfo.CurrentObject.transform.position, CurrentPlayerMainInfo.SizeOfFirstCircleDetecter);
    }
}
