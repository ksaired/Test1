using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorState : NPCState
{
    public override NPCResource CurrentNPCInfo { get => CurrentVisitorInfo; protected set => CurrentVisitorInfo = (VisitorResource)value; }
    public override string KindPath { get => StateKindPath + NPCStateKindPath + VisitorStatePath; protected set => base.KindPath = value; }

    protected string VisitorStatePath = SceneInfo.GetLinkToAssets("VisitorStatePath");
    public virtual VisitorResource CurrentVisitorInfo { get; set; }

    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
