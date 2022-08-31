using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyResource : Resource
{
    public override SaveResource currentSaveInfo { get => SaveEnemyInfo; protected set => SaveEnemyInfo = (EnemySaveInfo)value; }
    public override TreatmentOfStatesFacade CurrentStateFacade { get => CurrentEnemyTreatmentState; protected set => CurrentEnemyTreatmentState = (TreatmentOfEnemyStates)value; }
    public override TreatmentOfStatesFacade CurrentMainStateFacade { get => CurrentEnemyTreatmentMainState; protected set => CurrentEnemyTreatmentMainState = (TreatmentOfEnemyStates)value; }

    public virtual TreatmentOfEnemyStates CurrentEnemyTreatmentState { get; set; }
    public virtual TreatmentOfEnemyStates CurrentEnemyTreatmentMainState { get; set; }
    public virtual EnemySaveInfo SaveEnemyInfo { get; set; }
}
