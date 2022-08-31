using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreatmentOfVisitorState : TreatmentOfNPCState
{
    public override NPCResource CurrentNPCInfo { get =>CurrentVisitorInfo; set => CurrentVisitorInfo = (VisitorResource)value; }
    public override List<NPCState> CurrentNPCState { protected get => CurrentVisitorState.ConvertAll(new System.Converter<VisitorState, NPCState>(i => i)); set => CurrentVisitorState = value.ConvertAll(new System.Converter<NPCState, VisitorState>(i => (VisitorState)i)); }

    public override string TreatmentStateKindPath { get => TreatmentStateFacadeKindPath + TreatmentOfNPCStateKindPath + TreatmentOfVisitorStateKindPath; protected set => base.TreatmentStateKindPath = value; }

    public virtual List<VisitorState> CurrentVisitorState { protected set; get; }
    public virtual VisitorResource CurrentVisitorInfo { get; set; }

    protected string TreatmentOfVisitorStateKindPath = SceneInfo.GetLinkToAssets("TreatmentOfVisitorStateKindPath");
    public override void AddToCurrentState(State NewState)
    {
        VisitorState newState = (VisitorState)NewState;

        if (!CurrentVisitorState.Contains(newState))
        {
            CurrentVisitorState.Add(newState);
        }

        CurrentStateCount = CurrentState.Count;
    }
    public override void RemoveFromCurrentState(State RemoveState)
    {
        VisitorState removeState = (VisitorState)RemoveState;

        if (CurrentVisitorState.Contains(removeState))
        {
            CurrentVisitorState[CurrentVisitorState.IndexOf(removeState)].StopState();

            CurrentVisitorState.Remove(removeState);
        }

        CurrentStateCount = CurrentState.Count;
    }
    public override List<State> TakeCurrentState()
    {
        return CurrentVisitorState.ConvertAll(new System.Converter<VisitorState, State>(i => i));

    }

}
