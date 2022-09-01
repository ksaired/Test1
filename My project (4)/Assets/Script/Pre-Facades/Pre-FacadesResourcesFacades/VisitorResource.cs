using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorResource : NPCResource
{
    public override NPCSaveResource SaveNPCInfo { get => SaveVisitorInfo; set => SaveVisitorInfo = (VisitorSaveResource)value; }

    public override TreatmentOfNPCState CurrentNPCTreatmentMainState { get => CurrentVisitorTreatmentMainState; set =>  CurrentVisitorTreatmentMainState = (TreatmentOfMainVisitorState)value; }
    public override TreatmentOfNPCState CurrentNPCTreatmentState { get => CurrentVisitorTreatmentState; set => CurrentVisitorTreatmentState = (TreatmentOfVisitorState)value; }

    public override string KindPathToAssetsForResource { get => ResourceKindPathToAssetsForResource + NPCResourceKindPathToAssetsForResource + VisitorResourceKindPathToAssetsForResource; protected set => base.KindPathToAssetsForResource = value; }

    public virtual VisitorSaveResource SaveVisitorInfo { get; set; }

    public TreatmentOfMainVisitorState CurrentVisitorTreatmentMainState = new TreatmentOfMainVisitorState();
    public TreatmentOfVisitorState CurrentVisitorTreatmentState = new TreatmentOfTestVisitorState();

    protected string VisitorResourceKindPathToAssetsForResource = SceneInfo.GetLinkToAssets("VisitorResourceKindPathToAssetsForResource");
}
