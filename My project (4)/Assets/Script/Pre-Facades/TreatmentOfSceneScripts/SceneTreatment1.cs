using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTreatment1 : SceneTreatmentFacade
{
    public override GameSaveSceneInfo CurrentGameSaveInfo { get => base.CurrentGameSaveInfo; protected set => base.CurrentGameSaveInfo = value; }
    public override string GameSaveSceneInfoPath { get => base.GameSaveSceneInfoPath; protected set => base.GameSaveSceneInfoPath = value; }
    public override string DeffaultGameSaveSceneInfoPath { get => DeffaultGameSaveInfoPath; protected set => DeffaultGameSaveInfoPath = value; }

    private string DeffaultGameSaveInfoPath = "SceneTreatment1855877999999";

    [SerializeField]
    private PlayerSpawner CurrentPlayerSpawner = new PlayerSpawner();

    public override void Start()
    {
        CurrentGameSaveInfo = new GameSaveSceneInfo();

        SceneInfo.ChangePlayerSpawner(CurrentPlayerSpawner);

        base.Start();
        
    }

    public override void ChangeGameSaveSceneInfoPath(string NewGameSaveSceneInfoPath)
    {
        base.ChangeGameSaveSceneInfoPath(NewGameSaveSceneInfoPath);
    }
    public override void ChangeDeffaultGameSaveSceneInfoPath(string NewDeffaultGameSaveSceneInfoPath)
    {
        base.ChangeDeffaultGameSaveSceneInfoPath(NewDeffaultGameSaveSceneInfoPath);
    }
}
