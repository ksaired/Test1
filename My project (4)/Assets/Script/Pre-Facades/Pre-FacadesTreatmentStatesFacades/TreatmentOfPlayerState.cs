using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreatmentOfPlayerState : TreatmentOfStatesFacade
{
    public override Resource currentInfo { get => CurrentPlayerInfo; protected set => CurrentPlayerInfo = (PlayerResource)value; }
    public override List<State> CurrentState { protected get => CurrentPlayerState.ConvertAll(new System.Converter<PlayersState, State>(i => i)); set => CurrentPlayerState = value.ConvertAll(new System.Converter<State, PlayersState>(i => (PlayersState)i)); }

    public override string TreatmentStateKindPath { get => TreatmentStateFacadeKindPath + TreatmentOfPlayerStateKindPath; protected set => base.TreatmentStateKindPath = value; }

    public virtual PlayerResource CurrentPlayerInfo { protected set; get; }
    public virtual List<PlayersState> CurrentPlayerState { set; get; }
        

    protected string TreatmentOfPlayerStateKindPath = "TreatmentOfPlayerStateKindPath";

    public override void AddToCurrentState(State NewState)
    {
        PlayersState newState = (PlayersState)NewState;

        if (!CurrentPlayerState.Contains(newState))
        {
            CurrentPlayerState.Add(newState);
        }

        CurrentStateCount = CurrentPlayerState.Count;
    }
    public override void RemoveFromCurrentState(State RemoveState)
    {
        PlayersState removeState = (PlayersState)RemoveState;

        if (CurrentPlayerState.Contains(removeState))
        {
            CurrentPlayerState[CurrentPlayerState.IndexOf(removeState)].StopState();

            CurrentPlayerState.Remove(removeState);
        }

        CurrentStateCount = CurrentPlayerState.Count;
    }
    public override List<State> TakeCurrentState()
    {
        return CurrentPlayerState.ConvertAll(new System.Converter<PlayersState, State>(i => i));
    }
       
}
