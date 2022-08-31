using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class GameSaveButtonFacade : LoadMenuFacade
{
    public virtual string GameSaveInfoPath { protected set; get; }
    public virtual string DeffaultGameSaveFailePath {protected set;get; }

    public virtual GameSaveInfo CurrentGameSaveInfo { protected set; get; }
    
    public virtual GameObject TextOfCharapter { protected set; get; }
    public virtual GameObject TextOfTimer { protected set; get; }

    protected SaveAndLoad LoadScript = new SaveAndLoad();
    
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
        CreateNewFailePath();

        LoadTextOfCharapterPrefabs();

        LoadTextTimerPrefab();
    }
    public override void Load()
    {
        if (UIInfo.saveInformation.GameSavePath.TryGetValue(ObjectPath,out string LoadGameSaveInfoPath))
        {
            DeffaultGameSaveFailePath = LoadGameSaveInfoPath;
        }
        Debug.Log(DeffaultGameSaveFailePath);
        
    }
    public override void Save()
    {
        if (UIInfo.saveInformation.GameSavePath.ContainsKey(ObjectPath))
        {
            UIInfo.saveInformation.GameSavePath.Remove(ObjectPath);
            UIInfo.saveInformation.GameSavePath.Add(ObjectPath,DeffaultGameSaveFailePath);
        }
        else
        {
            UIInfo.saveInformation.GameSavePath.Add(ObjectPath, DeffaultGameSaveFailePath);
        }
    }
    public override void LoadFromPrefabs(string PathToKindAssets)
    {
        base.LoadFromPrefabs(PathToKindAssets);
    }

    public virtual void ChangeDeffaultGameSaveInfoPath(string NewDeffaultGameSaveInfoPath)
    {
        DeffaultGameSaveFailePath = NewDeffaultGameSaveInfoPath;
    }
    public virtual void LoadTextOfGameSaveButton()
    {
        LoadTextOfCharapter();
        LoadTextOfTimer();
    }
    public virtual void LoadTextOfCharapter()
    {
        if (TextOfCharapter != null)
        {
            TextOfCharapter.GetComponent<Text>().text = CurrentGameSaveInfo.CharapterOfGame + ":" + CurrentGameSaveInfo.LatestLevel;
        }
    }
    public virtual void LoadTextOfTimer()
    {
        if (TextOfTimer != null)
        {
            TextOfTimer.GetComponent<Text>().text = "12";
        }
    }

    protected virtual void CreateNewFailePath()
    {
        GameSaveInfoPath = Application.persistentDataPath + DeffaultGameSaveFailePath;
        LoadGameSaveInfo();
    }
    protected virtual void LoadTextOfCharapterPrefabs()
    {
        LoadGameObjectPrefab("TextOfCharapter", out GameObject LoadTextCharapterObject);

        TextOfCharapter = Instantiate(LoadTextCharapterObject, transform);
        LoadTextOfCharapter();
    }
    protected virtual void LoadTextTimerPrefab()
    {
        LoadGameObjectPrefab("TextOfTimer", out GameObject LoadTextTimerObject);

        TextOfTimer = Instantiate(LoadTextTimerObject, transform);
        LoadTextOfTimer();

    }
    protected virtual void LoadCheckMenu()
    {
        LoadMenuPath = "CheckOpenSaveMenu";

        UIInfo.ChangeCurrentGameSavePath(DeffaultGameSaveFailePath);

        CreateMenu();
    }
    protected virtual  void MadeNewGameSaveFaile()
    {
        LoadMenuPath = "CreateNewGameSaveMenu";

        UIInfo.ChangeCurrentGameSavePath(DeffaultGameSaveFailePath);
        UIInfo.ChangeCurrentDeleteMenu(transform.parent.parent.gameObject);

        CreateMenu();
    }
    protected virtual void LoadChooseMenu()
    {
        LoadMenuPath = "CheckDeleteGameSaveMenu";

        UIInfo.ChangeCurrentGameSavePath(DeffaultGameSaveFailePath);
        
        CreateMenu();
    }
    protected virtual void LoadSorryMessage()
    {
       LoadMenuPath = "SorryGameSaveMessage";

       CreateMenu();
    }
    protected virtual void LoadSaveMenu()
    {
        LoadMenuPath = "SaveWhetherGameSaveMenu";

        UIInfo.ChangeCurrentGameSavePath(DeffaultGameSaveFailePath);

        CreateMenu();
    }
    protected virtual void LoadGameObjectPrefab(string Link, out GameObject LoadGameObject)
    {
        LoadGameObject = Resources.Load<GameObject>("Prefabs/" + Link);
    }
    protected virtual void LoadGameSaveInfo()
    {
        CurrentGameSaveInfo = LoadScript.Load(new GameSaveInfo(new DeffaultGameSaveInfo()), GameSaveInfoPath);
    }
    protected virtual void CreateMenu()
    {
        UIInfo.DisactiveAnotherButton();
        LoadFromPrefabs(LoadPathToKindAssets);
    }
}
