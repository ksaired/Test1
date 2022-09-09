using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestTakerResource 
{
    public abstract IQuestTakerSaveResource CurrentQuestTakerSaveInfo { set; get; }

    public abstract string QuestTakerLoadPrefabsKindPath { get; }

    public abstract bool AddToReceivedTask(TaskFacade NewTaskFacade);

    public abstract bool RemoveFromRecivedTask(TaskFacade RemoveTaskFacade);

    public abstract void ChangeLimitOfReceivedTask(int NewLimitOfReceivedTask);
}
