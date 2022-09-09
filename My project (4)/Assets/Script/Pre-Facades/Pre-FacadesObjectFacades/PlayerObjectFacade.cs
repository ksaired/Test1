using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerObjectFacade : ActiveObjectFacade,IQuestTaker
{
    public override Resource CurrentInfo { get => CurrentPlayerInfo; protected set => CurrentPlayerInfo = (PlayerResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + PlayerObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }
    IQuestTakerResource IQuestTaker.CurrentIQuestTakerResource { get => CurrentPlayerInfo; set => CurrentPlayerInfo = (PlayerResource)value; }

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

    public virtual bool CheckOnCompleteGoal<T>(T CurrentGoal,string CurrentTag)
    {
        if (CurrentTag == "currentint" && CurrentGoal is int a)
        {
            if (CurrentPlayerInfo.currentint == a)
            {
                return true;
            }
        }
        else if (CurrentTag == "currentfloat" && CurrentGoal is float i)
        {
            if (CurrentPlayerInfo.currentint == i)
            {
                return true;
            }
        }
        return false;
    }

    public virtual bool RecieveReward<T>(T CurrentReward,string CurrentTag)
    {
        if (CurrentTag == "currentint" && CurrentReward is int a)
        {
            CurrentPlayerInfo.currentint += a;

            return true;
        }
        else if (CurrentTag == "currentfloat" && CurrentReward is float i)
        {
            CurrentPlayerInfo.currentint += i;

            return true;
        }

        return false;
    }

    public virtual bool RemoveGoalResource<T>(T CurrentRemoveGoalResource,string CurrentTag)
    {
        if (CurrentTag == "currentint" && CurrentRemoveGoalResource is int a)
        {
           CurrentPlayerInfo.currentint -= a;

           return true;
        }
        else if (CurrentTag == "currentfloat" && CurrentRemoveGoalResource is float i)
        {
            CurrentPlayerInfo.currentint += i;

            return true;
        }

        return false;
    }
}
