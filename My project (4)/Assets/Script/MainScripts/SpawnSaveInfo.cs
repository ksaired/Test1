using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnSaveInfo 
{
    [SerializeReference]   public Dictionary<int, string> CurrentSpawnObjects = new Dictionary<int, string>();
       
    public int currentNumberOFSpawnObject = 0;

    public List<int> FreeNumbers = new List<int>();

    [SerializeReference]  public Dictionary<int,SaveResource> ResourcesOfChildren = new Dictionary<int, SaveResource>();
   
}
