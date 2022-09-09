using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuestTakerState : PlayersState,IQuestTakerState
{
    public PlayerResource CurrentPlayerQuestTakerInfo;

    private string PlayerTestStatePath = "PlayerQuestTakerState";

    private GameObject DeffaultCurrentQuestGiverObject;

    private KeyCode DeffaultButtonforActiveQuestGiverFunction = KeyCode.J;

    private string DeffaultLinkToBaseMentionTable = "/BaseMentionTable";

    private string DeffaultPrefabsLoadPath = SceneInfo.GetLinkToAssets("PlayerQuestTakerLoadKindPath");

    private float DeffaultDistanceBeetwenQuestGiverAndMentionTable = 1;

    private GameObject DeffaultCurrentTable;

    private IQuestTakerState CurrentIQuestTakerState;

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerQuestTakerInfo; set => CurrentPlayerQuestTakerInfo = value; }

    public override string StatePath { get => PlayerTestStatePath; protected set => PlayerTestStatePath = value; }

    GameObject IQuestTakerState.CurrentIQuestTaker { get => CurrentPlayerQuestTakerInfo.CurrentPlayer.gameObject; }

    IQuestTakerResource IQuestTakerState.CurrentIQuestTakerResource { get => CurrentPlayerQuestTakerInfo; set => CurrentPlayerQuestTakerInfo = (PlayerResource)value; }
    GameObject IQuestTakerState.CurrentQuestGiverObject { get => DeffaultCurrentQuestGiverObject; set => DeffaultCurrentQuestGiverObject = value; }
    KeyCode IQuestTakerState.ButtonforActiveQuestGiverFunction { get => DeffaultButtonforActiveQuestGiverFunction; set => DeffaultButtonforActiveQuestGiverFunction = value; }
    string IQuestTakerState.LinkToBaseMentionTable { get => DeffaultLinkToBaseMentionTable; set => DeffaultLinkToBaseMentionTable = value; }
    string IQuestTakerState.PreafabsLoadPath { get => DeffaultPrefabsLoadPath; set => DeffaultPrefabsLoadPath = value; }
    float IQuestTakerState.DistanceBeetwenQuestGiverAndMentionTable { get => DeffaultDistanceBeetwenQuestGiverAndMentionTable; set => DeffaultDistanceBeetwenQuestGiverAndMentionTable = value; }
    GameObject IQuestTakerState.CurrentTable { get => DeffaultCurrentTable; set => DeffaultCurrentTable = value; }

    public override void ChangeCurrentInfo(Resource newInfo)
    {
        base.ChangeCurrentInfo(newInfo);
    }
    public override void ChangeStatePath(string NewStatePath)
    {
        base.ChangeStatePath(NewStatePath);
    }
    public override Resource StartFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;

        CurrentIQuestTakerState = this;

        return this.CurrentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;
               
        return this.CurrentInfo;
    }

    public override void StopState()
    {
        Debug.Log("stopstate");
    }

    public void FindIQuestGiver()
    {
        IQuestGiver CurrentQuestGiver;

        foreach (var i in CurrentPlayerQuestTakerInfo.CurrentColiders)
        {
            CurrentQuestGiver = i.gameObject.GetComponent<IQuestGiver>();

            if (CurrentQuestGiver != null)
            {
                if (DeffaultCurrentQuestGiverObject != i.gameObject)
                {
                    CurrentIQuestTakerState.RemovePreviuslyIQuestObjectObject();
                }
               
                DeffaultCurrentQuestGiverObject = i.gameObject;
                             
            }
            else if(DeffaultCurrentQuestGiverObject != null && CurrentQuestGiver == null)
            {
                CurrentIQuestTakerState.RemovePreviuslyIQuestObjectObject();
            }
        }
    }
        
   
}
