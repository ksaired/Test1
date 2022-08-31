using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class TreatmentOfChooseLanguage : SettingsFacade
{
    public override SettingSaveInfo CurrentSettingsInfo { get => base.CurrentSettingsInfo; protected set => base.CurrentSettingsInfo = value; }
   
    private SaveandLoadAnotherAssets LoadAnotherAssets = new SaveandLoadAnotherAssets();
    private Dropdown CurrenrDropDown;

    private int NumberOfCurrentLanguage = 0;

    public override void ChangeSettingsInfo(SettingSaveInfo NewCurrentSettingsInfo)
    {
        base.ChangeSettingsInfo(NewCurrentSettingsInfo);
    }
     
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        if (PreviusSaveInfo.CurrentLanguage != UIInfo.settingsInformation.CurrentLanguage)
        {
            return true;
        }
        return false;
    }
    public override void Load()
    {
       NumberOfCurrentLanguage = UIInfo.settingsInformation.AllLanguage.FindIndex(i => i == UIInfo.settingsInformation.CurrentLanguage);
    }

    public override void Save()
    {
       UIInfo.settingsInformation.CurrentLanguage = UIInfo.settingsInformation.AllLanguage[NumberOfCurrentLanguage];
    }
    public override void StartFacade()
    {
        CurrenrDropDown = GetComponent<Dropdown>();
        CurrentSettingsInfo = UIInfo.settingsInformation;

        CurrenrDropDown.value = NumberOfCurrentLanguage;
    }
       
    
    public void ChangeLanguage() 
    {
        
        if (NumberOfCurrentLanguage != CurrenrDropDown.value && UIInfo.settingsInformation.AllLanguage.Count >= CurrenrDropDown.value)
        {
            
            NumberOfCurrentLanguage = CurrenrDropDown.value;
            UIInfo.settingsInformation.CurrentLanguage = UIInfo.settingsInformation.AllLanguage[NumberOfCurrentLanguage];
            
            LoadLanguageText();
        }
    }

    private void LoadLanguageText()
    {
        if (UIInfo.saveInformation.DictionaryOfText.TryGetValue(UIInfo.settingsInformation.CurrentLanguage, out Dictionary<string, string> dictinonaryOfText))
        {
            LoadAnotherAssets.LoadTextAssets();
        }
    }
    
}
