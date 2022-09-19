using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorTestResource : VisitorResource
{
    public override VisitorSaveResource SaveVisitorInfo { get => SaveVisitorTestInfo; set => SaveVisitorTestInfo = (VisitorTestSaveInfo)value; }

    public override GameObject CurrentObject { get => base.CurrentObject; protected set => base.CurrentObject = value; }

    public override Collider2D[] CurrentColiders { get => base.CurrentColiders; set => base.CurrentColiders = value; }

    public override string ObjectPrefabsLoadKindPath { get => base.ObjectPrefabsLoadKindPath; protected set => base.ObjectPrefabsLoadKindPath = value; }
    public override string ObjectResourcePathToAssetsForResource { get => VisitorObjectResourcePathToAssetsForResource; protected set =>VisitorObjectResourcePathToAssetsForResource = value; }

    public override float SizeOfFirstDetectedCircle { get => DeffaultSizeOfFirstDetectedCircle; set => DeffaultSizeOfFirstDetectedCircle = value; }

    public VisitorTestSaveInfo SaveVisitorTestInfo = new VisitorTestSaveInfo();

    public int Testint;

    public float DeffaultSizeOfFirstDetectedCircle = 2f;

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

    public override void StartResource(GameObject CurrentObject)
    {
        this.CurrentObject = CurrentObject;

        Testint = 0;
    }
}
