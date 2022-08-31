using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TheThirdLevelOfLoadTreeFacade : LevelOfLoadTreeFacade
{
    protected float DeffaultRadiusOfCircle = 30;
        
    public TheThirdLevelOfLoadTreeFacade(GameObject NewTrackObject) : base(NewTrackObject)
    {
        TrackObject = NewTrackObject.gameObject;
    }
}
