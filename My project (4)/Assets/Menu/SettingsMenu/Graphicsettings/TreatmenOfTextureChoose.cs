using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmenOfTextureChoose : TretmenOfGraphicMenuFacade
{
    public override SettingSaveInfo CurrentSettingsInfo { get => base.CurrentSettingsInfo; protected set => base.CurrentSettingsInfo = value; }

    public override string ObjectPath { get => DeffaultObjectPath; protected set => DeffaultObjectPath = value; }
    public override string CurrentActiveElementLink { get => base.CurrentActiveElementLink; protected set => base.CurrentActiveElementLink = value; }
   

    private string DeffaultObjectPath = "LevelOfTexture";

    public override void ChangeObjectPath(string NewObjectPath)
    {
        base.ChangeObjectPath(NewObjectPath);
    }
    public override void ChangeSettingsInfo(SettingSaveInfo NewCurrentSettingsInfo)
    {
        base.ChangeSettingsInfo(NewCurrentSettingsInfo);
    }
    public override void StartFacade()
    {
        base.StartFacade();
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        return base.IsChange(PreviusSaveInfo);
    }
    public override void Load()
    {
        base.Load();
    }
    public override void Save()
    {
        base.Save();
    }

    public override void ReplaceActiveGraphickElements(LevelOfGraphic currentGraphic)
    {
        base.ReplaceActiveGraphickElements(currentGraphic);
    }
    protected override void ChangeActiveGraphicElement(LevelOfGraphic CurrentLevelOfGraphic)
    {
        base.ChangeActiveGraphicElement(CurrentLevelOfGraphic);
    }
    protected override void RemoveActiveElementOfTexture()
    {
        base.RemoveActiveElementOfTexture();
    }
    protected override void StartFindCurrentActiveElement()
    {
        base.StartFindCurrentActiveElement();
    }
}
