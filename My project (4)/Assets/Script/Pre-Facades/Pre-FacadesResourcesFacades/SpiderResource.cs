using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpiderResource : EnemyResource
{
    public override EnemySaveInfo SaveEnemyInfo { get => SaveSpiderInfo; set => SaveSpiderInfo = (SpiderSaveInfo)value; }
    public override TreatmentOfEnemyStates CurrentEnemyTreatmentState { get => CurrentSpiderTreatmentState; set => CurrentSpiderTreatmentState = (TreatmentOfSpiderStates)value; }
    public override TreatmentOfEnemyStates CurrentEnemyTreatmentMainState { get => CurrentSpiderTreatmentMainState; set => CurrentSpiderTreatmentMainState = (TreatmentOfMainSpiderState)value; }
               
    public virtual SpiderSaveInfo SaveSpiderInfo { get; set; }
    
    public TreatmentOfMainSpiderState CurrentSpiderTreatmentMainState = new TreatmentOfMainSpiderState();
    public TreatmentOfSpiderStates CurrentSpiderTreatmentState = new TreatmentOfSpiderTestFacade();

}
