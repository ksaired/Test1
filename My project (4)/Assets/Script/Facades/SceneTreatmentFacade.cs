using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTreatmentFacade : MonoBehaviour
{
    public virtual string GameSaveSceneInfoPath { protected set; get; }
    public virtual string DeffaultGameSaveSceneInfoPath { protected set; get; }

    public virtual GameSaveSceneInfo CurrentGameSaveInfo{protected set; get;}

    protected  SaveAndLoad LoadScript = new SaveAndLoad();

    public virtual void Start()
    {
        GameSaveSceneInfoPath = Application.persistentDataPath + DeffaultGameSaveSceneInfoPath;

        CurrentGameSaveInfo = LoadScript.Load(CurrentGameSaveInfo,GameSaveSceneInfoPath);

        SceneInfo.LoadInfo(CurrentGameSaveInfo);

        SceneInfo.ChangeGameSaveScenePath(DeffaultGameSaveSceneInfoPath);

        SceneInfo.StartScene();
    }

    public virtual void ChangeGameSaveSceneInfoPath(string NewGameSaveSceneInfoPath)
    {
        GameSaveSceneInfoPath = NewGameSaveSceneInfoPath;
    }
    public virtual void ChangeDeffaultGameSaveSceneInfoPath(string NewDeffaultGameSaveSceneInfoPath)
    {
        DeffaultGameSaveSceneInfoPath = NewDeffaultGameSaveSceneInfoPath;
    }
}
