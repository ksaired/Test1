using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFirstLevelOfCameraLoadFacade : TheFirstLevelOfLoadTreeFacade
{
    public override List<ObjectFacade> TheLoadObjects { get => base.TheLoadObjects; protected set => base.TheLoadObjects = value; }
    public override Collider2D[] CurrentColiders { get => base.CurrentColiders; protected set => base.CurrentColiders = value; }

    public override GameObject TrackObject { get => base.TrackObject; protected set => base.TrackObject = value; }

    public override float RadiusOfCircle { get => DeffaultRadiusOfCircle; protected set => DeffaultRadiusOfCircle = value; }

    public TheFirstLevelOfCameraLoadFacade(GameObject NewTrackObject):base(NewTrackObject)
    {
        TrackObject = NewTrackObject.gameObject;
    }
    public override void AddToLoadObjects(ObjectFacade NewObject)
    {
        base.AddToLoadObjects(NewObject);
    }
    public override void RemoveFromLoadObject(ObjectFacade RemoveObject)
    {
        base.RemoveFromLoadObject(RemoveObject);
    }
    public override void ChangeCurrentColliders(Collider2D[] NewColiders)
    {
        base.ChangeCurrentColliders(NewColiders);
    }
    public override void ChangeTrackObject(GameObject NewTrackObject)
    {
        base.ChangeTrackObject(NewTrackObject);
    }
    public override void ChangeRadius(float NewRadiusOfCircle)
    {
        base.ChangeRadius(NewRadiusOfCircle);
    }

    public override void StartFacade()
    {
        base.StartFacade();
    }
    public override void TreatmentOfLoadObjects()
    {
        foreach (var i in TheLoadObjects)
        {
            TreatmentLoadObject(i);
        }
    }
    public override void TreatmentLoadObject(ObjectFacade TreatmentObject)
    {
        if (TreatmentObject.CurrentInfo.TestLoadTree != 12345)
        {
            TreatmentObject.CurrentInfo.ChangeTestLoadTree(12345);
        }
    }
    public override void ReturnAllObjectsToBaseState()
    {
        base.ReturnAllObjectsToBaseState();
    }

    protected override void ReturnBaseStateToObject(ObjectFacade CurrentReturnObject)
    {
        CurrentReturnObject.CurrentInfo.ChangeTestLoadTree(0);
    }
}
