using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;


public interface IQuestGiverState
{
    public abstract IQuestGiverResource CurrentResource { protected set; get; }
    public abstract List<TaskFacade> CurrentTreatmentTasks { protected set; get; }

    public abstract GameObject CurrentQuestTaskTaker { protected set; get; }
    public abstract GameObject CurrentGameObject { protected set; get; }

    public abstract GameObject TheFirstUiQuestGiverMenu { protected set; get; }
    public abstract GameObject TheSecondaryUiQuestgiverMenu { protected set; get; }
    public abstract GameObject TheThirdUiQuest { protected set; get; }
     
    public abstract string PreafabsLoadPath { protected set; get; }

    public abstract string UiObjectLinkToTheFirstUiQuestGiverMenu {protected set; get; }
    public abstract string UiObjectLinkToTheSecondaryUiQuestGiverMenu {protected set; get; }
    public abstract string UiObjectLinkToTheThirdUiQuestGiverMenu {protected set; get; }

    public abstract string LinkToBaseUiButton { protected set; get; }
    public abstract string LinkToDropdownBaseObject { protected set; get; }

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
    public virtual void AddToCurrentTreatmentTask(TaskFacade NewTreatmenTask)
    {
        if (!CurrentTreatmentTasks.Contains(NewTreatmenTask))
        {
            CurrentTreatmentTasks.Add(NewTreatmenTask);
        }
    }
    public virtual void RemoveFromCurrentTreatmentTask(TaskFacade RemoveTreatmenTask)
    {
        if (CurrentTreatmentTasks.Contains(RemoveTreatmenTask))
        {
            CurrentTreatmentTasks.Remove(RemoveTreatmenTask);
        }
    }

    public virtual void StartCreateTheFirstMenu()
    {
        FindCurrentQuestTaskTaker();

        CreateTheFirstMenu();        
    }

