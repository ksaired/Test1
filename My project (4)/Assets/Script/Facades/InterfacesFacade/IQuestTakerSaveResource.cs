using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestTakerSaveResource 
{
    public abstract List<TaskFacade> ReceivedTask { set; get; }

    public abstract int LimitOfReceivedTask { set; get; } 
}
