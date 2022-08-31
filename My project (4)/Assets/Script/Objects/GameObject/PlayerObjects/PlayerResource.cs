using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResource : Resource
{
    public override SaveResource currentSaveInfo { get => SaveInfo; protected set => SaveInfo = (PlayerSaveInfo)value; }
    public override TreatmentOfStatesFacade CurrentMainStateFacade { get => CurrentPlayerTreatmentMainState; protected set => CurrentPlayerTreatmentMainState = (TreatmentOfMainPlayerState)value; }
    public override TreatmentOfStatesFacade CurrentStateFacade { get => CurrentPlayerTreatmentState; protected set => CurrentPlayerTreatmentState = (TreatmentOfPlayerState)value; }

    public PlayerSaveInfo SaveInfo = new PlayerSaveInfo();

    public TreatmentOfPlayerState CurrentPlayerTreatmentState = new TreatmentOfPlayerTestStates();
    public TreatmentOfMainPlayerState CurrentPlayerTreatmentMainState = new TreatmentOfMainPlayerState();

    public CameraLoadTree CurrentTree = new CameraLoadTree();

    public PlayerObjectFacade CurrentPlayer;
    
    public int currentint = 0;

    public string PauseMenuLoadPath = "MainPauseMenu";
    
    public bool IsOpenPauseMenu = true;
    public override void ChangeSaveInfo(SaveResource newSaveInfo)
    {
        base.ChangeSaveInfo(newSaveInfo);
    }

    public override void ChangeCurrentTreatmentState(TreatmentOfStatesFacade newTreatmentState)
    {
        base.ChangeCurrentTreatmentState(newTreatmentState);
    }
    public override void ChangeCurrentMainTreatmentState(TreatmentOfStatesFacade newMainTreatmentState)
    {
        base.ChangeCurrentMainTreatmentState(newMainTreatmentState);
    }
    public override void ChangeTestLoadTree(int NewTestLoadTree)
    {
        base.ChangeTestLoadTree(NewTestLoadTree);
    }

    public override void StartResource()
    {
        
    }
}
