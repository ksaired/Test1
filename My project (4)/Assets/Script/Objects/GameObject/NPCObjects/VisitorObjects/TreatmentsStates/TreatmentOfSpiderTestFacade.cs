using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentOfSpiderTestFacade : TreatmentOfSpiderStates
{
    public SpiderTestResource CurrentSpiderTestInfo;

    public override List<SpiderEnemyState> CurrentSpiderEnemyState { get => DeffaultStates; protected set => DeffaultStates = value; }
    public override SpiderResource CurrentSpiderInfo { get => CurrentSpiderTestInfo; set => CurrentSpiderTestInfo = (SpiderTestResource)value; }

    public override string TreatmentStatePath { get => TreatmentOfSpiderTestPath; protected set => base.TreatmentStatePath = value; }

    public string TreatmentOfSpiderTestPath = "/TreatmentOfSpiderTestFacade";

    public List<SpiderEnemyState> DeffaultStates = new List<SpiderEnemyState>()
    {
       new SpiderTestState()
    };
    public override Resource StartFacade(Resource CurrentInfo)
    {
        currentInfo = CurrentInfo;
        CurrentStateCount = CurrentSpiderEnemyState.Count;

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
        if (CurrentSpiderTestInfo.CurrentSpiderTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentSpiderTestInfo.CurrentSpiderTreatmentState.CurrentSpiderEnemyState.Contains(CurrentSpiderEnemyState[i]))
                {
                    currentInfo = CurrentSpiderEnemyState[i].StartFacade(CurrentSpiderTestInfo);
                    CurrentStateCount = CurrentSpiderEnemyState.Count;
                }
            }
        }
    }

    private void UpdateStates()
    {
        if (CurrentSpiderTestInfo.CurrentSpiderTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentSpiderTestInfo.CurrentSpiderTreatmentState.CurrentSpiderEnemyState.Contains(CurrentSpiderEnemyState[i]))
                {
                    currentInfo = CurrentSpiderEnemyState[i].UpdateFacade(CurrentSpiderTestInfo);
                    CurrentStateCount = CurrentSpiderEnemyState.Count;
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
        SpiderEnemyState CurrentSpiderState;

        foreach (var i in CurrentLoadPathState)
        {
            CurrentSpiderState = Resources.Load<SpiderEnemyState>(i);

            AddToCurrentState(CurrentSpiderState);
        }
    }

    public override List<string> Save()
    {
        List<string> StatesPath = new List<string>();

        foreach (var i in CurrentSpiderEnemyState)
        {
            StatesPath.Add(i.KindPath + "/" + i.StatePath);
        }

        return StatesPath;
    }
}
