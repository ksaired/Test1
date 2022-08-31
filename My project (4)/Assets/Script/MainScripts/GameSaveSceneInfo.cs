using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSaveSceneInfo 
{
    [SerializeReference] public Dictionary<string, SpawnSaveInfo> SpawnersInfo = new Dictionary<string, SpawnSaveInfo>();

    [SerializeReference] public Dictionary<string, PlayerSpawnInfo> PlayerSpawnersInfo = new Dictionary<string, PlayerSpawnInfo>()
    {
        { "PlayerSpawner1",new PlayerSpawnInfo()}
    };

    
}
