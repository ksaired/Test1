using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyObjectFacade : ActiveObjectFacade
{
    public override Resource CurrentInfo { get => CurrentEnemyInfo; protected set => CurrentEnemyInfo = (EnemyResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + EnemyObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }

    public virtual EnemyResource CurrentEnemyInfo { set; get; }

    protected string EnemyObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("EnemyObjectFacadePrefabsPath");
}
