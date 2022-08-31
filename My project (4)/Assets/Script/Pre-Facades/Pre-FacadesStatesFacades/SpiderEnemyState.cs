using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpiderEnemyState : EnemyStates
{
    public override EnemyResource CurrentEnemyInfo { get => CurrentSpiderInfo; protected set => CurrentSpiderInfo = (SpiderResource)value; }
    public override string KindPath { get => StateKindPath + EnemyStateKindPath + SpiderStatePath; protected set => SpiderStatePath = value; }

    protected string SpiderStatePath = SceneInfo.GetLinkToAssets("SpiderStatePath");
    public virtual SpiderResource CurrentSpiderInfo { get; set; }

    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
