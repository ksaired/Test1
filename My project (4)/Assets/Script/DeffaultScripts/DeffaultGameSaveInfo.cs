using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeffaultGameSaveInfo
{
    public Dictionary<string, SaveResource> CurrentPlayerInfo = new Dictionary<string, SaveResource>();
    public Dictionary<string, string> DeffaultPlayerSpawnObjects = new Dictionary<string, string>()
    {
        {"Player1", "Prefabs/Objects/PlayerPrefabs/Player"}
    };

    public string LatestLevel = "FirstLevel";
    public string CharapterOfGame = "Charapter1";
    public string DefficultOfGame = "HardDifficult";

}
