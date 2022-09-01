using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActiveObjectFacade : ObjectFacade
{

    public virtual void UpdateFacade()
    {
        UpdateTreatmentState();
    }

    protected virtual void UpdateTreatmentState()
    {
        if (CurrentInfo.currentSaveInfo.IsTreatmentActive)
        {
            CurrentInfo = CurrentInfo.CurrentStateFacade.UpdateFacade(CurrentInfo);
            CurrentInfo = CurrentInfo.CurrentMainStateFacade.UpdateFacade(CurrentInfo);
        }
    }
    
}
