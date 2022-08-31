using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentOfMainSpiderState : TreatmentOfSpiderStates
{
    public SpiderTestResource CurrentSpiderMainInfo;

    public override List<SpiderEnemyState> CurrentSpiderEnemyState { get => DeffaultStates.ConvertAll(new System.Converter<SpiderEnemyMainState,SpiderEnemyState>(i => i)); protected set => DeffaultStates = value.ConvertAll(new System.Converter<SpiderEnemyState, SpiderEnemyMainState>(i => (SpiderEnemyMainState)i)); }
    public override SpiderResource CurrentSpiderInfo { get => CurrentSpiderMainInfo; set => CurrentSpiderMainInfo = (SpiderTestResource)value; }
    public override string TreatmentStatePath { get => TreatmentOfMainSpiderPath; protected set => base.TreatmentStatePath = value; }

    public string TreatmentOfMainSpiderPath = "/TreatmentOfMainSpiderState";
    public List<SpiderEnemyMainState> DeffaultStates = new List<SpiderEnemyMainState>()
    {
      
    };
    public override Resource StartFacade(Resource CurrentInfo)
    {
        currentInfo = CurrentInfo;
        CurrentStateCount = CurrentState.Count;

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
        if (CurrentSpiderMainInfo.CurrentSpiderTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentSpiderMainInfo.CurrentSpiderTreatmentState.CurrentSpiderEnemyState.Contains(CurrentSpiderEnemyState[i]))
                {
                    currentInfo = CurrentState[i].StartFacade(CurrentSpiderMainInfo);
                    CurrentStateCount = CurrentState.Count;
                }
            }
        }
    }

    private void UpdateStates()
    {
        if (CurrentSpiderMainInfo.CurrentSpiderTreatmentState == this)
        {
            for (int i = 0; i < CurrentStateCount; i++)
            {
                if (CurrentSpiderMainInfo.CurrentSpiderTreatmentState.CurrentSpiderEnemyState.Contains(CurrentSpiderEnemyState[i]))
                {
                    currentInfo = CurrentState[i].UpdateFacade(CurrentSpiderMainInfo);
                    CurrentStateCount = CurrentState.Count;
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
