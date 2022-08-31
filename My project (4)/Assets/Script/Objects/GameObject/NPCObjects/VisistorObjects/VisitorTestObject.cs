using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorTestObject : VisitorObjectFacade
{
    private VisitorTestResource CurrentVisitorTestInfo = new VisitorTestResource();

    public override VisitorResource CurrentVisitorInfo { get => CurrentVisitorTestInfo; set => CurrentVisitorTestInfo = (VisitorTestResource)value; }
    public override string LoadPath { get => CurrentVisitorLoadPath; protected set => CurrentVisitorLoadPath = value; }
    public override string ObjectsPrefabsPath { get => VisitorObjectPrefabsLoadPath; protected set => base.ObjectsPrefabsPath = value; }

    public string VisitorObjectPrefabsLoadPath = "/VisitorTestObject";

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
        if (CurrentVisitorTestInfo.SaveVisitorTestInfo.LinkToTreatmentStates != null)
        {
            CurrentVisitorTestInfo.CurrentVisitorTreatmentState = Resources.Load<TreatmentOfVisitorState>(CurrentVisitorTestInfo.SaveVisitorTestInfo.LinkToTreatmentStates);
        }


        if (CurrentVisitorTestInfo.SaveVisitorTestInfo.CurrentLinkToStates.TryGetValue(CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStatePath, out List<string> CurrentState))
        {
            CurrentVisitorTestInfo.CurrentVisitorTreatmentState.Load(CurrentState);
        }
    }
    private void SaveTreatments()
    {
        CurrentVisitorTestInfo.SaveVisitorTestInfo.LinkToTreatmentStates = CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStateKindPath + CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStatePath;

        if (CurrentVisitorTestInfo.SaveVisitorTestInfo.CurrentLinkToStates.ContainsKey(CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStatePath))
        {
            CurrentVisitorTestInfo.SaveVisitorTestInfo.CurrentLinkToStates.Remove(CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStatePath);

            CurrentVisitorTestInfo.SaveVisitorTestInfo.CurrentLinkToStates.Add(CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStatePath, CurrentVisitorTestInfo.CurrentVisitorTreatmentState.Save());
        }
        else
        {
            CurrentVisitorTestInfo.SaveVisitorTestInfo.CurrentLinkToStates.Add(CurrentVisitorTestInfo.CurrentVisitorTreatmentState.TreatmentStatePath, CurrentVisitorTestInfo.CurrentVisitorTreatmentState.Save());
        }
    }
    public override void UpdateFacade()
    {
        base.UpdateFacade();

        Debug.Log(CurrentVisitorTestInfo.SaveVisitorTestInfo.Testint);
        Debug.Log(CurrentInfo.TestLoadTree);

    }
    public override void StartFacade()
    {
        CurrentInfo.StartResource();

        base.StartFacade();
    }
    public override void Load(SaveResource LoadResource)
    {
        CurrentVisitorInfo.ChangeSaveInfo(LoadResource);

        LoadTreatmentStates();
    }
    public override void DeffaultLoad()
    {
        CurrentVisitorInfo = new VisitorTestResource();

        LoadTreatmentStates();
    }
    public override SaveResource Save()
    {
        SaveTreatments();

        return CurrentVisitorTestInfo.SaveVisitorTestInfo;
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
