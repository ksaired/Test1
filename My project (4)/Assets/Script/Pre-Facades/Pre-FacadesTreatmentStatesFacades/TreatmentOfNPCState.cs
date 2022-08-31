using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreatmentOfNPCState : TreatmentOfStatesFacade
{
    public override Resource currentInfo { get => CurrentNPCInfo; protected set => CurrentNPCInfo = (NPCResource)value; }

    public override List<State> CurrentState { protected get => CurrentNPCState.ConvertAll(new System.Converter<NPCState, State>(i => i)); set => CurrentNPCState = value.ConvertAll(new System.Converter<State, NPCState>(i => (NPCState)i)); }

    public override string TreatmentStateKindPath { get => TreatmentStateFacadeKindPath + TreatmentOfNPCStateKindPath; protected set => base.TreatmentStateKindPath = value; }

    public virtual NPCResource CurrentNPCInfo { set; get; }
    public virtual List<NPCState> CurrentNPCState { protected get; set; }


    protected string TreatmentOfNPCStateKindPath = SceneInfo.GetLinkToAssets("TreatmentOfNPCStateKindPath");

    public List<NPCState> TakeCurrentEnemyState()
    {
        return CurrentNPCState;

    }
}
