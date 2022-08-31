using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SettingsFacade : ActiveFacade
{
    public virtual SettingSaveInfo CurrentSettingsInfo { protected set; get; }

    public virtual void ChangeSettingsInfo(SettingSaveInfo NewCurrentSettingsInfo)
    {
        CurrentSettingsInfo = NewCurrentSettingsInfo;
    }
    public abstract bool IsChange(SettingSaveInfo PreviusSaveInfo);
                
}
