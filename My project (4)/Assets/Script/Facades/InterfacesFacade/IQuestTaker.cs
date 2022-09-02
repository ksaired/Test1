using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestTaker 
{
    public abstract IQuestTakerResource CurrentIQuestTakerResource{ protected set; get; }

    public abstract bool CheckOnCompleteGoal<T>(T CurrentGoal,string CurrentTag);

    public abstract bool RecieveReward<T>(T CurrentReward,string CurrentTag);

    public abstract bool RemoveGoalResource<T>(T CurrentRemoveGoalResource,string CurrentTag);
}
