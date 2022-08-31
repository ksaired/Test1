using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayersState : State
{
    public override Resource CurrentInfo { get => CurrentPlayerInfo; protected set => CurrentPlayerInfo = (PlayerResource)value; }
    public override string KindPath { get => StateKindPath + PlayerStatePath; protected set => PlayerStatePath = value; }

    protected string PlayerStatePath = SceneInfo.GetLinkToAssets("PlayerStatePath");

    public virtual PlayerResource CurrentPlayerInfo { get; set; }
    public override void ChangeKindPath(string NewKindPath)
    {
        base.ChangeKindPath(NewKindPath);
    }
}
