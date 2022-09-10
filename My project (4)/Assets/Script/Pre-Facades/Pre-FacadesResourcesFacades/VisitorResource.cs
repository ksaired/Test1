using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorResource : NPCResource,IQuestGiverResource
{
    public override NPCSaveResource SaveNPCInfo { get => SaveVisitorInfo; set => SaveVisitorInfo = (VisitorSaveResource)value; }

    public override TreatmentOfNPCState CurrentNPCTreatmentMainState { get => CurrentVisitorTreatmentMainState; set =>  CurrentVisitorTreatmentMainState = (TreatmentOfMainVisitorState)value; }
    public override TreatmentOfNPCState CurrentNPCTreatmentState { get => CurrentVisitorTreatmentState; set => CurrentVisitorTreatmentState = (TreatmentOfVisitorState)value; }

    public override string KindPathToAssetsForResource { get => ResourceKindPathToAssetsForResource + NPCResourceKindPathToAssetsForResource + VisitorResourceKindPathToAssetsForResource; protected set => base.KindPathToAssetsForResource = value; }

    public virtual float SizeOfDetectedCircle { get; set; }

    public virtual IQuestGiverSaveResource CurrentQuestGiverSaveInfo { get; set; }
    
    public virtual VisitorSaveResource SaveVisitorInfo { get; set; }

    public virtual Collider2D[] CurrentColiders { get; set; }

    public string QuestGiverLoadKindPath { get => ObjectPrefabsLoadKindPath; set => ObjectPrefabsLoadKindPath = value; }

    public TreatmentOfMainVisitorState CurrentVisitorTreatmentMainState = new TreatmentOfMainVisitorState();
    public TreatmentOfVisitorState CurrentVisitorTreatmentState = new TreatmentOfTestVisitorState();
       
    protected string VisitorResourceKindPathToAssetsForResource = SceneInfo.GetLinkToAssets("VisitorResourceKindPathToAssetsForResource");

    public virtual bool AddToTaskForGive(TaskFacade NewTaskFacade)
    {
        if (SaveVisitorInfo.TaskForGive.Count <= SaveVisitorInfo.LimitOfTaskforGive)
        {
            if (!SaveVisitorInfo.TaskForGive.Contains(NewTaskFacade))
            {
                SaveVisitorInfo.TaskForGive.Add(NewTaskFacade);

                return true;
            }
        }

        return false;
    }
    public virtual bool RemoveFromTaskForGive(TaskFacade RemoveTaskFacade)
    {
        if (SaveVisitorInfo.TaskForGive.Contains(RemoveTaskFacade))
        {

            SaveVisitorInfo.TaskForGive.Add(RemoveTaskFacade);

            return true;
        }

        return false;
    }

    public virtual bool AddToGivedTask(TaskFacade NewTaskFacade)
    {
        if (SaveVisitorInfo.GivedTask.Count <= SaveVisitorInfo.LimitOfGivedTask)
        {
            if (!SaveVisitorInfo.GivedTask.Contains(NewTaskFacade))
            {
                SaveVisitorInfo.GivedTask.Add(NewTaskFacade);

                return true;
            }
        }

        return false;
    }
    public virtual bool RemoveFromGivedTask(TaskFacade RemoveTaskFacade)
    {
        if (SaveVisitorInfo.GivedTask.Contains(RemoveTaskFacade))
        {

            SaveVisitorInfo.GivedTask.Add(RemoveTaskFacade);

            return true;
        }

        return false;
    }

    public virtual void ChangeLimitOfTaskforGive(int NewLimitOfTaskforGive)
    {
        SaveVisitorInfo.LimitOfTaskforGive = NewLimitOfTaskforGive;
    }
    public virtual void ChangeLimitOfGivedTask(int NewLimitOfGivedTask)
    {
        SaveVisitorInfo.LimitOfGivedTask = NewLimitOfGivedTask;
    }
    
    public virtual void ChangeSizeOfDetectedCircle(float NewSizeOfDetectedCircle)
    {
        SizeOfDetectedCircle = NewSizeOfDetectedCircle;
    }


}
