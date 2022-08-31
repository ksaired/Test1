using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CameraTreeLoadFacade : TreeLoad
{
    public override TheFirstLevelOfLoadTreeFacade CurrentTheFirstLevelOfLoadTree { get => TheFirstCameraLevelOfLoadTree; protected set => TheFirstCameraLevelOfLoadTree = (TheFirstLevelOfCameraLoadFacade)value; }
    public override TheSecondaryLevelOfLoadTreeFacade CurrentTheSecondaryLevelOfLoadTree { get => TheSecondaryCameraLevelOfLoadTree; protected set => TheSecondaryCameraLevelOfLoadTree = (TheSecondaryLevelOfCameraLoadFacade)value; }
    public override TheThirdLevelOfLoadTreeFacade CurrentTheThirdLevelOfLoadTree { get => TheThirdCameraLevelOfLoadTree; protected set => TheThirdCameraLevelOfLoadTree = (TheThirdLevelOfLoadCameraTreeFacade)value; }

    protected TheFirstLevelOfCameraLoadFacade TheFirstCameraLevelOfLoadTree;
    protected TheSecondaryLevelOfCameraLoadFacade TheSecondaryCameraLevelOfLoadTree;
    protected TheThirdLevelOfLoadCameraTreeFacade TheThirdCameraLevelOfLoadTree;
    public override void StartFacade()
    {
        TheFirstCameraLevelOfLoadTree = new TheFirstLevelOfCameraLoadFacade(gameObject);
        TheSecondaryCameraLevelOfLoadTree = new TheSecondaryLevelOfCameraLoadFacade(gameObject);
        TheThirdCameraLevelOfLoadTree = new TheThirdLevelOfLoadCameraTreeFacade(gameObject);
       
        base.StartFacade();
    }
   
}
