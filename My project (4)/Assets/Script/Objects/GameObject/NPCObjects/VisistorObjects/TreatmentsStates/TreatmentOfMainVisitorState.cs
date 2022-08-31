using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentOfMainVisitorState : TreatmentOfVisitorState
{
    public VisitorResource CurrentVisitorMainInfo;

    public override List<VisitorState> CurrentVisitorState { get => DeffaultStates.ConvertAll(new System.Converter<VisitorMainState, VisitorState>(i => i)); protected set => DeffaultStates = value.ConvertAll(new System.Converter<VisitorState, VisitorMainState>(i => (VisitorMainState)i)); }
    public override VisitorResource CurrentVisitorInfo { get => CurrentVisitorMainInfo; set => CurrentVisitorMainInfo = value; }
    public override string TreatmentStatePath { get => TreatmentOfMainSpiderPath; protected set => base.TreatmentStatePath = value; }

    public string TreatmentOfMainSpiderPath = "/TreatmentOfMainSpiderState";
    public List<VisitorMainState> DeffaultStates = new List<VisitorMainState>()
    {

    };
    public override Resource StartFacade(Resource CurrentInfo)
    {
        currentInfo = CurrentInfo;
        CurrentStateCount = CurrentVisitorState.Count;

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
        if (CurrentVisitorMainInfo.CurrentVisitorTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentVisitorMainInfo.CurrentVisitorTreatmentState.CurrentVisitorState.Contains(CurrentVisitorState[i]))
                {
                    currentInfo = CurrentVisitorState[i].UpdateFacade(CurrentVisitorMainInfo);
                    CurrentStateCount = CurrentVisitorState.Count;
                }
            }
        }
    }

    private void UpdateStates()
    {
        if (CurrentVisitorMainInfo.CurrentVisitorTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentVisitorMainInfo.CurrentVisitorTreatmentState.CurrentVisitorState.Contains(CurrentVisitorState[i]))
                {
                    currentInfo = CurrentVisitorState[i].UpdateFacade(CurrentVisitorMainInfo);
                    CurrentStateCount = CurrentVisitorState.Count;
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
        VisitorState CurrentVisitorState;

        foreach (var i in CurrentLoadPathState)
        {
            CurrentVisitorState = Resources.Load<VisitorState>(i);

            AddToCurrentState(CurrentVisitorState);
        }
    }

    public override List<string> Save()
    {
        List<string> StatesPath = new List<string>();

        foreach (var i in CurrentVisitorState)
        {
            StatesPath.Add(i.KindPath + "/" + i.StatePath);
        }

        return StatesPath;
    }
}
