using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class LoadMenuFacade : ActiveFacade
{

    public virtual GameObject LoadMenu { protected set; get; }
    public virtual string LoadMenuPath { protected set; get; }
    public virtual string LoadPathToKindAssets { protected set; get; }

    public virtual void ChangeLoadMenuPath(string newLoadMenuPath)
    {
        LoadMenuPath = newLoadMenuPath;
    }
    public virtual void ChangeLoadPathToKindAssets(string newLoadMenuPath)
    {
        LoadMenuPath = newLoadMenuPath;
    }
    public virtual void LoadFromPrefabs(string PathToKindAssets)
    {
        LoadMenu = Resources.Load<GameObject>("Prefabs/" + PathToKindAssets + "/" + LoadMenuPath);
        LoadMenu = Instantiate(LoadMenu, LoadMenu.transform.parent);
    }
    public virtual void DestroyCurrentMenu(GameObject CurrentDeleteObject)
    {
        Destroy(CurrentDeleteObject);
    }

    public override void Load()
    {
        if (UIInfo.saveInformation.LoadMenuPaths.TryGetValue(ObjectPath,out string CurrentLoadMenuPath))
        {
            LoadMenuPath = CurrentLoadMenuPath;
        }
    }
    public override void Save()
    {
        if (UIInfo.saveInformation.LoadMenuPaths.ContainsKey(ObjectPath))
        {
            UIInfo.saveInformation.LoadMenuPaths.Remove(ObjectPath);
            UIInfo.saveInformation.LoadMenuPaths.Add(ObjectPath,LoadMenuPath);
        }
        else
        {
            UIInfo.saveInformation.LoadMenuPaths.Add(ObjectPath, LoadMenuPath);
        }
    }
}
