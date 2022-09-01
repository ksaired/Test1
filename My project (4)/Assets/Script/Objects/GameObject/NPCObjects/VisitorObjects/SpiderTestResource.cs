using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTestResource : SpiderResource
{
    public override SpiderSaveInfo SaveSpiderInfo { get => SaveSpiderTestInfo; set => SaveSpiderTestInfo = (SpiderSaveTestInfo)value; }
    
    public SpiderSaveTestInfo SaveSpiderTestInfo = new SpiderSaveTestInfo();

    public int Testint;

    public override void ChangeCurrentMainTreatmentState(TreatmentOfStatesFacade newMainTreatmentState)
    {
        base.ChangeCurrentMainTreatmentState(newMainTreatmentState);
    }
    public override void ChangeCurrentTreatmentState(TreatmentOfStatesFacade newTreatmentState)
    {
        base.ChangeCurrentTreatmentState(newTreatmentState);
    }
    public override void ChangeSaveInfo(SaveResource newSaveInfo)
    {
        base.ChangeSaveInfo(newSaveInfo);
    }
    public override void ChangeTestLoadTree(int NewTestLoadTree)
    {
        base.ChangeTestLoadTree(NewTestLoadTree);
    }
    
    public override void StartResource()
    {
        Testint = 0;
    }
}
