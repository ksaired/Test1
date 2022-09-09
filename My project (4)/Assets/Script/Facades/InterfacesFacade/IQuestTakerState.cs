using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public interface IQuestTakerState 
{
    public abstract GameObject CurrentIQuestTaker {get; }

    public abstract IQuestTakerResource CurrentIQuestTakerResource{ protected set; get; }

    public abstract GameObject CurrentQuestGiverObject { protected set; get; }

    public abstract KeyCode ButtonforActiveQuestGiverFunction { protected set; get; }

    public abstract string LinkToBaseMentionTable { protected set; get; }

    public abstract string PreafabsLoadPath { protected set; get; }

    public abstract float DistanceBeetwenQuestGiverAndMentionTable { protected set; get; }

    public abstract GameObject CurrentTable { protected set; get; }

    public abstract void FindIQuestGiver();

    public virtual void ChangeDistanceBeetwenQuestGiverAndMentionTable(float NewDistanceBeetwenQuestGiverAndMentionTable)
    {
        DistanceBeetwenQuestGiverAndMentionTable = NewDistanceBeetwenQuestGiverAndMentionTable;
    }


    public virtual void UpadateState()
    {
        FindIQuestGiver();

        StartQuestGiver();
    }

    public virtual void StartQuestGiver()
    {
        if (CurrentQuestGiverObject != null && Input.GetKeyDown(ButtonforActiveQuestGiverFunction))
        {
            CurrentQuestGiverObject.GetComponent<IQuestGiver>().GetIQuestGiverState(out IQuestGiverState CurrentQuestGiverState);

            CurrentQuestGiverState.StartCreateTheFirstMenu(CurrentIQuestTaker);
        }
    }
    
    public bool RemovePreviuslyIQuestObjectObject()
    {
        if (CurrentQuestGiverObject != null)
        {
            CurrentQuestGiverObject = null;

            if (CurrentTable != null)
            {
                DeleteMentionTable();
            }

            return true;
        }

        return false;
    }

    protected virtual bool CreateMentionTable()
    {
        GameObject CurrentMentionTableObject = Resources.Load<GameObject>(CurrentIQuestTakerResource.QuestTakerLoadPrefabsKindPath + PreafabsLoadPath + LinkToBaseMentionTable);

        if (CurrentMentionTableObject != null)
        {
            CurrentMentionTableObject = Object.Instantiate(CurrentMentionTableObject,TakePosition(),Quaternion.identity,CurrentQuestGiverObject.transform);

            SettingsMentiontable(ref CurrentMentionTableObject);

            return true;
        }

        return false;
    }

    protected virtual Vector3 TakePosition()
    {
        return new Vector3(CurrentQuestGiverObject.transform.position.x, CurrentQuestGiverObject.transform.position.y + DistanceBeetwenQuestGiverAndMentionTable);
    }

    protected virtual void SettingsMentiontable(ref GameObject CurrentGameObjectForSettings)
    {
      Text CurrentTextOfButton =  CurrentGameObjectForSettings.AddComponent<Text>();

        CurrentTextOfButton.text = ButtonforActiveQuestGiverFunction.ToString();
    }

    protected bool DeleteMentionTable()
    {
        if (CurrentTable != null)
        {
            Object.Destroy(CurrentTable);

            CurrentTable = null;

            return true;
        }

        return false;
    }
    
}
