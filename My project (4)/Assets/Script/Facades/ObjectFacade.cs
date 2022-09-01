using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectFacade : MonoBehaviour
{
    public virtual Resource CurrentInfo { protected set; get; }
        
    public virtual string LoadPath { protected set; get; }
    public virtual string ObjectsPrefabsPath { get ; protected set ; }
    public virtual string PrefabLoadPath { protected set => PrefabLoadPath = value; get => ObjectFacadePrefabsPath; }
    public virtual int SpawnLoadPath { protected set; get; }

    protected string ObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("ObjectFacadePrefabsPath");

    public virtual void ChangeCurentInfo(Resource NewInfo)
    {
        CurrentInfo = NewInfo;
    }

    public virtual void ChangeSpawnLoadPath(int NewSpawnLoadPath)
    {
        SpawnLoadPath = NewSpawnLoadPath;
    }
    public virtual void ChangeLoadPath(string NewLoadPath)
    {
        LoadPath = NewLoadPath;
    }
   
    public virtual void StartFacade()
    {
        StartTreatmentState();
    }
    
    protected virtual void StartTreatmentState()
    {
        CurrentInfo = CurrentInfo.CurrentStateFacade.StartFacade(CurrentInfo);
        
       
        CurrentInfo = CurrentInfo.CurrentMainStateFacade.StartFacade(CurrentInfo);
    }
    public abstract void Load(SaveResource LoadResource);
    public abstract void DeffaultLoad();
    public abstract SaveResource Save();
}
