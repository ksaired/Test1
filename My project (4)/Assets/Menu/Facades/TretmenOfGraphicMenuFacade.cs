using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class TretmenOfGraphicMenuFacade : SettingsFacade
{
    public virtual string CurrentActiveElementLink { protected set; get; }

    public virtual void ReplaceActiveGraphickElements(LevelOfGraphic currentGraphic)
    {
        if (currentGraphic.LevelOf != CurrentActiveElementLink)
        {
            RemoveActiveElementOfTexture();
            ChangeActiveGraphicElement(currentGraphic);
        }
    }

    protected virtual void ChangeActiveGraphicElement(LevelOfGraphic CurrentLevelOfGraphic)
    {
        CurrentLevelOfGraphic.LoadSprite(CurrentLevelOfGraphic.SpriteLink);

        CurrentActiveElementLink = CurrentLevelOfGraphic.LevelOf;
        
    }
    protected virtual void RemoveActiveElementOfTexture()
    {
        foreach (var i in transform.gameObject.GetComponentsInChildren<LevelOfGraphic>())
        {
            if (i.LevelOf == CurrentActiveElementLink)
            {
              i.GetComponent<Image>().sprite = i.DefaultSprite;
            }
        }     
    }
    protected virtual void StartFindCurrentActiveElement()
    {
        foreach (var i in transform.gameObject.GetComponentsInChildren<LevelOfGraphic>())
        {
            i.StartFacade();

            if (i.LevelOf == CurrentActiveElementLink)
            {
                 ChangeActiveGraphicElement(i);
            }
                   
           
        }
    }

    public override void StartFacade()
    {
        CurrentSettingsInfo = UIInfo.settingsInformation;
        StartFindCurrentActiveElement();
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        if (PreviusSaveInfo.IsActiveGraphicks.TryGetValue(ObjectPath,out string LoadActiveGraphickElement ))
        {
            if (CurrentActiveElementLink != LoadActiveGraphickElement)
            {
                return true;
            }
        }

        return false;
    }
    public override void Load()
    {
        if (UIInfo.settingsInformation.IsActiveGraphicks.TryGetValue(ObjectPath, out string LoadActiveGraphickElement))
        {
            CurrentActiveElementLink = LoadActiveGraphickElement;
        }
    }
    public override void Save()
    {
        if (UIInfo.settingsInformation.IsActiveGraphicks.ContainsKey(ObjectPath))
        {
            UIInfo.settingsInformation.IsActiveGraphicks.Remove(ObjectPath);
            UIInfo.settingsInformation.IsActiveGraphicks.Add(ObjectPath, CurrentActiveElementLink);
        }
        else
        {
            UIInfo.settingsInformation.IsActiveGraphicks.Add(ObjectPath, CurrentActiveElementLink);
        }
    }
}


