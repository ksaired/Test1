using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResource : Resource,IQuestTakerResource
{
    public override SaveResource currentSaveInfo { get => SaveInfo; protected set => SaveInfo = (PlayerSaveInfo)value; }
    public override TreatmentOfStatesFacade CurrentMainStateFacade { get => CurrentPlayerTreatmentMainState; protected set => CurrentPlayerTreatmentMainState = (TreatmentOfMainPlayerState)value; }
    public override TreatmentOfStatesFacade CurrentStateFacade { get => CurrentPlayerTreatmentState; protected set => CurrentPlayerTreatmentState = (TreatmentOfPlayerState)value; }

    public override GameObject CurrentObject { get => base.CurrentObject; protected set => base.CurrentObject = value; }

    public override string ObjectPrefabsLoadKindPath { get => base.ObjectPrefabsLoadKindPath; protected set => base.ObjectPrefabsLoadKindPath = value; }
    public override string KindPathToAssetsForResource { get => ResourceKindPathToAssetsForResource + PlayerResourceKindPathToAssetsForResource; protected set => base.KindPathToAssetsForResource = value; }
    public override string ObjectResourcePathToAssetsForResource { get => PlayerObjectResourcePathToAssetsForResource; protected set => PlayerObjectResourcePathToAssetsForResource = value; }
    public IQuestTakerSaveResource CurrentQuestTakerSaveInfo { get => SaveInfo; set => SaveInfo = (PlayerSaveInfo)value; }

    public PlayerSaveInfo SaveInfo = new PlayerSaveInfo();

    public TreatmentOfPlayerState CurrentPlayerTreatmentState = new TreatmentOfPlayerTestStates();
    public TreatmentOfMainPlayerState CurrentPlayerTreatmentMainState = new TreatmentOfMainPlayerState();

    public CameraLoadTree CurrentTree = new CameraLoadTree();

    public PlayerObjectFacade CurrentPlayer;
    
    public int currentint = 0;

    public string PauseMenuLoadPath = "MainPauseMenu";
    
    public bool IsOpenPauseMenu = true;

    protected string PlayerResourceKindPathToAssetsForResource = SceneInfo.GetLinkToAssets("PlayerResourceKindPathToAssetsForResource");

    private string PlayerObjectResourcePathToAssetsForResource = "/PlayerTestObjectAssets";
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

    public override void StartResource(GameObject CurrentObject)
    {
        this.CurrentObject = CurrentObject;
    }

    public bool AddToReceivedTask(TaskFacade NewTaskFacade)
    {
        if (SaveInfo.ReceivedTask.Count <= SaveInfo.LimitOfReceivedTask)
        {
            if (!SaveInfo.ReceivedTask.Contains(NewTaskFacade))
            {
                SaveInfo.ReceivedTask.Add(NewTaskFacade);

                return true;
            }
        }

            return false;
    }

    public bool RemoveFromRecivedTask(TaskFacade RemoveTaskFacade)
    {
        if (SaveInfo.ReceivedTask.Contains(RemoveTaskFacade))
        {
            SaveInfo.ReceivedTask.Add(RemoveTaskFacade);

            return true;
        }

        return false;
    }

    public void ChangeLimitOfReceivedTask(int NewLimitOfReceivedTask)
    {
        SaveInfo.LimitOfReceivedTask = NewLimitOfReceivedTask;
    }
}
