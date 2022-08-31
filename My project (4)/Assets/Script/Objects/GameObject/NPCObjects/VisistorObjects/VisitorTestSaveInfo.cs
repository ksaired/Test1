using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorTestSaveInfo : VisitorSaveResource
{
    public override Dictionary<string, List<string>> CurrentLinkToStates { get => base.CurrentLinkToStates; set => base.CurrentLinkToStates = value; }

    public override string LinkToTreatmentStates { get => base.LinkToTreatmentStates; set => base.LinkToTreatmentStates = value; }

    public override bool IsTreatmentActive { get => DeffaultIsTreatmentActive; set => DeffaultIsTreatmentActive = value; }

    public int Testint = 0;

    private bool DeffaultIsTreatmentActive = true;
}
