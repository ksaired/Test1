using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMainState : PlayersState
{
    public override string KindPath { get => StateKindPath + PlayerStatePath + MainPlayerStatePath; protected set => MainPlayerStatePath = value; }

    protected string MainPlayerStatePath = SceneInfo.GetLinkToAssets("MainPlayerStatePath");

    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
