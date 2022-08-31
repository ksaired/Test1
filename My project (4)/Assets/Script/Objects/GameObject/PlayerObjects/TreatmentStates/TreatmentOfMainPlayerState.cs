using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentOfMainPlayerState : TreatmentOfPlayerState
{
    public PlayerResource CurrentPlayerMainInfo;

    public override List<PlayersState> CurrentPlayerState { get => DeffaultMainState.ConvertAll(new System.Converter<PlayerMainState, PlayersState>(i => i)); set => DeffaultMainState = value.ConvertAll(new System.Converter<PlayersState,PlayerMainState>(i => (PlayerMainState)i)); }
    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerMainInfo; protected set => CurrentPlayerMainInfo = value; }

    public override string TreatmentStatePath { get => TreatmentOfPlayerMainStatePath; protected set => base.TreatmentStatePath = value; }

    public string TreatmentOfPlayerMainStatePath = "/TreatmentOfMainPlayerStates";

    public List<PlayerMainState> DeffaultMainState = new List<PlayerMainState>()
    {
         new PlayerPauseMenuState()
    };

    public override Resource StartFacade(Resource CurrentInfo)
    {
        currentInfo = CurrentInfo;
        CurrentStateCount = CurrentPlayerState.Count;

        StartStates();

        return currentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        currentInfo = CurrentInfo;

        UpdateStates();

        return currentInfo;
    }

    private void StartStates()
    {
        if (CurrentPlayerMainInfo.CurrentPlayerTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentPlayerMainInfo.CurrentPlayerTreatmentState.CurrentPlayerState.Contains(CurrentPlayerState[i]))
                {
                    currentInfo = CurrentPlayerState[i].StartFacade(CurrentPlayerMainInfo);
                    CurrentStateCount = CurrentPlayerState.Count;
                }
            }
        }
    }

    private void UpdateStates()
    {
        if (CurrentPlayerMainInfo.CurrentPlayerTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentPlayerMainInfo.CurrentPlayerTreatmentState.CurrentPlayerState.Contains(CurrentPlayerState[i]))
                {
                    currentInfo = CurrentPlayerState[i].UpdateFacade(CurrentPlayerMainInfo);
                    CurrentStateCount = CurrentPlayerState.Count;
                }
            }
        }
    }

    public override void ChangeCurrentInfo(Resource NewInfo)
    {
        base.ChangeCurrentInfo(NewInfo);
    }
    public override void AddToCurrentState(State NewState)
    {
        base.AddToCurrentState(NewState);
    }
    public override void RemoveFromCurrentState(State RemoveState)
    {
        base.RemoveFromCurrentState(RemoveState);
    }
    public override List<State> TakeCurrentState()
    {
        return base.TakeCurrentState();
    }
    public override void Load(List<string> CurrentLoadPathState)
    {
        PlayersState CurrentPlayerState;
        foreach (var i in CurrentLoadPathState)
        {
            CurrentPlayerState = Resources.Load<PlayersState>(i);

            AddToCurrentState(CurrentPlayerState);
        }
    }

    public override List<string> Save()
    {
        List<string> StatesPath = new List<string>();

        foreach (var i in CurrentPlayerState)
        {
            StatesPath.Add(i.KindPath + "/" + i.StatePath);
        }

        return StatesPath;
    }

}
