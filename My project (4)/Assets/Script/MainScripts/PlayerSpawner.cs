using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public float LimitOfPlayerSpawnObject { private set; get; }
    public string CurrentPlayerSpawnerPath {  private set => DeffaultPlayerSpawnerPath = value; get => DeffaultPlayerSpawnerPath; }

    public Dictionary<string, GameObject> CurrentActiveSpawnGameObject { private set; get; }
    public PlayerSpawnInfo CurrentPlayerSpawnInfo { private set; get; }

    [SerializeField]
    private string DeffaultPlayerSpawnerPath;
        
    public void StartFacade()
    {
        CurrentActiveSpawnGameObject =  new Dictionary<string, GameObject>();
        StartCreatePlayerSpawnObject();
        StartPlayerObjects();
    }

    public void StartCreatePlayerSpawnObject()
    {
        foreach (var i in SceneInfo.CurrentGameSaveInfo.DeffaultPlayerSpawnObjects.Keys)
        {
            CreateSpawnObject(i);
        }
    }

    public void CreateSpawnObject(string PathOfPlayerObject)
    {
        if (SceneInfo.CurrentGameSaveInfo.DeffaultPlayerSpawnObjects.TryGetValue(PathOfPlayerObject, out string SpawnObjectPath))
        {
             GameObject SpawnObject = Resources.Load<GameObject>(SpawnObjectPath);
            
            if (SpawnObject != null)
            {
                Debug.Log("2");                

                SpawnObject = Instantiate(SpawnObject, transform);

                SpawnObject = LoadPlayerInfo(SpawnObject, PathOfPlayerObject);

                CurrentActiveSpawnGameObject.Add(PathOfPlayerObject, SpawnObject);
              
               
            }
        }
    }
      
    public void LoadPlayerSpawnInfo(PlayerSpawnInfo LoadPlayerSpawnSaveInfo)
    {
        CurrentPlayerSpawnInfo = LoadPlayerSpawnSaveInfo;
        
    }
    public void DeffaultPlayerSpawnInfo()
    {
        CurrentPlayerSpawnInfo = new PlayerSpawnInfo();
    }
    public GameObject LoadPlayerInfo(GameObject CurrentObject,string PathOfPlayerObject)
    {
        if (CurrentObject.GetComponent<PlayerObjectFacade>())
        {
            if (SceneInfo.CurrentGameSaveInfo.CurrentPlayerInfo.TryGetValue(CurrentObject.GetComponent<PlayerObjectFacade>().LoadPath,out SaveResource LoadSaveInfo))
            {
                CurrentObject.GetComponent<PlayerObjectFacade>().Load(LoadSaveInfo);
            }
            else 
            {
                CurrentObject.GetComponent<PlayerObjectFacade>().DeffaultLoad();
            }
            CurrentObject.GetComponent<PlayerObjectFacade>().ChangePlayerSpawnPath(PathOfPlayerObject);
        }
        return CurrentObject;
    }
    public PlayerSpawnInfo SavePlayerSpawnerSaveInfo()
    {
        return CurrentPlayerSpawnInfo;
    }

    public GameSaveInfo SavePlayerInfo(GameSaveInfo CurrentGameSaveInfo)
    {
        foreach (var i in GetComponentsInChildren<PlayerObjectFacade>())
        {
            Debug.Log(i);
            Debug.Log(i.PlayerSpawnPath);
           if (CurrentActiveSpawnGameObject.TryGetValue(i.PlayerSpawnPath, out GameObject currentObject))
           {
               
               if (i.gameObject == currentObject)
               {
                    if (CurrentGameSaveInfo.CurrentPlayerInfo.ContainsKey(i.LoadPath))
                    {
                        CurrentGameSaveInfo.CurrentPlayerInfo.Remove(i.LoadPath);
                        CurrentGameSaveInfo.CurrentPlayerInfo.Add(i.LoadPath,i.CurrentPlayerInfo.currentSaveInfo);
                    }
                    else
                    {
                        CurrentGameSaveInfo.CurrentPlayerInfo.Add(i.LoadPath, i.CurrentPlayerInfo.currentSaveInfo);
                    }
               }
           }
        }
        return CurrentGameSaveInfo;
    }

    private void StartPlayerObjects()
    {
        foreach (var i in GetComponentsInChildren<PlayerObjectFacade>())
        {
            i.StartFacade();
            Debug.Log("3");
        }
    }
    public void ChangeLimitOfSpawnObjects(float NewLimitOfSpawnObject)
    {
        LimitOfPlayerSpawnObject = NewLimitOfSpawnObject;
    }
    public void ChangePlayerSpawnerPath(string NewPlayerSpawnerPath)
    {
        CurrentPlayerSpawnerPath = NewPlayerSpawnerPath;
    }
}
