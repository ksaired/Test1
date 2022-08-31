using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreatmentOfSpiderStates : TreatmentOfEnemyStates
{
    public override EnemyResource CurrentEnemyInfo { get => CurrentSpiderInfo; set => CurrentSpiderInfo = (SpiderResource)value; }
    public override List<EnemyStates> CurrentEnemyState { protected get => CurrentSpiderEnemyState.ConvertAll(new System.Converter<SpiderEnemyState, EnemyStates>(i => i)); set => CurrentSpiderEnemyState = value.ConvertAll(new System.Converter<EnemyStates, SpiderEnemyState>(i => (SpiderEnemyState)i)); }

    public override string TreatmentStateKindPath { get => TreatmentStateFacadeKindPath + TreatmentOfEnemyStateKindPath + TreatmentOfSpiderStateKindPath; protected set => base.TreatmentStateKindPath = value; }

    public virtual List<SpiderEnemyState> CurrentSpiderEnemyState { protected set; get; }
    public virtual SpiderResource CurrentSpiderInfo { get; set; }
    
    protected string TreatmentOfSpiderStateKindPath = SceneInfo.GetLinkToAssets("TreatmentOfSpiderStateKindPath");
    public override void AddToCurrentState(State NewState)
    {
        SpiderEnemyState newState = (SpiderEnemyState)NewState;

        if (!CurrentEnemyState.Contains(newState))
        {
            CurrentEnemyState.Add(newState);
        }

        CurrentStateCount = CurrentState.Count;
    }
    public override void RemoveFromCurrentState(State RemoveState)
    {
        SpiderEnemyState removeState = (SpiderEnemyState)RemoveState;
                
        if (CurrentEnemyState.Contains(removeState))
        {
            CurrentEnemyState[CurrentEnemyState.IndexOf(removeState)].StopState();

            CurrentEnemyState.Remove(removeState);
        }

        CurrentStateCount = CurrentState.Count;
    }
    public override List<State> TakeCurrentState()
    {
       return CurrentSpiderEnemyState.ConvertAll(new System.Converter<SpiderEnemyState, State>(i => i));
       
    }

    
}
