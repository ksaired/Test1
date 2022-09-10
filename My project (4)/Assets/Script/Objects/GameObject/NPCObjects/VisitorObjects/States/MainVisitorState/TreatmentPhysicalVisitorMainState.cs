using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentPhysicalVisitorMainState : VisitorMainState
{
    private string VisitorTreatmentPhysicalStatePath = "TreatmentPhysicalVisitorMainState";
        
    public override string StatePath { get => VisitorTreatmentPhysicalStatePath; protected set => VisitorTreatmentPhysicalStatePath = value; }
    
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

       // foreach (var i in CurrentVistorMainInfo.CurrentColiders)
       // {
       //     Debug.Log(i.gameObject);
       // }
                
    }

    protected void UpdateRaycast()
    {
        CurrentVisitorMainResource.CurrentColiders = Physics2D.OverlapCircleAll(CurrentVisitorMainResource.CurrentObject.transform.position,CurrentVisitorMainResource.SizeOfFirstCircleDetecter);
    }
}
