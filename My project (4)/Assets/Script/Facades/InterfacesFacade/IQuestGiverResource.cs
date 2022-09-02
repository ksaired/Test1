using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestGiverResource 
{
    public abstract IQuestGiverSaveResource CurrentQuestGiverSaveInfo { set; get; }
        
    public abstract string QuestGiverLoadKindPath { set; get; }


    public abstract bool AddToTaskForGive(TaskFacade NewTaskFacade);

    public abstract bool RemoveFromTaskForGive(TaskFacade RemoveTaskFacade);

    public abstract bool AddToGivedTask(TaskFacade NewTaskFacade);

    public abstract bool RemoveFromGivedTask(TaskFacade RemoveTaskFacade);

    public abstract void ChangeLimitOfTaskforGive(int NewLimitOfTaskforGive);

    public abstract void ChangeLimitOfGivedTask(int NewLimitOfGivedTask);
}
