using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorObjectFacade : NPCObjectFacade
{
    public override NPCResource CurrentNPCInfo { get => CurrentVisitorInfo; set => CurrentVisitorInfo = (VisitorResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + NPCObjectFacadePrefabsPath + VisitorObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }

    public virtual VisitorResource CurrentVisitorInfo { get; set; }

    protected string VisitorObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("VisitorObjectFacadePrefabsPath");
    protected string CurrentVisitorLoadPath = "VisitorResource";
}
