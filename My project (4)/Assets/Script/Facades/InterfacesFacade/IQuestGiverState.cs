using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public interface IQuestGiverState
{
    public abstract IQuestGiverResource CurrentResource { protected set; get; }
    public abstract IQuestTaker CurrentQuestTaskTaker { protected set; get; }

    public abstract TaskFacade CurrentTreatmentTask { protected set; get; }

    public abstract GameObject CurrentGameObject { protected set; get; }
    
    public abstract GameObject TheFirstUiQuestGiverMenu {protected set; get; }
    public abstract GameObject TheSecondaryUiQuestgiverMenu {protected set; get; }
    public abstract GameObject TheThirdUiQuest {protected set; get; }

    public abstract string PreafabsLoadPath { protected set; get; }

    public abstract string UiObjectLinkToTheFirstUiQuestGiverMenu {protected set; get; }
    public abstract string UiObjectLinkToTheSecondaryUiQuestGiverMenu {protected set; get; }
    public abstract string UiObjectLinkToTheThirdUiQuestGiverMenu {protected set; get; }

    public abstract float DistanceBetweenTheFirstUiQuestGiverMenuAndGameObject {protected get; set; }
    public abstract float DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu {protected get; set; }
    public abstract float DistanceBeetwenTheSecondaryUiQuestGiverMenuAndTheThirdUiQuestGiverMenu {protected get; set; }

    public virtual void ChangeDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject(float NewDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject) 
    {
        DistanceBetweenTheFirstUiQuestGiverMenuAndGameObject = NewDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject;
    }
    public virtual void ChangeDistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu(float NewDistanceBetweenTheSecondaryUiQuestGiverMenuAndGameObject)
    {
        DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu = NewDistanceBetweenTheSecondaryUiQuestGiverMenuAndGameObject;
    }
    public virtual void ChangeDistanceBeetwenTheSecondaryUiQuestGiverMenuAndTheThirdUiQuestGiverMenu(float NewDistanceBetweenTheThirdUiQuestGiverMenuAndGameObject)
    {
        DistanceBeetwenTheSecondaryUiQuestGiverMenuAndTheThirdUiQuestGiverMenu = NewDistanceBetweenTheThirdUiQuestGiverMenuAndGameObject;
    }

    public virtual void StartCreateTheFirstMenu()
    {

    }

    public virtual void CreateMenuWithAllTaskForGive()
    {

    }
    public virtual void CreateMenuWithAllGivedTask()
    {

    }
    public virtual void CreateTaskForGiveTable()
    {

    }
    public virtual void CreateGivedTaskTable()
    {

    }

    public virtual void AddTaskToTaskTaker()
    {

    }
    public virtual void RemoveFromCurrentReceivedTask()
    {

    }
    public virtual void CheckOnCompleteTask()
    {

    }

    protected virtual bool CreateTheFirstUiQuestGiverMenu()
    {


        return false;
    }
    protected virtual bool CreateTheSecondaryUiQuestGiverMenu()
    {


        return false;
    }
    protected virtual void CreateTheThirdUiQuestGiverMenu()
    {

    }

    protected virtual void CreateDropDownWithTaskForGive(ref Dropdown CurrentDropDown)
    {

    }
    protected virtual void CreateDropDownWithGivedTask(ref Dropdown CurrentDropDown)
    {

    }
}
