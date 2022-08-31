using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpiderEnemyMainState : SpiderEnemyState
{
    public override string KindPath { get => StateKindPath + EnemyStateKindPath + MainSpiderStatePath; protected set => MainSpiderStatePath = value; }

    protected string MainSpiderStatePath = SceneInfo.GetLinkToAssets("MainSpiderStatePath");
      
    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
