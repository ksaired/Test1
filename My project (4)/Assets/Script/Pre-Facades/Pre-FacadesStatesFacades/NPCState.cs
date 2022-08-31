using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCState : State
{
    public override Resource CurrentInfo { get => CurrentNPCInfo; protected set => CurrentNPCInfo = (NPCResource)value; }

    public override string KindPath { get => StateKindPath + NPCStateKindPath; protected set => base.KindPath = value; }

    public virtual NPCResource CurrentNPCInfo { get; protected set; }

    protected string NPCStateKindPath = SceneInfo.GetLinkToAssets("NPCStateKindPath");
}
