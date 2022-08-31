using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSaveInfo : SaveResource
{
    public override Dictionary<string, List<string>> CurrentLinkToStates { get => DeffaultCurrentLinkToStates; set => DeffaultCurrentLinkToStates = value; }

    public override bool IsTreatmentActive { get => DeffaultIsTreatmentActive; set => DeffaultIsTreatmentActive = value; }

    public Dictionary<string, List<string>> DeffaultCurrentLinkToStates = new Dictionary<string, List<string>>();

    private bool DeffaultIsTreatmentActive = true;


}
