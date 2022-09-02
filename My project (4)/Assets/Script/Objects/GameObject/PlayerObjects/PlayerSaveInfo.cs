using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSaveInfo : SaveResource,IQuestTakerSaveResource
{
    public override Dictionary<string, List<string>> CurrentLinkToStates { get => DeffaultCurrentLinkToStates; set => DeffaultCurrentLinkToStates = value; }

    public override bool IsTreatmentActive { get => DeffaultIsTreatmentActive; set => DeffaultIsTreatmentActive = value; }

    public List<TaskFacade> ReceivedTask { get => DeffaultReceivedTask.ConvertAll(new System.Converter<TaskForActivingObjectFacade, TaskFacade>(i => i)); set => DeffaultReceivedTask = value.ConvertAll(new System.Converter<TaskFacade, TaskForActivingObjectFacade>(i => (TaskForActivingObjectFacade)i)); }
    public int LimitOfReceivedTask { get => DeffaultLimitOfReceivedTask; set =>DeffaultLimitOfReceivedTask = value; }


    public Dictionary<string, List<string>> DeffaultCurrentLinkToStates = new Dictionary<string, List<string>>();

    public List<TaskForActivingObjectFacade> DeffaultReceivedTask = new List<TaskForActivingObjectFacade>();

    public int DeffaultLimitOfReceivedTask = 2;

    private bool DeffaultIsTreatmentActive = true;


}
