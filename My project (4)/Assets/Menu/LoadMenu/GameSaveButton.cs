using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameSaveButton : GameSaveButtonFacade
{
    public override string LoadMenuPath { get => base.LoadMenuPath; protected set => base.LoadMenuPath = value; }
    public override string LoadPathToKindAssets { get => DeffaultLoadPathToKindAssets; protected set => DeffaultLoadPathToKindAssets = value; }
    public override string ObjectPath { get => DeffaultObjectPath; protected set => DeffaultObjectPath = value; }
    public override string GameSaveInfoPath { get => base.GameSaveInfoPath; protected set => base.GameSaveInfoPath = value; }
    public override string DeffaultGameSaveFailePath { get => DeffaultGameSave1Path; protected set => DeffaultGameSave1Path = value; }

    public override GameSaveInfo CurrentGameSaveInfo { get => base.CurrentGameSaveInfo; protected set => base.CurrentGameSaveInfo = value; }

    public override GameObject LoadMenu { get => base.LoadMenu; protected set => base.LoadMenu = value; }
    public override GameObject TextOfCharapter => base.TextOfCharapter;
    public override GameObject TextOfTimer => base.TextOfTimer;

    [SerializeField]
    private string DeffaultObjectPath = "Save1";

    private string DeffaultGameSave1Path = "GameSave1";
    private string DeffaultLoadPathToKindAssets = UIInfo.GetLinkToAssets("ChooseMenuLoadPathToKindAssetsPath");

    public void CheckExist()
    {

        if (File.Exists(GameSaveInfoPath) || File.Exists(GameSaveInfoPath + "SpareSave"))
        {
            LoadCheckMenu();
        }
        else
        {
            MadeNewGameSaveFaile();
        }
    }

    public void DeleteSave()
    {
        if (File.Exists(GameSaveInfoPath) || File.Exists(GameSaveInfoPath + "SpareSave"))
        {
            LoadChooseMenu();
        }
        else
        {
            LoadSorryMessage();
        }
    }
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
    public override void ChangeDeffaultGameSaveInfoPath(string NewDeffaultGameSaveInfoPath)
    {
        base.ChangeDeffaultGameSaveInfoPath(NewDeffaultGameSaveInfoPath);
    }

    public override void StartFacade()
    {
        base.StartFacade();
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
    public override void LoadTextOfGameSaveButton()
    {
        base.LoadTextOfGameSaveButton();
    }
    public override void LoadTextOfCharapter()
    {
        base.LoadTextOfCharapter();
    }
    public override void LoadTextOfTimer()
    {
        base.LoadTextOfTimer();
    }

    protected override void LoadTextOfCharapterPrefabs()
    {
        base.LoadTextOfCharapterPrefabs();
    }
    protected override void LoadTextTimerPrefab()
    {
        base.LoadTextTimerPrefab();

    }
    protected override void CreateNewFailePath()
    {
        base.CreateNewFailePath();
    }
    protected override void MadeNewGameSaveFaile()
    {
        base.MadeNewGameSaveFaile();
    }
    protected override void LoadChooseMenu()
    {
        base.LoadChooseMenu();
    }
    protected override void LoadSorryMessage()
    {
        base.LoadSorryMessage();
    }
    protected override void LoadCheckMenu()
    {
        base.LoadCheckMenu();
    }
    protected override void LoadGameSaveInfo()
    {
        base.LoadGameSaveInfo();
    }
    protected override void LoadGameObjectPrefab(string Link, out GameObject LoadGameObject)
    {
        base.LoadGameObjectPrefab(Link, out LoadGameObject);
    }
    protected override void CreateMenu()
    {
        base.CreateMenu();
    }
}
