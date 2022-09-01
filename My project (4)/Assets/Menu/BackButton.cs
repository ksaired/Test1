using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackButton : LoadBackMenuFacade
{
    public override GameObject LoadMenu { get => base.LoadMenu; protected set => base.LoadMenu = value; }

    public override string LoadMenuPath { get => base.LoadMenuPath; protected set => base.LoadMenuPath = value; }
    public override string ObjectPath { get => DeffaultObjectPath; protected set => DeffaultObjectPath = value; }
    public override string LoadPathToKindAssets { get => DeffaultLoadPathToKindAssets; protected set => DeffaultLoadPathToKindAssets = value; }

    private string DeffaultLoadPathToKindAssets = UIInfo.GetLinkToAssets("MenuPrefabsLoadPathToKindAssetsPath");
    private string DeffaultObjectPath = "BackMenuPath";
  
    private SettingSaveInfo settingsSaveInfo = new SettingSaveInfo(new DeffaultSettingsInfo()) ;
    private SaveInformation SaveInfo = new SaveInformation(new DeffaultSaveInfo());
    
    private SaveAndLoad LoadScript = new SaveAndLoad();
    public override void ChangeLoadMenuPath(string newLoadMenuPath)
    {
        base.ChangeLoadMenuPath(newLoadMenuPath);
    }
    public override void ChangeObjectPath(string NewObjectPath)
    {
        base.ChangeObjectPath(NewObjectPath);
    }
    public override void ChangeLoadPathToKindAssets(string newLoadMenuPath)
    {
        base.ChangeLoadPathToKindAssets(newLoadMenuPath);
    }
    public override void StartFacade()
    {

    }
    public override void Load()
    {
        base.Load();
    }
    public override void Save()
    {
        base.Save();
    }
    public override void LoadBackMenu()
    {
        base.LoadBackMenu();
    }
    public override void LoadFromPrefabs(string PathToKindAssets)
    {
        base.LoadFromPrefabs(PathToKindAssets);
    }

    public void Exit()
    {
       
        if (IsHaveChange())
        {
            LoadCheckWhetherSaveChangeMenu();
        }
        else
        {
            UIInfo.Save();
            LoadBackMenu();
        }
    }

    private bool IsHaveChange()
    {
        LoadPrevioslyInformations();

        if (CheckSpriteFacade()||CheckSettingsFacade())
        {
            return true;
        }

        return false;
    }
    private bool CheckSpriteFacade()
    {
        foreach (var i in transform.parent.gameObject.GetComponentsInChildren<SpriteFacade>())
        {
            if (SaveInfo.SpritePath.TryGetValue(i.SpriteFacadePath, out string value))
            {
                if (i.PathToSprite != value)
                {
                    return true;
                }
            }

        }
        return false;
    }
    private bool CheckSettingsFacade()
    {
        foreach (var i in transform.parent.gameObject.GetComponentsInChildren<SettingsFacade>())
        {
            if (i.IsChange(settingsSaveInfo))
            {
                return true;
            }

        }
        return false;
    }
    private void LoadPrevioslyInformations()
    {
        settingsSaveInfo = LoadScript.Load(UIInfo.settingsInformation,UIInfo.SettingsSaveInfoPath);
        SaveInfo = LoadScript.Load(UIInfo.saveInformation,UIInfo.SaveUIInfoPath);
    }
    private void LoadCheckWhetherSaveChangeMenu()
    {
        LoadPathToKindAssets = UIInfo.GetLinkToAssets("ChooseMenuLoadPathToKindAssetsPath");
             
        UIInfo.DisactiveAnotherButton();
        UIInfo.ChangeCurrentDeleteMenu(transform.parent.transform.parent.gameObject);
        LoadFromPrefabs(LoadPathToKindAssets);
    }
}
