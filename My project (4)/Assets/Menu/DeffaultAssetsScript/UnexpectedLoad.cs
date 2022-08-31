using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnexpectedLoad : MonoBehaviour
{
    private SaveandLoadAnotherAssets LoadAnotherAssets = new SaveandLoadAnotherAssets();
    void Start()
    {

        LoadChildren();
        StartChildren();
        
    }

   private void LoadChildren()
   {
        foreach (var i in GetComponentsInChildren<Facade>())
        {
            i.Load();
        }
        LoadAnotherAssets.Load();
   }
   private void StartChildren()
   {
        foreach (var i in GetComponentsInChildren<ActiveFacade>())
        {
            i.StartFacade();
        }
    }
   
 
    
}
