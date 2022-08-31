using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorResource : NPCResource
{
    public override NPCSaveResource SaveNPCInfo { get => SaveVisitorInfo; set => SaveVisitorInfo = (VisitorSaveResource)value; }

    public override TreatmentOfNPCState CurrentNPCTreatmentMainState { get => CurrentNPCTreatmentMainState; set => CurrentNPCTreatmentMainState = value; }
    public override TreatmentOfNPCState CurrentNPCTreatmentState { get => CurrentNPCTreatmentState; set => CurrentNPCTreatmentState = value; }

    public virtual VisitorSaveResource SaveVisitorInfo { get; set; }

    public TreatmentOfMainVisitorState CurrentVisitorTreatmentMainState = new TreatmentOfMainVisitorState();
    public TreatmentOfVisitorState CurrentVisitorTreatmentState = new TreatmentOfTestVisitorState();
}
