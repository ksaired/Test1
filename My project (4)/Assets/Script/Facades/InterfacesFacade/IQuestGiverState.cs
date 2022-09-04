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
    public abstract TaskFacade CurrentTreatmentTask { protected set; get; }
    public abstract GameObject CurrentTaskTable { protected set; get; }

    public abstract GameObject CurrentQuestTaskTaker { protected set; get; }
    public abstract GameObject CurrentGameObject { protected set; get; }

    public abstract GameObject TheFirstUiQuestGiverMenu { protected set; get; }
    public abstract GameObject TheSecondaryUiQuestgiverMenu { protected set; get; }
    
    public abstract Transform TransformOfExitFromTableButton { protected set; get; }

    public abstract string PreafabsLoadPath { protected set; get; }

    public abstract float DistanceForButtonOnX { protected set; get; }
    public abstract float DistanceForButtonOnY { protected set; get; }

    public abstract string UiObjectLinkToTheFirstUiQuestGiverMenu {protected set; get; }
    public abstract string UiObjectLinkToTheSecondaryUiQuestGiverMenu {protected set; get; }
    

    public abstract string LinkToBaseUiButton { protected set; get; }
    public abstract string LinkToDropdownBaseObject { protected set; get; }

    public abstract float DistanceBetweenTheFirstUiQuestGiverMenuAndGameObject {protected get; set; }
    public abstract float DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu {protected get; set; }
    

    public virtual void ChangeDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject(float NewDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject) 
    {
        DistanceBetweenTheFirstUiQuestGiverMenuAndGameObject = NewDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject;
    }
    public virtual void ChangeDistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu(float NewDistanceBetweenTheSecondaryUiQuestGiverMenuAndGameObject)
    {
        DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu = NewDistanceBetweenTheSecondaryUiQuestGiverMenuAndGameObject;
    }
   
    public virtual void ChangeTransformExitFromTableButton(Transform NewTransformExitFromTableButton)
    {
        TransformOfExitFromTableButton = NewTransformExitFromTableButton;
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

                    GameObject ObjectOfBaseButton = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToBaseUiButton);

                    if (ObjectOfBaseButton != null)
                    {
                        GameObject CurrentObjectOfExitButton = Object.Instantiate(ObjectOfBaseButton, TransformOfExitFromTableButton.position, Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                        CreateButton(ref CurrentObjectOfExitButton, "Exit", DestroyTheSecondaryUiQuestGiverMenu);
                    }
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

                    GameObject ObjectOfBaseButton = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToBaseUiButton);

                    if (ObjectOfBaseButton != null)
                    {
                        GameObject CurrentObjectOfExitButton = Object.Instantiate(ObjectOfBaseButton, TransformOfExitFromTableButton.position, Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                        CreateButton(ref CurrentObjectOfExitButton, "Exit", DestroyTheSecondaryUiQuestGiverMenu);
                    }
                }
                else
                {
                    Object.Destroy(CurrentObjectOfBaseDropDown);
                }
            }

        }
    }
    public virtual void CreateTaskForGiveTable(int NumberOfTask)
    {
        CurrentTreatmentTask = CurrentTreatmentTasks[NumberOfTask];
                
        GameObject CurrentTable = Resources.Load<GameObject>(CurrentTreatmentTask.TaskPrefabsLoadKindPath + CurrentTreatmentTask.TaskTablePrefabsLoadPath);

        if (CurrentTable != null )
        {
            GameObject ObjectOfBaseButton = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToBaseUiButton);

            CurrentTable = Object.Instantiate(CurrentTable,CurrentTable.transform.position,Quaternion.identity,CurrentTable.transform.parent);

            if (ObjectOfBaseButton != null)
            {
                GameObject ObjectOfGiveTaskButton = Object.Instantiate(ObjectOfBaseButton,new Vector3(CurrentTable.transform.position.x - DistanceForButtonOnX,CurrentTable.transform.position.y - DistanceForButtonOnY),Quaternion.identity,CurrentTable.transform);

                CreateButton(ref ObjectOfGiveTaskButton,"GiveTaskButton",AddTaskToTaskTaker);
                               
                GameObject CurrentObjectOfExitButton = Object.Instantiate(ObjectOfBaseButton, TransformOfExitFromTableButton.position, Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                CreateButton(ref CurrentObjectOfExitButton,"Exit",DestroyTable);
                                
            }
        }
    }
    public virtual void CreateGivedTaskTable(int NumberOfTask)
    {
        CurrentTreatmentTask = CurrentTreatmentTasks[NumberOfTask];

        GameObject CurrentTable = Resources.Load<GameObject>(CurrentTreatmentTask.TaskPrefabsLoadKindPath + CurrentTreatmentTask.TaskTablePrefabsLoadPath);

        if (CurrentTable != null)
        {
            GameObject ObjectOfBaseButton = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToBaseUiButton);

            CurrentTable = Object.Instantiate(CurrentTable, CurrentTable.transform.position, Quaternion.identity, CurrentTable.transform.parent);

            if (ObjectOfBaseButton != null)
            {
                GameObject ObjectOfAbadoneTaskButon = Object.Instantiate(ObjectOfBaseButton, new Vector3(CurrentTable.transform.position.x - DistanceForButtonOnX, CurrentTable.transform.position.y - DistanceForButtonOnY), Quaternion.identity, CurrentTable.transform);

                CreateButton(ref ObjectOfAbadoneTaskButon,"AbadoneTask",RemoveFromCurrentReceivedTask);
                            
                GameObject ObjectOfCheckOnCompleteTaskButon = Object.Instantiate(ObjectOfBaseButton, new Vector3(CurrentTable.transform.position.x + DistanceForButtonOnX,CurrentTable.transform.position.y - DistanceForButtonOnY), Quaternion.identity, CurrentTable.transform);

                CreateButton(ref ObjectOfCheckOnCompleteTaskButon,"CheckOnComplete",CheckOnCompleteTask);
                             
                GameObject CurrentObjectOfExitButton = Object.Instantiate(ObjectOfBaseButton, TransformOfExitFromTableButton.position, Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                CreateButton(ref CurrentObjectOfExitButton, "Exit", DestroyTable);
                
            }
        }
    }

    public virtual void AddTaskToTaskTaker()
    {
        CurrentQuestTaskTaker.GetComponent<IQuestTaker>().CurrentIQuestTakerResource.AddToReceivedTask(CurrentTreatmentTask);
    }
    public virtual void RemoveFromCurrentReceivedTask()
    {
        CurrentQuestTaskTaker.GetComponent<IQuestTaker>().CurrentIQuestTakerResource.RemoveFromRecivedTask(CurrentTreatmentTask);
    }
    public virtual void CheckOnCompleteTask()
    {
       IQuestTaker TreatmentQuestTaker = CurrentQuestTaskTaker.GetComponent<IQuestTaker>();

       CurrentResource = CurrentTreatmentTask.CheckOfCompleteTask(ref TreatmentQuestTaker, CurrentResource);
              
    }


    public virtual void DestroyTheFirstUiQuestGiverMenu()
    {
        if (TheFirstUiQuestGiverMenu != null)
        {
            Object.Destroy(TheFirstUiQuestGiverMenu);

            TheSecondaryUiQuestgiverMenu = null;
                        
        }
               
    }
    public virtual void DestroyTheSecondaryUiQuestGiverMenu()
    {
        if (TheSecondaryUiQuestgiverMenu != null)
        {
            Object.Destroy(TheSecondaryUiQuestgiverMenu);

            TheSecondaryUiQuestgiverMenu = null;
                       
        }
                
    }
    public virtual void DestroyTable()
    {
        if (CurrentTaskTable != null)
        {
            Object.Destroy(CurrentTaskTable);

            CurrentTaskTable = null;

        }
               
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
  
    protected virtual void CreateDropDownWithTaskForGive(ref Dropdown CurrentDropDown)
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
    protected virtual void CreateDropDownWithGivedTask(ref Dropdown CurrentDropDown)
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

    protected virtual void FindCurrentQuestTaskTaker()
    {
       
    }
    
    protected virtual bool CreateButton(ref GameObject ObjectOfBasebutton,string NameOfButton,UnityAction MethodForcall)
    {
        Button CurrentButton = ObjectOfBasebutton.GetComponentInChildren<Button>();

        if (CurrentButton != null)
        {
            SettingsButton(ref CurrentButton, NameOfButton, MethodForcall);
        }
        else
        {
            Object.Destroy(ObjectOfBasebutton);

            return false;
        }

        return true;
    }
    protected virtual void SettingsButton(ref Button CurrentButton,string ButtonText, UnityAction FuncForCall)
    {
        CurrentButton.onClick.AddListener(FuncForCall);

        if (CurrentButton.gameObject.GetComponent<Text>())
        {
            CurrentButton.gameObject.GetComponent<Text>().text = ButtonText;
        }
                
    }
    

    protected virtual bool CreateTheFirstMenu()
    {
        if (CreateTheFirstUiQuestGiverMenu())
        {
            GameObject CurrentObjectOfBaseButton = Resources.Load<GameObject>(CurrentResource.QuestGiverLoadKindPath + PreafabsLoadPath + LinkToBaseUiButton);

            if (CurrentObjectOfBaseButton != null)
            {
                GameObject CurrentObjectOfButtonCreateMenuWithAllTaskForGive = Object.Instantiate(CurrentObjectOfBaseButton,new Vector3(TheFirstUiQuestGiverMenu.transform.position.x,TheFirstUiQuestGiverMenu.transform.position.y - DistanceForButtonOnY), Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                if (!CreateButton(ref CurrentObjectOfButtonCreateMenuWithAllTaskForGive,"TaskForGive",CreateMenuWithAllTaskForGive))
                {
                    return false;
                }

                GameObject CurrentObjectOfButtonCreateMenuWithGivedTask = Object.Instantiate(CurrentObjectOfBaseButton, new Vector3(CurrentObjectOfBaseButton.transform.position.x, CurrentObjectOfButtonCreateMenuWithAllTaskForGive.transform.position.y - DistanceForButtonOnY), Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                if (!CreateButton(ref CurrentObjectOfButtonCreateMenuWithGivedTask,"GivedTask",CreateMenuWithAllGivedTask))
                {
                    return false;
                }
                
                GameObject CurrentObjectOfExitButton = Object.Instantiate(CurrentObjectOfBaseButton,TransformOfExitFromTableButton.position, Quaternion.identity, TheFirstUiQuestGiverMenu.transform.parent);

                if (!CreateButton(ref CurrentObjectOfExitButton,"Exit",DestroyTheFirstUiQuestGiverMenu))
                {
                    return false;
                }

                return true;
            }
                        
        }

        return false;
    }
}