    public virtual void CreateMenuWithAllTaskForGive()
    {
        FindCurrentQuestTaskTaker();

        if (CreateTheSecondaryUiQuestGiverMenu())
        {
            GameObject CurrentObjectOfBaseDropDown = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToDropdownBaseObject);

            if (CurrentObjectOfBaseDropDown != null)
            {
                CurrentObjectOfBaseDropDown = Object.Instantiate(CurrentObjectOfBaseDropDown,CurrentObjectOfBaseDropDown.transform.position,Quaternion.identity,TheSecondaryUiQuestgiverMenu.transform.parent);

                Dropdown CurrentDropDownWithAllTaskForGive = CurrentObjectOfBaseDropDown.GetComponentInChildren<Dropdown>();

                if (CurrentDropDownWithAllTaskForGive)
                {
                    CreateDropDownWithTaskForGive(ref CurrentDropDownWithAllTaskForGive);
                }
                else
                {
                    Object.Destroy(CurrentObjectOfBaseDropDown);
                }
            }
        }
    }
    public virtual void CreateMenuWithAllGivedTask()
    {
        FindCurrentQuestTaskTaker();

        if (CreateTheSecondaryUiQuestGiverMenu())
        {
            GameObject CurrentObjectOfBaseDropDown = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToDropdownBaseObject);

            if (CurrentObjectOfBaseDropDown != null)
            {
                CurrentObjectOfBaseDropDown = Object.Instantiate(CurrentObjectOfBaseDropDown, CurrentObjectOfBaseDropDown.transform.position, Quaternion.identity, TheSecondaryUiQuestgiverMenu.transform.parent);

                Dropdown CurrentDropDownWithGivedTask = CurrentObjectOfBaseDropDown.GetComponentInChildren<Dropdown>();

                if (CurrentDropDownWithGivedTask)
                {
                    CreateDropDownWithGivedTask(ref CurrentDropDownWithGivedTask);
                }
                else
                {
                    Object.Destroy(CurrentObjectOfBaseDropDown);
                }
            }
        }
    }
    public virtual void CreateTaskForGiveTable(int NumberOftask)
    {

    }
    public virtual void CreateGivedTaskTable(int NumberOfTask)
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
        GameObject CurrentTheFirstUiQuestGiverMenu = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + UiObjectLinkToTheFirstUiQuestGiverMenu);

        if (CurrentTheFirstUiQuestGiverMenu != null)
        {
            if (CurrentGameObject.transform.position.x <= CurrentQuestTaskTaker.transform.position.x)
            {
                TheFirstUiQuestGiverMenu = Object.Instantiate(CurrentTheFirstUiQuestGiverMenu,new Vector3(CurrentGameObject.transform.position.x + DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu,CurrentGameObject.transform.position.y),Quaternion.identity,CurrentGameObject.transform);
                return true;
            }
            else if (CurrentGameObject.transform.position.x >= CurrentQuestTaskTaker.transform.position.x)
            {
                TheFirstUiQuestGiverMenu = Object.Instantiate(CurrentTheFirstUiQuestGiverMenu, new Vector3(CurrentGameObject.transform.position.x - DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu, CurrentGameObject.transform.position.y), Quaternion.identity, CurrentGameObject.transform);

                return true;
            }
        }

        return false;
    }
    protected virtual bool CreateTheSecondaryUiQuestGiverMenu()
    {
        GameObject CurrentTheSecondaryUiQuestGiverMenu = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + UiObjectLinkToTheSecondaryUiQuestGiverMenu);

        if (CurrentTheSecondaryUiQuestGiverMenu != null)
        {
            if (TheFirstUiQuestGiverMenu.transform.position.x <= CurrentQuestTaskTaker.transform.position.x)
            {
                TheSecondaryUiQuestgiverMenu = Object.Instantiate(CurrentTheSecondaryUiQuestGiverMenu, new Vector3(TheFirstUiQuestGiverMenu.transform.position.x + DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu, CurrentGameObject.transform.position.y), Quaternion.identity, CurrentGameObject.transform);
                return true;
            }
            else if (TheFirstUiQuestGiverMenu.transform.position.x >= CurrentQuestTaskTaker.transform.position.x)
            {
                TheSecondaryUiQuestgiverMenu = Object.Instantiate(CurrentTheSecondaryUiQuestGiverMenu, new Vector3(TheFirstUiQuestGiverMenu.transform.position.x - DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu, CurrentGameObject.transform.position.y), Quaternion.identity, CurrentGameObject.transform);

                return true;
            }
        }


        return false;
    }
    protected virtual void CreateTheThirdUiQuestGiverMenu()
    {
        GameObject CurrentTheThirdUiQuestGiverMenu = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + UiObjectLinkToTheThirdUiQuestGiverMenu);

        if (CurrentTheThirdUiQuestGiverMenu != null)
        {
            if (TheSecondaryUiQuestgiverMenu.transform.position.x <= CurrentQuestTaskTaker.transform.position.x)
            {
                TheThirdUiQuest = Object.Instantiate(CurrentTheThirdUiQuestGiverMenu, new Vector3(TheSecondaryUiQuestgiverMenu.transform.position.x + DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu, CurrentGameObject.transform.position.y), Quaternion.identity, CurrentGameObject.transform);
            }
            else if (TheSecondaryUiQuestgiverMenu.transform.position.x >= CurrentQuestTaskTaker.transform.position.x)
            {
                TheThirdUiQuest = Object.Instantiate(CurrentTheThirdUiQuestGiverMenu, new Vector3(TheSecondaryUiQuestgiverMenu.transform.position.x - DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu, CurrentGameObject.transform.position.y), Quaternion.identity, CurrentGameObject.transform);
            }
        }

    }

    protected void CreateDropDownWithTaskForGive(ref Dropdown CurrentDropDown)
    {
        List<Dropdown.OptionData> CurrentOptionData = new List<Dropdown.OptionData>();

        foreach (var i in CurrentResource.CurrentQuestGiverSaveInfo.TaskForGive)
        {
            if (!CurrentQuestTaskTaker.GetComponentInChildren<IQuestTaker>().CurrentIQuestTakerResource.CurrentQuestTakerSaveInfo.ReceivedTask.Contains(i))
            {
                Dropdown.OptionData Optiondata = new Dropdown.OptionData();

                Optiondata.text = i.name;

                CurrentOptionData.Add(Optiondata);

                AddToCurrentTreatmentTask(i);
            }
        }

        if (CurrentOptionData.Count > 0)
        {
            CurrentDropDown.AddOptions(CurrentOptionData);

            CurrentDropDown.onValueChanged.AddListener(CreateTaskForGiveTable);
        }

    }
    protected void CreateDropDownWithGivedTask(ref Dropdown CurrentDropDown)
    {
        List<Dropdown.OptionData> CurrentOptionData = new List<Dropdown.OptionData>();

        foreach (var i in CurrentResource.CurrentQuestGiverSaveInfo.GivedTask)
        {
            if (CurrentQuestTaskTaker.GetComponentInChildren<IQuestTaker>().CurrentIQuestTakerResource.CurrentQuestTakerSaveInfo.ReceivedTask.Contains(i))
            {
                Dropdown.OptionData Optiondata = new Dropdown.OptionData();

                Optiondata.text = i.name;

                CurrentOptionData.Add(Optiondata);

                AddToCurrentTreatmentTask(i);
            }
        }

        if (CurrentOptionData.Count > 0)
        {
            CurrentDropDown.AddOptions(CurrentOptionData);

            CurrentDropDown.onValueChanged.AddListener(CreateGivedTaskTable);
        }
    }

    protected void FindCurrentQuestTaskTaker()
    {
       
    }

    protected void SettingsButton(ref Button CurrentButton,string ButtonText, UnityAction FuncForCall)
    {
        CurrentButton.onClick.AddListener(FuncForCall);

        if (CurrentButton.gameObject.GetComponent<Text>())
        {
            CurrentButton.gameObject.GetComponent<Text>().text = ButtonText;
        }
                
    }

    protected bool CreateTheFirstMenu()
    {
        if (CreateTheFirstUiQuestGiverMenu())
        {
            GameObject CurrentObjectOfBaseButton = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToBaseUiButton);

            if (CurrentObjectOfBaseButton != null)
            {
                GameObject CurrentObjectOfButtonCreateMenuWithAllTaskForGive = Object.Instantiate(CurrentObjectOfBaseButton, CurrentObjectOfBaseButton.transform.position, Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                Button CurrentButtonCreateMenuWithAllTaskForGive = CurrentObjectOfButtonCreateMenuWithAllTaskForGive.GetComponentInChildren<Button>();

                if (CurrentButtonCreateMenuWithAllTaskForGive != null)
                {
                    SettingsButton(ref CurrentButtonCreateMenuWithAllTaskForGive, "TaskForGive", CreateMenuWithAllTaskForGive);
                }
                else
                {
                    Object.Destroy(CurrentObjectOfButtonCreateMenuWithAllTaskForGive);

                    return false;
                }


                GameObject CurrentObjectOfButtonCreateMenuWithGivedTask = Object.Instantiate(CurrentObjectOfBaseButton, new Vector3(CurrentObjectOfBaseButton.transform.position.x, CurrentObjectOfButtonCreateMenuWithAllTaskForGive.transform.position.y - 1), Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                Button CurrentButtonCreateMenuWithGivedTask = CurrentObjectOfButtonCreateMenuWithGivedTask.GetComponentInChildren<Button>();

                if (CurrentButtonCreateMenuWithGivedTask != null)
                {
                    SettingsButton(ref CurrentButtonCreateMenuWithGivedTask, "GivedTask", CreateMenuWithAllGivedTask);
                }
                else
                {
                    Object.Destroy(CurrentObjectOfButtonCreateMenuWithGivedTask);

                    return false;
                }

                return true;
            }
                        
        }

        return false;
    }
}
