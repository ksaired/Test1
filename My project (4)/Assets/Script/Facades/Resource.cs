using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resource : MonoBehaviour
{
    public virtual SaveResource currentSaveInfo { protected set; get; }

    public virtual TreatmentOfStatesFacade CurrentStateFacade { get; protected set; }
    public virtual TreatmentOfStatesFacade CurrentMainStateFacade { get; protected set; }
        
    public int TestLoadTree = 0;

    public virtual void ChangeSaveInfo(SaveResource newSaveInfo) 
    {
        currentSaveInfo = newSaveInfo;
    }

    public virtual void ChangeCurrentTreatmentState(TreatmentOfStatesFacade newTreatmentState)
    {
        CurrentStateFacade = newTreatmentState;
    }
    public virtual void ChangeCurrentMainTreatmentState(TreatmentOfStatesFacade newMainTreatmentState)
    {
        CurrentMainStateFacade = newMainTreatmentState;
    }
    public virtual void ChangeIsActiveTreatmentStateBool(bool NewValue)
    {
        currentSaveInfo.IsTreatmentActive = NewValue;
    }

    public virtual void ChangeTestLoadTree(int NewTestLoadTree)
    {
        TestLoadTree = NewTestLoadTree;
    }


    public abstract void StartResource();
            
}
