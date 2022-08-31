using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class SaveResource
{ 
    public virtual Dictionary<string, List<string>> CurrentLinkToStates { set; get; }
          
    public virtual string LinkToTreatmentStates { set; get; }

    public virtual bool IsTreatmentActive { set; get; }
        
}
