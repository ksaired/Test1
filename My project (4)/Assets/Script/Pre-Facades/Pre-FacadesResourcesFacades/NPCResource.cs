using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCResource : Resource
{
    public override SaveResource currentSaveInfo { get => SaveNPCInfo; protected set => SaveNPCInfo = (NPCSaveResource)value; }
    public override TreatmentOfStatesFacade CurrentStateFacade { get => CurrentNPCTreatmentState; protected set => CurrentNPCTreatmentState = (TreatmentOfNPCState)value; }
    public override TreatmentOfStatesFacade CurrentMainStateFacade { get => CurrentNPCTreatmentMainState; protected set => CurrentNPCTreatmentMainState = (TreatmentOfNPCState)value; }
    public override string KindPathToAssetsForResource { get => ResourceKindPathToAssetsForResource + NPCResourceKindPathToAssetsForResource; protected set => base.KindPathToAssetsForResource = value; }
    public virtual TreatmentOfNPCState CurrentNPCTreatmentState { get; set; }
    public virtual TreatmentOfNPCState CurrentNPCTreatmentMainState { get; set; }
    public virtual NPCSaveResource SaveNPCInfo { get; set; }

    protected string NPCResourceKindPathToAssetsForResource = SceneInfo.GetLinkToAssets("NPCResourceKindPathToAssetsForResource");
}
