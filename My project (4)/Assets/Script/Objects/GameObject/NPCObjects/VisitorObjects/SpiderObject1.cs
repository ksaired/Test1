using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderObject1 : SpiderObjectFacade
{
    private SpiderTestResource CurrentSpiderTestInfo = new SpiderTestResource();
       
    public override SpiderResource CurrentSpiderInfo { get => CurrentSpiderTestInfo; set => CurrentSpiderTestInfo = (SpiderTestResource)value; }
    public override string LoadPath { get => CurrentSpiderLoadPath; protected set => CurrentSpiderLoadPath = value; }
    public override string ObjectsPrefabsPath { get => SpiderObjects1PrefabsLoadPath; protected set => base.ObjectsPrefabsPath = value; }

    private string SpiderObjects1PrefabsLoadPath = "/Spider1";

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
    public void Update()
    {
        UpdateFacade();
    }
    private void LoadTreatmentStates()
    {
       if (CurrentSpiderTestInfo.SaveSpiderTestInfo.LinkToTreatmentStates != null)
       {
           CurrentSpiderTestInfo.CurrentSpiderTreatmentState = Resources.Load<TreatmentOfSpiderStates>(CurrentSpiderTestInfo.SaveSpiderTestInfo.LinkToTreatmentStates);
       }
               

       if (CurrentSpiderTestInfo.currentSaveInfo.CurrentLinkToStates.TryGetValue(CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStatePath,out List<string> CurrentState))
       {
          CurrentSpiderTestInfo.CurrentSpiderTreatmentState.Load(CurrentState);
       }
    }
    private void SaveTreatments()
    {
        CurrentSpiderTestInfo.currentSaveInfo.LinkToTreatmentStates = CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStateKindPath + CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStatePath;

        if (CurrentSpiderTestInfo.currentSaveInfo.CurrentLinkToStates.ContainsKey(CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStatePath))
        {
            CurrentSpiderTestInfo.currentSaveInfo.CurrentLinkToStates.Remove(CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStatePath);

            CurrentSpiderTestInfo.currentSaveInfo.CurrentLinkToStates.Add(CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStatePath, CurrentSpiderTestInfo.CurrentSpiderTreatmentState.Save());
        }
        else
        {
            CurrentSpiderTestInfo.currentSaveInfo.CurrentLinkToStates.Add(CurrentSpiderTestInfo.CurrentSpiderTreatmentState.TreatmentStatePath, CurrentSpiderTestInfo.CurrentSpiderTreatmentState.Save());
        }
    }
    public override void UpdateFacade()
    {
        base.UpdateFacade();
      
        Debug.Log(CurrentSpiderTestInfo.SaveSpiderTestInfo.Testint);
        Debug.Log(CurrentInfo.TestLoadTree);
        
    }
    public override void StartFacade()
    {
        CurrentInfo.StartResource();

        base.StartFacade();
    }
    public override void Load(SaveResource LoadResource)
    {
        CurrentSpiderInfo.ChangeSaveInfo(LoadResource);

        LoadTreatmentStates();
    }
    public override void DeffaultLoad()
    {
        CurrentSpiderInfo = new SpiderTestResource();

        LoadTreatmentStates();
    }
    public override SaveResource Save()
    {
        SaveTreatments();

        return CurrentSpiderTestInfo.SaveSpiderTestInfo;
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
