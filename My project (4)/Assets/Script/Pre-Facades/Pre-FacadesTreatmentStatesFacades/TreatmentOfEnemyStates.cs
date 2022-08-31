using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreatmentOfEnemyStates : TreatmentOfStatesFacade
{
    public override Resource currentInfo { get => CurrentEnemyInfo; protected set => CurrentEnemyInfo = (EnemyResource)value; }
       
    public override List<State> CurrentState { protected get => CurrentEnemyState.ConvertAll(new System.Converter<EnemyStates, State>(i => i)); set => CurrentEnemyState = value.ConvertAll(new System.Converter< State,EnemyStates>(i => (EnemyStates)i)); }

    public override string TreatmentStateKindPath { get => TreatmentStateFacadeKindPath + TreatmentOfEnemyStateKindPath; protected set => base.TreatmentStateKindPath = value; }

    public virtual EnemyResource CurrentEnemyInfo { set; get; }
    public virtual List<EnemyStates> CurrentEnemyState { protected get; set; }
       

    protected string TreatmentOfEnemyStateKindPath = SceneInfo.GetLinkToAssets("TreatmentOfEnemyStateKindPath");

    public List<EnemyStates> TakeCurrentEnemyState()
    {
        return CurrentEnemyState;

    }
}
