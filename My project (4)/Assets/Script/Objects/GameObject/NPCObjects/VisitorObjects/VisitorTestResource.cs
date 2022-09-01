using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorTestResource : VisitorResource
{
    public override VisitorSaveResource SaveVisitorInfo { get => SaveVisitorTestInfo; set => SaveVisitorTestInfo = (VisitorTestSaveInfo)value; }

    public override string ObjectResourcePathToAssetsForResource { get => VisitorObjectResourcePathToAssetsForResource; protected set =>VisitorObjectResourcePathToAssetsForResource = value; }

    public VisitorTestSaveInfo SaveVisitorTestInfo = new VisitorTestSaveInfo();

    public int Testint;

    private string VisitorObjectResourcePathToAssetsForResource = "/VisitorTestObjectAssets";

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
