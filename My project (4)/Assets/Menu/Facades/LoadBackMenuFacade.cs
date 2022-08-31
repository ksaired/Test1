using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LoadBackMenuFacade : LoadMenuFacade
{
    
    public virtual void LoadBackMenu()
    {
        LoadMenuPath = UIInfo.PreviusMenu[UIInfo.PreviusMenu.Count - 1];
        
        base.LoadFromPrefabs(LoadPathToKindAssets);

        UIInfo.RemoveFromPriviusMenu(LoadMenuPath);
        base.DestroyCurrentMenu(transform.parent.transform.parent.gameObject);
    }

}
