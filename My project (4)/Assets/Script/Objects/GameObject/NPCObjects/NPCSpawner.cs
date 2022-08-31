using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : SpawnerFacade
{
    public override string LoadSpawnInfoPath { get => NPCSpawnerLoadPath; protected set => NPCSpawnerLoadPath = value; }
    public override float LimitOfSpawnObject { get => NPCObjectLimit; protected set => NPCObjectLimit = value; }

    public override SpawnSaveInfo spawnInfo { get => base.spawnInfo; protected set => base.spawnInfo = value; }


    public override Dictionary<int, GameObject> CurrentActiveSpawnGameObject { get => base.CurrentActiveSpawnGameObject; protected set => base.CurrentActiveSpawnGameObject = value; }

    protected override List<GameObject> DeffaultSpawnObjects { get => DeffaultNPCSpawnerObjects; set => DeffaultNPCSpawnerObjects = value; }

    private float NPCObjectLimit = 100;

    [SerializeField]
    private string NPCSpawnerLoadPath;
    [SerializeField]
    private List<GameObject> DeffaultNPCSpawnerObjects = new List<GameObject>();

    public override void StartFacade()
    {
        base.StartFacade();
    }

    public override void StartCreateSpawnObject()
    {
        base.StartCreateSpawnObject();
    }

    public override void LoadSpawnInfo(SpawnSaveInfo LoadSpawnSaveInfo)
    {
        base.LoadSpawnInfo(LoadSpawnSaveInfo);
    }

    public override void LoadDeffaultSpawnInfo()
    {
        base.LoadDeffaultSpawnInfo();
    }

    public override GameObject LoadChildrenInfo(GameObject CurrentObject, int NumberOfObject)
    {
        return base.LoadChildrenInfo(CurrentObject, NumberOfObject);
    }

    public override SpawnSaveInfo SaveSpawnInfo()
    {
        return base.SaveSpawnInfo();
    }

    public override void SaveChildren()
    {
        base.SaveChildren();
    }

    public override void CreateSpawnObject(int NumberOfObject)
    {
        base.CreateSpawnObject(NumberOfObject);
    }

    public override void AddToCurrentSpawnObject(string newPathToSpawnObject)
    {
        base.AddToCurrentSpawnObject(newPathToSpawnObject);
    }
    public override void RemoveFromSpawnObjects(int numberOfSpawnObject)
    {
        base.RemoveFromSpawnObjects(numberOfSpawnObject);
    }
    public override void ChangeLimitOfSpawnObjects(float NewLimitOfSpawnObject)
    {
        base.ChangeLimitOfSpawnObjects(NewLimitOfSpawnObject);
    }
}
