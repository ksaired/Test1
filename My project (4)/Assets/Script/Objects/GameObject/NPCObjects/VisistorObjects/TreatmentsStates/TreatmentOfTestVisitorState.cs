using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentOfTestVisitorState : TreatmentOfVisitorState
{
    public VisitorTestResource CurrentVisitorTestInfo;

    public override List<VisitorState> CurrentVisitorState { get => DeffaultStates; protected set => DeffaultStates = value; }
    public override VisitorResource CurrentVisitorInfo { get => CurrentVisitorTestInfo; set => CurrentVisitorTestInfo = (VisitorTestResource)value; }

    public override string TreatmentStatePath { get => TreatmentOfVisitorTestPath; protected set => base.TreatmentStatePath = value; }

    public string TreatmentOfVisitorTestPath = "/TreatmentOfVisitorTestFacade";

    public List<VisitorState> DeffaultStates = new List<VisitorState>
    {
       new VisitorTestState()
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
        if (CurrentVisitorTestInfo.CurrentVisitorTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentVisitorTestInfo.CurrentVisitorTreatmentState.CurrentVisitorState.Contains(CurrentVisitorState[i]))
                {
                    currentInfo = CurrentVisitorState[i].UpdateFacade(CurrentVisitorTestInfo);
                    CurrentStateCount = CurrentVisitorState.Count;
                }
            }
        }
    }

    private void UpdateStates()
    {
        if (CurrentVisitorTestInfo.CurrentVisitorTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentVisitorTestInfo.CurrentVisitorTreatmentState.CurrentVisitorState.Contains(CurrentVisitorState[i]))
                {
                    currentInfo = CurrentVisitorState[i].UpdateFacade(CurrentVisitorTestInfo);
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
