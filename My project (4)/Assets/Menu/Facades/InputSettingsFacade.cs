using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputSettingsFacade : SettingsFacade
{
    public virtual KeyCode currentTreatmenButtonValue  { protected set; get; }
    public virtual bool IsChooseButton { protected set; get; }

    public override void StartFacade()
    {
        IsChooseButton = false;

        currentTreatmenButtonValue = new KeyCode();

        CurrentSettingsInfo = UIInfo.settingsInformation;

        StartChildren();
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        if (PreviusSaveInfo.InputSettings.TryGetValue(ObjectPath, out Dictionary<string, KeyCode> CurrentInputButton))
        {
            foreach (var i in transform.gameObject.GetComponentsInChildren<InputButtonValueFacade>())
            {
                if (CurrentInputButton.TryGetValue(i.ButtonKey, out KeyCode LoadValue))
                {
                    if (i.ButtonValue != LoadValue)
                    {
                        return true;
                    }
                }

            }
        }

        return false;
    }
    public override void Load()
    {
        if (UIInfo.settingsInformation.InputSettings.TryGetValue(ObjectPath, out Dictionary<string, KeyCode> CurrentInputButton))
        {
            foreach (var i in transform.gameObject.GetComponentsInChildren<InputButtonValueFacade>())
            {
                if (CurrentInputButton.TryGetValue(i.ButtonKey, out KeyCode LoadValue))
                {
                    i.ChangeOfButtonValue(LoadValue);
                }

            }
        }
    }
    public override void Save()
    {
        if (UIInfo.settingsInformation.InputSettings.TryGetValue(ObjectPath, out Dictionary<string, KeyCode> CurrentInputButton))
        {
            foreach (var i in transform.gameObject.GetComponentsInChildren<InputButtonValueFacade>())
            {
                if (CurrentInputButton.ContainsKey(i.ButtonKey))
                {
                    CurrentInputButton.Remove(i.ButtonKey);
                    CurrentInputButton.Add(i.ButtonKey,i.ButtonValue);
                }
                else
                {
                    CurrentInputButton.Add(i.ButtonKey, i.ButtonValue);
                }

            }
        }
    }
    public virtual void StartChildren()
    {
        foreach (var i in GetComponentsInChildren<InputButtonValueFacade>())
        {
            i.StartFacade();
        }
    }
}
