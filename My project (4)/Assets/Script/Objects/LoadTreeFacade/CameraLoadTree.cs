using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLoadTree : CameraTreeLoadFacade
{
    public override TheFirstLevelOfLoadTreeFacade CurrentTheFirstLevelOfLoadTree { get => base.CurrentTheFirstLevelOfLoadTree; protected set => base.CurrentTheFirstLevelOfLoadTree = value; }
    public override TheSecondaryLevelOfLoadTreeFacade CurrentTheSecondaryLevelOfLoadTree { get => base.CurrentTheSecondaryLevelOfLoadTree; protected set => base.CurrentTheSecondaryLevelOfLoadTree = value; }
    public override TheThirdLevelOfLoadTreeFacade CurrentTheThirdLevelOfLoadTree { get => base.CurrentTheThirdLevelOfLoadTree; protected set => base.CurrentTheThirdLevelOfLoadTree = value; }

    public override void ChangeTheFirstLevelOfLoadTree(TheFirstLevelOfLoadTreeFacade NewTheFirstLevelOfLoadTree)
    {
        base.ChangeTheFirstLevelOfLoadTree(NewTheFirstLevelOfLoadTree);
    }
    public override void ChangeTheSecondaryLevelOfLoadTree(TheSecondaryLevelOfLoadTreeFacade NewTheSecondryLevelOfLoadTree)
    {
        base.ChangeTheSecondaryLevelOfLoadTree(NewTheSecondryLevelOfLoadTree);
    }
    public override void ChangeTheThirdLevelOfLoadTree(TheThirdLevelOfLoadTreeFacade NewTheThirdLevelOfLoadTree)
    {
        base.ChangeTheThirdLevelOfLoadTree(NewTheThirdLevelOfLoadTree);
    }

    public override void StartFacade()
    {
        base.StartFacade();
    }
    public override void UpdateFacade()
    {
        base.UpdateFacade();
    }
    public override void ReturnAllLevelOfLoadToBaseState()
    {
        base.ReturnAllLevelOfLoadToBaseState();
    }

    protected override void StartLevelsOfLoadTree()
    {
        base.StartLevelsOfLoadTree();
    }
    protected override void UpdateLevelsOfLoadTree()
    {
        base.UpdateLevelsOfLoadTree();
    }

    protected override void CheckTheFirstLevelOfLoadColider()
    {
        base.CheckTheFirstLevelOfLoadColider();
    }
    protected override void CheckTheSecondaryLevelOfLoadColider()
    {
        base.CheckTheSecondaryLevelOfLoadColider();
    }
    protected override void CheckTheThirdLevelOfLoadColider()
    {
        base.CheckTheThirdLevelOfLoadColider();
    }

    protected override void UpdateTheFirstLevelOfLoad()
    {
        base.UpdateTheFirstLevelOfLoad();
    }
    protected override void UpdateTheSecondaryLevelOfLoad()
    {
        base.UpdateTheSecondaryLevelOfLoad();
    }
    protected override void UpdateTheThirdLevelOfLoad()
    {
        base.UpdateTheThirdLevelOfLoad();
    }

    protected override void UpdateRaycast()
    {
        base.UpdateRaycast();
    }
}
