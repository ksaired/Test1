using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveWhetherChange : LoadBackMenuFacade
{
    public override GameObject LoadMenu { get => base.LoadMenu; protected set => base.LoadMenu = value; }

    public override string LoadMenuPath { get => base.LoadMenuPath; protected set => base.LoadMenuPath = value; }
    public override string ObjectPath { get => DeffaultMainMenuPath; protected set => DeffaultMainMenuPath = value; }
    public override string LoadPathToKindAssets { get => DeffaultLoadPathToKindAssets; protected set => DeffaultLoadPathToKindAssets = value; }

    private string DeffaultLoadPathToKindAssets = "MenuPrefabs";
    private string DeffaultMainMenuPath = "SaveWhetherChangeMenuPath";

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
    public override void LoadBackMenu()
    {
        base.LoadBackMenu();
    }

    public void Exit()
    {
        UIInfo.Save();
        
        LoadMenuPath = UIInfo.PreviusMenu[UIInfo.PreviusMenu.Count - 1];

        base.LoadFromPrefabs(LoadPathToKindAssets);

        UIInfo.RemoveFromPriviusMenu(LoadMenuPath);

        base.DestroyCurrentMenu(UIInfo.CurrenDeleteMenu);
        base.DestroyCurrentMenu(transform.parent.gameObject);
    }

}
