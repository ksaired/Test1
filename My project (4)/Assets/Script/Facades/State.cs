using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public virtual string KindPath { protected set; get; }
    public virtual string StatePath { protected set; get; }

    public virtual Resource CurrentInfo { protected set; get; }
    
    public abstract Resource StartFacade(Resource CurrentInfo);

    public abstract Resource UpdateFacade(Resource CurrentInfo);

    public abstract void StopState();

    protected string StateKindPath = SceneInfo.GetLinkToAssets("StateKindPath");

    public virtual void ChangeCurrentInfo(Resource newInfo)
    {
        CurrentInfo = newInfo;
    }

    public virtual void ChangeKindPath(string NewKindPath)
    {
        KindPath = NewKindPath;
    }
    public virtual void ChangeStatePath(string NewStatePath)
    {
        StatePath = NewStatePath;
    }
}
