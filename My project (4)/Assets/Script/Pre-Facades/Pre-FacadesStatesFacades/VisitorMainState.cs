using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorMainState : VisitorState
{
    
    public override string KindPath { get => StateKindPath + NPCStateKindPath + MainVisitorStatePath; protected set => MainVisitorStatePath = value; }

    public VisitorMainResource CurrentVisitorMainResource;
    
    protected string MainVisitorStatePath = SceneInfo.GetLinkToAssets("MainVisitorStatePath");
          
    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
