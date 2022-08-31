using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreatmentOfStatesFacade : MonoBehaviour
{
    protected int CurrentStateCount = 0;
       
    protected string TreatmentStateFacadeKindPath = SceneInfo.GetLinkToAssets("TreatmentStateFacadeKindPath");

    public virtual string TreatmentStatePath { protected set ; get ; }

    public virtual string TreatmentStateKindPath { protected set; get; }
        
    public virtual List<State> CurrentState { protected get; set; }

    public virtual Resource currentInfo { protected set; get; }

    public abstract Resource StartFacade(Resource CurrentInfo);

    public abstract Resource UpdateFacade(Resource CurrentInfo);

    public abstract void Load(List<string> CurrentLoadPathState);

    public abstract List<string> Save();

    public abstract void AddToCurrentState(State NewState);

    public abstract void RemoveFromCurrentState(State RemoveState);

    public abstract List<State> TakeCurrentState();
    
    public virtual void ChangeCurrentInfo(Resource NewInfo)
    {
        currentInfo = NewInfo;
    }
}
