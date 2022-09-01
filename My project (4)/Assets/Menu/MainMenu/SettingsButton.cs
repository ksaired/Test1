using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : LoadMenuFacade
{

    public override GameObject LoadMenu { get => base.LoadMenu; protected set => base.LoadMenu = value; }

    public override string LoadMenuPath { get => base.LoadMenuPath; protected set => base.LoadMenuPath = value; }
    public override string ObjectPath { get => DeffaultObjectsPath; protected set => DeffaultObjectsPath = value; }
    public override string LoadPathToKindAssets { get => DeffaultLoadPathToKindAssets; protected set => DeffaultLoadPathToKindAssets = value; }

    private string DeffaultLoadPathToKindAssets = UIInfo.GetLinkToAssets("MenuPrefabsLoadPathToKindAssetsPath");
    private string DeffaultObjectsPath = "SettingsMenuPath";
    
    public override void ChangeLoadMenuPath(string newLoadMenuPath)
    {
        base.ChangeLoadMenuPath(newLoadMenuPath);
    }
    public override void ChangeLoadPathToKindAssets(string newLoadMenuPath)
    {
        base.ChangeLoadPathToKindAssets(newLoadMenuPath);
    }
    public override void ChangeObjectPath(string NewObjectPath)
    {
        base.ChangeObjectPath(NewObjectPath);
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
    public override void LoadFromPrefabs(string PathToKindAssets)
    {
        base.LoadFromPrefabs(PathToKindAssets);
    }

    public void LoadFutureMenu()
    {
        LoadFromPrefabs(LoadPathToKindAssets);
        UIInfo.AddToPriviusMenu(transform.parent.gameObject.name);
        base.DestroyCurrentMenu(transform.parent.parent.gameObject);
    }

}
