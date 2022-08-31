using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorMainState : VisitorState
{
    public override string KindPath { get => StateKindPath + NPCStateKindPath + MainNPCStatePath; protected set => MainNPCStatePath = value; }

    protected string MainNPCStatePath = SceneInfo.GetLinkToAssets("MainNPCStatePath");
      
    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
