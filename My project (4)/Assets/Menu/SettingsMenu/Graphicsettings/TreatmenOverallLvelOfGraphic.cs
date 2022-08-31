using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmenOverallLvelOfGraphic : OverallTreatmen
{
    public override SettingSaveInfo CurrentSettingsInfo { get => base.CurrentSettingsInfo; protected set => base.CurrentSettingsInfo = value; }

    public override string CurrentActiveElementLink { get => base.CurrentActiveElementLink; protected set => base.CurrentActiveElementLink = value; }
    public override string ObjectPath { get => DeffaultObjectPath; protected set => DeffaultObjectPath = value; }

    private string DeffaultObjectPath = "OverallLevelOfGraphic";

    public override void ChangeObjectPath(string NewObjectPath)
    {
        base.ChangeObjectPath(NewObjectPath);
    }
    public override void ChangeSettingsInfo(SettingSaveInfo NewCurrentSettingsInfo)
    {
        base.ChangeSettingsInfo(NewCurrentSettingsInfo);
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        return base.IsChange(PreviusSaveInfo);
    }
    public override void StartFacade()
    {
        base.StartFacade();

        if (CurrentActiveElementLink != new YourselfullLevelOfGraphic().LevelOf) ChangeAnotherTreatments();
    }
    public override void Load()
    {
        base.Load();
    }
    public override void Save()
    {
        base.Save();
    }
   
    public void ChangeChildrenTreatments(LevelOfGraphic currentGraphic)
    {

        currentGraphic.GetComponentInParent<TretmenOfGraphicMenuFacade>().ReplaceActiveGraphickElements(currentGraphic);
        if (currentGraphic.LevelOf != CurrentActiveElementLink && CurrentActiveElementLink != new YourselfullLevelOfGraphic().LevelOf)
        {
            ChangeOnYourselFullGraphicSettings();
        }
    }
    public override void ReplaceActiveGraphickElements(LevelOfGraphic currentGraphic)
    {
        base.ReplaceActiveGraphickElements(currentGraphic);

        if (CurrentActiveElementLink != new YourselfullLevelOfGraphic().LevelOf) 
        {
           base.ChangeAnotherTreatments();
        }
      
    }
    protected override void ChangeActiveGraphicElement(LevelOfGraphic currentGraphic)
    {
        base.ChangeActiveGraphicElement(currentGraphic);
    }
    protected override void FindCurrentActiveElement()
    {
        base.FindCurrentActiveElement();
    }
    protected override void RemoveActiveElementOfTexture()
    {
        base.RemoveActiveElementOfTexture();
    }
           

    private  void ChangeOnYourselFullGraphicSettings()
    {
        string CheckLevel = new YourselfullLevelOfGraphic().LevelOf;
        foreach (var i in transform.gameObject.GetComponentsInChildren<LevelOfOverallGraphic>())
        {
            if (i.LevelOf == CheckLevel)
            {
                base.ReplaceActiveGraphickElements(i);
            }
        }
        CurrentActiveElementLink = CheckLevel;
    }

}
