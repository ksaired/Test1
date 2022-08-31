using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyStates : State
{
    public override Resource CurrentInfo { get => CurrentEnemyInfo; protected set => CurrentEnemyInfo = (EnemyResource)value; }

    public override string KindPath { get => StateKindPath + EnemyStateKindPath ; protected set => base.KindPath = value; }

    public virtual EnemyResource CurrentEnemyInfo { get; protected set; }

    protected string EnemyStateKindPath = SceneInfo.GetLinkToAssets("EnemyStateKindPath");
}
