using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpiderObjectFacade : EnemyObjectFacade 
{
    public override EnemyResource CurrentEnemyInfo { get => CurrentSpiderInfo; set => CurrentSpiderInfo = (SpiderResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + EnemyObjectFacadePrefabsPath + SpiderObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }

    public virtual SpiderResource CurrentSpiderInfo { get; set; }

    protected string SpiderObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("SpiderObjectFacadePrefabsPath");
    protected string CurrentSpiderLoadPath = "SpiderResource";
}
