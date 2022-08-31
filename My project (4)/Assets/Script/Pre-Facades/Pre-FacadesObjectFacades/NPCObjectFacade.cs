using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCObjectFacade : ActiveObjectFacade
{
    public override Resource CurrentInfo { get => CurrentNPCInfo; protected set => CurrentNPCInfo = (NPCResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + NPCObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }

    public virtual NPCResource CurrentNPCInfo { set; get; }

    protected string NPCObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("NPCObjectFacadePrefabsPath");
}
