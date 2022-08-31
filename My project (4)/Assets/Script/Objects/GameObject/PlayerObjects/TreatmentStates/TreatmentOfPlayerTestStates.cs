using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentOfPlayerTestStates : TreatmentOfPlayerState
{
    public PlayerResource CurrentPlayerTestInfo;
        
    public override List<PlayersState> CurrentPlayerState { get => DeffaultState;  set => DeffaultState = value; }
    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerTestInfo; protected set => CurrentPlayerTestInfo = value; }
        
    public override string TreatmentStatePath { get => TreatmentOfPlayerTestStatePath ; protected set => base.TreatmentStatePath = value; }

    public string TreatmentOfPlayerTestStatePath = "/TreatmentOfPlayerTestStates";

    public List<PlayersState> DeffaultState = new List<PlayersState>()
    {
         new PlayerTestState(),
         new PlayerLoadTreeState()
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
        if (CurrentPlayerTestInfo.CurrentPlayerTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentPlayerTestInfo.CurrentPlayerTreatmentState.CurrentPlayerState.Contains(CurrentPlayerState[i]))
                {
                    currentInfo = CurrentPlayerState[i].StartFacade(CurrentPlayerInfo);
                    CurrentStateCount = CurrentPlayerState.Count;
                }
            }
        }
    }

    private void UpdateStates()
    {
        if (CurrentPlayerTestInfo.CurrentPlayerTreatmentState == this)
        {
            for (int i = 0;i < CurrentStateCount;i++)
            {
                if (CurrentPlayerTestInfo.CurrentPlayerTreatmentState.CurrentPlayerState.Contains(CurrentPlayerState[i]))
                {
                    currentInfo = CurrentPlayerState[i].UpdateFacade(CurrentPlayerInfo);
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

        foreach (var i in CurrentPlayerState )
        {
            StatesPath.Add(i.KindPath + "/" + i.StatePath);
        }

        return StatesPath;
    }
}
