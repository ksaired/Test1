using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistorMainResource : VisitorResource
{
    public override VisitorSaveResource SaveVisitorInfo { get => MainVisitorSaveInfo; set => MainVisitorSaveInfo = (VisitorMainSaveInfo)value; }

    public override GameObject CurrentObject { get => base.CurrentObject; protected set => base.CurrentObject = value; }

    public override string ObjectPrefabsLoadKindPath { get => base.ObjectPrefabsLoadKindPath; protected set => base.ObjectPrefabsLoadKindPath = value; }
    public override string ObjectResourcePathToAssetsForResource { get => VisitorObjectResourcePathToAssetsForResource; protected set => VisitorObjectResourcePathToAssetsForResource = value; }

    public override float SizeOfFirstCircleDetecter { get => DeffaultSizeOfFirstCircleDetecter; set => DeffaultSizeOfFirstCircleDetecter = value; }

    public override Collider2D[] CurrentColiders { get => base.CurrentColiders; set => base.CurrentColiders = value; }


    public VisitorMainSaveInfo MainVisitorSaveInfo = new VisitorMainSaveInfo();

    public int Testint;

    private string VisitorObjectResourcePathToAssetsForResource = "/VisitorAssets";

    private float DeffaultSizeOfFirstCircleDetecter = 2f;

    public override bool AddToGivedTask(TaskFacade NewTaskFacade)
    {
        return base.AddToGivedTask(NewTaskFacade);
    }
    public override bool RemoveFromGivedTask(TaskFacade RemoveTaskFacade)
    {
        return base.RemoveFromGivedTask(RemoveTaskFacade);
    }

    public override bool AddToTaskForGive(TaskFacade NewTaskFacade)
    {
        return base.AddToTaskForGive(NewTaskFacade);
    }
    public override bool RemoveFromTaskForGive(TaskFacade RemoveTaskFacade)
    {
        return base.RemoveFromTaskForGive(RemoveTaskFacade);
    }

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
    public override void ChangeIsActiveTreatmentStateBool(bool NewValue)
    {
        base.ChangeIsActiveTreatmentStateBool(NewValue);
    }
    public override void ChangeLimitOfGivedTask(int NewLimitOfGivedTask)
    {
        base.ChangeLimitOfGivedTask(NewLimitOfGivedTask);
    }
    public override void ChangeLimitOfTaskforGive(int NewLimitOfTaskforGive)
    {
        base.ChangeLimitOfTaskforGive(NewLimitOfTaskforGive);
    }
    public override void ChangeSizeOfFirstCircleDetecter(float NewSizeOfFirstCircleDetecter)
    {
        base.ChangeSizeOfFirstCircleDetecter(NewSizeOfFirstCircleDetecter);
    }


    public override void StartResource(GameObject CurrentObject)
    {
        this.CurrentObject = CurrentObject;

        Testint = 0;
    }
}
