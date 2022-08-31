using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTestState : SpiderEnemyState
{
    public SpiderTestResource CurrentSpiderTestInfo;

    private string SpiderTestStatePath = "SpiderTestState";

    public override SpiderResource CurrentSpiderInfo { get => CurrentSpiderTestInfo; set => CurrentSpiderTestInfo = (SpiderTestResource)value; }

    public override string StatePath { get => SpiderTestStatePath; protected set => SpiderTestStatePath = value; }

    public override void ChangeCurrentInfo(Resource newInfo)
    {
        base.ChangeCurrentInfo(newInfo);
    }
    public override void ChangeStatePath(string NewStatePath)
    {
        base.ChangeStatePath(NewStatePath);
    }
    public override Resource StartFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;
        return this.CurrentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;

        if (Input.GetKeyDown(KeyCode.A))
        {
            CurrentSpiderTestInfo.SaveSpiderTestInfo.Testint = 12;
          
        }

        return this.CurrentInfo;
    }
    public override void StopState()
    {
        Debug.Log("stopstate");
    }
}
