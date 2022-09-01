using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LoadBackMenuFacade : LoadMenuFacade
{
    
    public virtual void LoadBackMenu()
    {
        string CurrentPreviusMenu = UIInfo.PreviusMenu[UIInfo.PreviusMenu.Count - 1];
        LoadMenuPath = "/" + CurrentPreviusMenu;

        Debug.Log(LoadMenuLoadPathToKindAssets + LoadPathToKindAssets + LoadMenuPath);

        base.LoadFromPrefabs(LoadPathToKindAssets);

        UIInfo.RemoveFromPriviusMenu(CurrentPreviusMenu);

        base.DestroyCurrentMenu(transform.parent.transform.parent.gameObject);
    }

}
