using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TheSecondaryLevelOfLoadTreeFacade : LevelOfLoadTreeFacade
{
    protected float DeffaultRadiusOfCircle = 20;

    public TheSecondaryLevelOfLoadTreeFacade(GameObject NewTrackObject) : base(NewTrackObject)
    {
        TrackObject = NewTrackObject.gameObject;
    }
}
