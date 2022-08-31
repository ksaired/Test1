using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class LevelOfLoadTreeFacade : MonoBehaviour
{
    public virtual List<ObjectFacade> TheLoadObjects { protected set; get; }
    public virtual Collider2D[] CurrentColiders { protected set; get; }
        
    public virtual GameObject TrackObject { protected set; get; }
    public virtual float RadiusOfCircle { protected set; get; }
    
    public LevelOfLoadTreeFacade(GameObject NewTrackObject)
    {
        TrackObject = NewTrackObject.gameObject;
        Debug.Log(TrackObject.transform.position);
    }
    public virtual void AddToLoadObjects(ObjectFacade NewObject)
    {
        if (!TheLoadObjects.Contains(NewObject))
        {
            TheLoadObjects.Add(NewObject);
        }
    }
    public virtual void RemoveFromLoadObject(ObjectFacade RemoveObject)
    {
        if (TheLoadObjects.Contains(RemoveObject))
        {
            TheLoadObjects.Remove(RemoveObject);
            ReturnBaseStateToObject(RemoveObject);
        }
    }
    public virtual void ChangeTrackObject(GameObject NewTrackObject)
    {
        TrackObject = NewTrackObject;
    }
    public virtual void ChangeCurrentColliders(Collider2D[] NewColiders)
    {
        CurrentColiders = NewColiders;
    }
    public virtual void ChangeRadius(float NewRadiusOfCircle)
    {
        RadiusOfCircle = NewRadiusOfCircle;
    }

    public virtual void StartFacade()
    {
        CurrentColiders = new  Collider2D[0];
        TheLoadObjects = new List<ObjectFacade>();
    }
   
    public virtual void ReturnAllObjectsToBaseState()
    {
        if (TheLoadObjects.Count > 0)
        {
            foreach (var i in TheLoadObjects)
            {
                ReturnBaseStateToObject(i);
            }

            TheLoadObjects.RemoveAll(i => i);
        }
    }

    protected abstract void ReturnBaseStateToObject(ObjectFacade CurrentReturnObject);
   
    public abstract void TreatmentOfLoadObjects();

    public abstract void TreatmentLoadObject(ObjectFacade TreatmentObject);
}
