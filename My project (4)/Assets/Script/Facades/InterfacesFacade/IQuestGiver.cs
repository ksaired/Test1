using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestGiver
{
    public abstract IQuestGiverResource CurrentIQuestGiverResource { protected  set; get; }


    public abstract bool GetIQuestGiverState(out IQuestGiverState CurrentIQuestGiverState);
    
}
