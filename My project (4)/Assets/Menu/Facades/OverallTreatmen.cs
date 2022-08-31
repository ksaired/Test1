using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class  OverallTreatmen : SettingsFacade
{
    public virtual string CurrentActiveElementLink { protected set; get; }

    public override void StartFacade()
    {
        CurrentSettingsInfo = UIInfo.settingsInformation;

        FindCurrentActiveElement();

        StartGraphickElements();
    }
    public override void Load()
    {
        if (UIInfo.settingsInformation.IsActiveGraphicks.TryGetValue(ObjectPath, out string value))
        {
            CurrentActiveElementLink = value;
        }
    }

    public override void Save()
    {

        if (!UIInfo.settingsInformation.IsActiveGraphicks.ContainsKey(ObjectPath))
        {
            UIInfo.settingsInformation.IsActiveGraphicks.Add(ObjectPath, CurrentActiveElementLink);

        }
        else if (UIInfo.settingsInformation.IsActiveGraphicks.ContainsKey(ObjectPath))
        {
            UIInfo.settingsInformation.IsActiveGraphicks.Remove(ObjectPath);
            UIInfo.settingsInformation.IsActiveGraphicks.Add(ObjectPath, CurrentActiveElementLink);

        }
        
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        if (PreviusSaveInfo.IsActiveGraphicks.TryGetValue(ObjectPath, out string value))
        {
            if (CurrentActiveElementLink != value)
            {
                return true;
            }
        }

        return false;
    }
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
        Debug.Log(CurrentActiveElementLink);
    }
    protected virtual void RemoveActiveElementOfTexture()
    {
        foreach (var i in transform.gameObject.GetComponentsInChildren<LevelOfOverallGraphic>())
        {
            if (i.LevelOf == CurrentActiveElementLink)
            {
                i.GetComponent<Image>().sprite = i.DefaultSprite;
            }
        }
    }

    protected virtual void FindCurrentActiveElement()
    {
        foreach (var i in transform.gameObject.GetComponentsInChildren<LevelOfOverallGraphic>())
        {
            if (i.LevelOf == CurrentActiveElementLink)
            {
                ChangeActiveGraphicElement(i);
            }
        }
    }
    protected virtual void ChangeAnotherTreatments()
    {
        foreach (var i in gameObject.GetComponentsInChildren<TretmenOfGraphicMenuFacade>())
        {
            if (i.CurrentActiveElementLink != CurrentActiveElementLink)
            {
                foreach (var a in i.GetComponentsInChildren<LevelOfGraphic>())
                {
                    if (a.LevelOf == CurrentActiveElementLink)
                    {
                        i.ReplaceActiveGraphickElements(a);
                    }
                }

            }
        }
    }
    protected virtual void StartGraphickElements()
    {
        foreach(var i in GetComponentsInChildren<LevelOfOverallGraphic>())
        {
            i.StartFacade();
        }
    }
   
}
