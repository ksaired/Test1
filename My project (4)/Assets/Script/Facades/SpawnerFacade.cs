using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFacade : MonoBehaviour
{
    public virtual string LoadSpawnInfoPath { protected set; get; }

    public virtual float LimitOfSpawnObject { protected set; get; }

    public virtual SpawnSaveInfo spawnInfo { protected set; get; }
    
    public virtual Dictionary<int, GameObject> CurrentActiveSpawnGameObject { protected set; get; }

    protected virtual List<GameObject> DeffaultSpawnObjects { set; get; }

    public virtual void StartFacade()
    {
        CurrentActiveSpawnGameObject = new Dictionary<int, GameObject>();

        StartCreateSpawnObject();
        StartChildrenObjects();
    }
    public virtual void StartCreateSpawnObject()
    {
        if (spawnInfo.CurrentSpawnObjects.Values != null)
        {
            foreach (var i in spawnInfo.CurrentSpawnObjects.Keys)
            {
                CreateSpawnObject(i);
            }
        }
              
    }
     public virtual void CreateSpawnObject(int NumberOfObject)
     {
        GameObject SpawnObject;
        if (spawnInfo.CurrentSpawnObjects.TryGetValue(NumberOfObject,out string PathOfSpawnObject))
        {
            if (PathOfSpawnObject != null)
            {
                SpawnObject = Resources.Load<GameObject>(PathOfSpawnObject);
                if (SpawnObject != null)
                {
                    SpawnObject = Instantiate(SpawnObject, transform);

                    SpawnObject = LoadChildrenInfo(SpawnObject, NumberOfObject);

                    CurrentActiveSpawnGameObject.Add(NumberOfObject, SpawnObject);
                }
            }
        }
     }
    public virtual void AddToCurrentSpawnObject(string newPathToSpawnObject)
    {
        if (spawnInfo.CurrentSpawnObjects.Count != LimitOfSpawnObject)
        {
            int NumberOfNewSpawnObject;
            if (spawnInfo.FreeNumbers.Count != 0)
            {
                NumberOfNewSpawnObject = spawnInfo.FreeNumbers[spawnInfo.FreeNumbers.Count];
                spawnInfo.FreeNumbers.Remove(NumberOfNewSpawnObject);
            }
            else
            {
                NumberOfNewSpawnObject = spawnInfo.currentNumberOFSpawnObject;
                spawnInfo.currentNumberOFSpawnObject++;
            }

            if (!spawnInfo.CurrentSpawnObjects.ContainsKey(NumberOfNewSpawnObject))
            {
                spawnInfo.CurrentSpawnObjects.Add(NumberOfNewSpawnObject, newPathToSpawnObject);
            }
        }

    }
    public virtual void RemoveFromSpawnObjects(int numberOfSpawnObject)
    {
        if (spawnInfo.CurrentSpawnObjects.ContainsKey(numberOfSpawnObject))
        {
            spawnInfo.CurrentSpawnObjects.Remove(numberOfSpawnObject);

            if (CurrentActiveSpawnGameObject.ContainsKey(numberOfSpawnObject))
            {
                CurrentActiveSpawnGameObject.Remove(numberOfSpawnObject);
            }

            spawnInfo.FreeNumbers.Add(numberOfSpawnObject);
            
        }
    }
    public virtual void LoadSpawnInfo(SpawnSaveInfo LoadSpawnSaveInfo)
    {
        spawnInfo = LoadSpawnSaveInfo;
    }
    public virtual void LoadDeffaultSpawnInfo()
    {
        spawnInfo = new SpawnSaveInfo();

        ConvertDeffaultSpawnObject();
    }   
    public virtual void ChangeLimitOfSpawnObjects(float NewLimitOfSpawnObject)
    {
        LimitOfSpawnObject = NewLimitOfSpawnObject;
    }
    public virtual SpawnSaveInfo SaveSpawnInfo()
    {
        SaveChildren();
        return spawnInfo;
    }
    public virtual GameObject LoadChildrenInfo(GameObject CurrentObject,int NumberOfObject)
    {
        if (CurrentObject.GetComponent<ObjectFacade>())
        {
            CurrentObject.GetComponent<ObjectFacade>().ChangeSpawnLoadPath(NumberOfObject);

            if (spawnInfo.ResourcesOfChildren.TryGetValue(CurrentObject.GetComponent<ObjectFacade>().SpawnLoadPath, out SaveResource CurrentObjectInfo))
            {
                CurrentObject.GetComponent<ObjectFacade>().Load(CurrentObjectInfo);
            }
            else
            {
                CurrentObject.GetComponent<ObjectFacade>().DeffaultLoad();
            }
            
        }
        return CurrentObject;
    }
    public virtual void SaveChildren()
    {
        
        foreach(var i in GetComponentsInChildren<ObjectFacade>())
        {
            if (CurrentActiveSpawnGameObject.TryGetValue(i.SpawnLoadPath,out GameObject currentObject))
            {
                if (i.gameObject == currentObject)
                {
                    if (spawnInfo.ResourcesOfChildren.ContainsKey(i.SpawnLoadPath))
                    {
                        spawnInfo.ResourcesOfChildren.Remove(i.SpawnLoadPath);
                        spawnInfo.ResourcesOfChildren.Add(i.SpawnLoadPath,i.CurrentInfo.currentSaveInfo);
                    }
                    else
                    {
                        spawnInfo.ResourcesOfChildren.Add(i.SpawnLoadPath, i.CurrentInfo.currentSaveInfo);
                    }
                }
            }
        }
    }
    protected virtual void StartChildrenObjects()
    {
        foreach (var i in GetComponentsInChildren<ObjectFacade>())
        {
            i.StartFacade();
        }
    }

    private void ConvertDeffaultSpawnObject()
    {
        GameObject DeffaultSpawnObject;

        foreach (var i in DeffaultSpawnObjects)
        {
           DeffaultSpawnObject = Instantiate(i);

           if (DeffaultSpawnObject.GetComponent<ObjectFacade>())
           {
              AddToCurrentSpawnObject(DeffaultSpawnObject.GetComponent<ObjectFacade>().PrefabLoadPath + DeffaultSpawnObject.GetComponent<ObjectFacade>().ObjectsPrefabsPath);
              Debug.Log(DeffaultSpawnObject.GetComponent<ObjectFacade>().PrefabLoadPath + DeffaultSpawnObject.GetComponent<ObjectFacade>().ObjectsPrefabsPath);
           }

           Destroy(DeffaultSpawnObject);
        }
    }
        
}
          
