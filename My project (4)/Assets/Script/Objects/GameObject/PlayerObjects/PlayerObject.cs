using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : PlayerObjectFacade
{ 
    private PlayerResource CurrentPlayerTestInfo = new PlayerResource();

    public override PlayerResource CurrentPlayerInfo { get => CurrentPlayerTestInfo; protected set => CurrentPlayerTestInfo = value; }
    public override string LoadPath { get => CurrentPlayerLoadPath; protected set => CurrentPlayerLoadPath = value; }
    public override string ObjectsPrefabsPath { get => PlayerObjectsPrefabs; protected set => base.ObjectsPrefabsPath = value; }
    public override string PlayerSpawnPath { get => base.PlayerSpawnPath; protected set => base.PlayerSpawnPath = value; }

    public string PlayerObjectsPrefabs = "/Player";

    public override void ChangeSpawnLoadPath(int NewSpawnLoadPath)
    {
        base.ChangeSpawnLoadPath(NewSpawnLoadPath);
    }
    public override void ChangeLoadPath(string NewLoadPath)
    {
        base.ChangeLoadPath(NewLoadPath);
    }
    public override void ChangeCurentInfo(Resource NewInfo)
    {
        base.ChangeCurentInfo(NewInfo);
    }
    public override void ChangePlayerSpawnPath(string NewPlayerSpawnPath)
    {
        base.ChangePlayerSpawnPath(NewPlayerSpawnPath);
    }

    public void Update()
    {
        UpdateFacade();
    }

    private void LoadTreatmentStates()
    {
        if (CurrentPlayerInfo.SaveInfo.LinkToTreatmentStates != null)
        {
            CurrentPlayerInfo.CurrentPlayerTreatmentState = Resources.Load<TreatmentOfPlayerState>(CurrentPlayerInfo.SaveInfo.LinkToTreatmentStates);
        }
        
        if (CurrentPlayerTestInfo.currentSaveInfo.CurrentLinkToStates.TryGetValue(CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath,out List<string> CurrentStates))
        {
            CurrentPlayerTestInfo.CurrentPlayerTreatmentState.Load(CurrentStates);
            CurrentPlayerTestInfo.currentSaveInfo.CurrentLinkToStates.Remove(CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath);
        }
        
    }
    private void SaveTreatments()
    {
        CurrentPlayerTestInfo.currentSaveInfo.LinkToTreatmentStates = CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStateKindPath + CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath;

        if (CurrentPlayerTestInfo.currentSaveInfo.CurrentLinkToStates.ContainsKey(CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath))
        {
            CurrentPlayerTestInfo.currentSaveInfo.CurrentLinkToStates.Remove(CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath);
            CurrentPlayerTestInfo.currentSaveInfo.CurrentLinkToStates.Add(CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath, CurrentPlayerInfo.CurrentPlayerTreatmentState.Save());
        }
        else
        {
            CurrentPlayerTestInfo.currentSaveInfo.CurrentLinkToStates.Add(CurrentPlayerInfo.CurrentPlayerTreatmentState.TreatmentStatePath, CurrentPlayerInfo.CurrentPlayerTreatmentState.Save());
        }
    }

    public override void UpdateFacade()
    {
        base.UpdateFacade();

        Debug.Log(CurrentPlayerTestInfo.currentint);
        Debug.Log(CurrentInfo.TestLoadTree);
    }
    public override void StartFacade()
    {
        CurrentPlayerInfo.CurrentPlayer = this;
        CurrentPlayerInfo.CurrentTree = GetComponent<CameraLoadTree>();

        CurrentInfo.StartResource();

        base.StartFacade();
                
    }
    public override void Load(SaveResource LoadResource)
    {
        CurrentPlayerTestInfo.ChangeSaveInfo(LoadResource);

        LoadTreatmentStates();
    }
    public override void DeffaultLoad()
    {
        CurrentPlayerTestInfo = new PlayerResource();

        LoadTreatmentStates();
        Debug.Log("15136");
    }
    public override SaveResource Save()
    {
        SaveTreatments();

        return CurrentPlayerTestInfo.SaveInfo;
    }

    protected override void StartTreatmentState()
    {
        base.StartTreatmentState();
    }
    protected override void UpdateTreatmentState()
    {
        base.UpdateTreatmentState();
    }
}
