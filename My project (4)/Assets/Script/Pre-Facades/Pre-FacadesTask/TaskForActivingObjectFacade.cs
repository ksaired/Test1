using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class TaskForActivingObjectFacade : TaskFacade
{
    public override string TaskPrefabsLoadKindPath { get => TaskFacadePrefabsLoadKindPath + TaskForActivingObjectFacadePrefabsLoadKindPath; protected set => base.TaskPrefabsLoadKindPath = value; }

    protected string TaskForActivingObjectFacadePrefabsLoadKindPath = SceneInfo.GetLinkToAssets("TaskForActivingObjectFacadePrefabsLoadKindPath");
}
