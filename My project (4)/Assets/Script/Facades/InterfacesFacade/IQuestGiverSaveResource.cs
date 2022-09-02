using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestGiverSaveResource 
{
    public abstract List<TaskFacade> TaskForGive { set; get; }

    public abstract List<TaskFacade> GivedTask { set; get; }

    public abstract int LimitOfTaskforGive { set; get; }

    public abstract int LimitOfGivedTask { set; get; }
}
