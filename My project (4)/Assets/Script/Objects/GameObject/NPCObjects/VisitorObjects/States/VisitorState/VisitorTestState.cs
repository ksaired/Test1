using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorTestState : VisitorState
{
    public VisitorTestResource CurrentVisitorTestInfo;

    private string VisitorTestStatePath = "VisitorTestState";

    public override VisitorResource CurrentVisitorInfo { get => CurrentVisitorTestInfo; set => CurrentVisitorTestInfo = (VisitorTestResource)value; }

    public override string StatePath { get => VisitorTestStatePath; protected set => VisitorTestStatePath = value; }

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
            CurrentVisitorTestInfo.SaveVisitorTestInfo.Testint = 10;
        }

        return this.CurrentInfo;
    }
    public override void StopState()
    {
        Debug.Log("stopstate");
    }
}
