using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class TaskFacade : MonoBehaviour
{
    public virtual string TaskPrefabsLoadKindPath { protected set; get; }
    public virtual string TaskTablePrefabsLoadPath { protected set; get; }

    public virtual GameObject TaskTableObject { protected set; get; }

    public virtual string NameOfTask { protected set; get; }
    public virtual string DescriptionOfTask { protected set; get; }

    protected string TaskFacadePrefabsLoadKindPath = SceneInfo.GetLinkToAssets("TaskFacadePrefabsLoadKindPath");

    public virtual void ChangeNameOfTask(string NewNameOfTask)
    {
        NameOfTask = NewNameOfTask;
    }

    public virtual void ChangeDescriptionOfTask(string NewDescriptionOfTask)
    {
        DescriptionOfTask = NewDescriptionOfTask;
    }

    public virtual GameObject CreateCurrentTaskTable()
    {
        return Resources.Load<GameObject>(TaskPrefabsLoadKindPath + TaskTablePrefabsLoadPath);
    }

    public abstract void StartTask();

    public abstract bool CheckOfGoal(IQuestTaker CurrentQuestTaker);

    public abstract bool CheckOfCompleteTask(ref IQuestTaker CurrentQuestTaker,ref IQuestGiverResource CurrentGiverresource);
    
    protected abstract bool TakeReward(ref IQuestTaker CurrentQuestTaker);

}
