using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerObjectFacade : ActiveObjectFacade
{
    public override Resource CurrentInfo { get => CurrentPlayerInfo; protected set => CurrentPlayerInfo = (PlayerResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + PlayerObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }

    public virtual PlayerResource CurrentPlayerInfo { protected set; get; }
    public virtual string PlayerSpawnPath { protected set; get; }

    protected string PlayerObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("PlayerObjectFacadePrefabsPath");
    protected string CurrentPlayerLoadPath = "PlayerResource";

    public virtual void ChangePlayerSpawnPath(string NewPlayerSpawnPath)
    {
        PlayerSpawnPath = NewPlayerSpawnPath;
    }
    public virtual void ChangeCurrentPlayerInfo(PlayerResource newPlayerInfo)
    {
        CurrentPlayerInfo = newPlayerInfo;
    }
}
