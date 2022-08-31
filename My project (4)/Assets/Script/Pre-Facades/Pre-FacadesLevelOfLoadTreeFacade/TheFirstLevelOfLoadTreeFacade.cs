using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TheFirstLevelOfLoadTreeFacade : LevelOfLoadTreeFacade
{
    protected float DeffaultRadiusOfCircle = 10;

    public TheFirstLevelOfLoadTreeFacade(GameObject NewTrackObject) : base(NewTrackObject)
    {
        TrackObject = NewTrackObject.gameObject;
    }
}
