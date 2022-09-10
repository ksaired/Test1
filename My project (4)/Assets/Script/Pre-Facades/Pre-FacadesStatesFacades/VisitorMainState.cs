using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorMainState : VisitorState
{
    public override VisitorResource CurrentVisitorInfo { get => CurrentVisitorMainResource; set => CurrentVisitorMainResource = (VistorMainResource)value; }
    public override string KindPath { get => StateKindPath + NPCStateKindPath + MainVisitorStatePath; protected set => MainVisitorStatePath = value; }

    protected string MainVisitorStatePath = SceneInfo.GetLinkToAssets("MainVisitorStatePath");

    protected VistorMainResource CurrentVisitorMainResource = new VistorMainResource();

    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
