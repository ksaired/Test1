using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameSaveInfo 
{
   [SerializeReference] public Dictionary<string, SaveResource> CurrentPlayerInfo = new Dictionary<string, SaveResource>();
   [SerializeReference] public Dictionary<string, string> DeffaultPlayerSpawnObjects = new Dictionary<string, string>();

   public string LatestLevel;
   public string CharapterOfGame;
   public string DefficultOfGame;

   public string LatestLevelScene;

   public int Test; 

   public GameSaveInfo(DeffaultGameSaveInfo DeffaultGameSaveInfo)
   {
        CurrentPlayerInfo = DeffaultGameSaveInfo.CurrentPlayerInfo;

        DeffaultPlayerSpawnObjects = DeffaultGameSaveInfo.DeffaultPlayerSpawnObjects;

        LatestLevel = DeffaultGameSaveInfo.LatestLevel;

        CharapterOfGame = DeffaultGameSaveInfo.CharapterOfGame;

        DefficultOfGame = DeffaultGameSaveInfo.DefficultOfGame;
   }
}
