using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TreatmentPhysicalVisitorMainState : VisitorMainState
{
    public override VisitorResource CurrentVisitorInfo { get => CurrentVisitorMainResource; set => CurrentVisitorMainResource = GiveNormalValue(value); }

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

        Debug.Log("jssd");

        return this.CurrentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;

        Debug.Log("fdsg");

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
        CurrentVisitorMainResource.CurrentColiders = Physics2D.OverlapCircleAll(CurrentVisitorMainResource.CurrentObject.transform.position,CurrentVisitorMainResource.SizeOfFirstDetectedCircle);
    }

    private VisitorMainResource GiveNormalValue(VisitorResource Value)
    {


      VisitorResource VoidResource = (VisitorResource)Value.ConvertTo(typeof(NPCResource));

      Debug.Log(VoidResource.GetType());

      VisitorMainResource ReturnResource = (VisitorMainResource)VoidResource;

      Debug.Log(ReturnResource.GetType());

      return ReturnResource;

    }
}
