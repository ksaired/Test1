using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class TreeLoad : MonoBehaviour
{
  public virtual TheFirstLevelOfLoadTreeFacade CurrentTheFirstLevelOfLoadTree { protected set; get; }
  public virtual TheSecondaryLevelOfLoadTreeFacade CurrentTheSecondaryLevelOfLoadTree { protected set; get; }
  public virtual TheThirdLevelOfLoadTreeFacade CurrentTheThirdLevelOfLoadTree { protected set; get; }

  public virtual void ChangeTheFirstLevelOfLoadTree(TheFirstLevelOfLoadTreeFacade NewTheFirstLevelOfLoadTree)
  {
        CurrentTheFirstLevelOfLoadTree = NewTheFirstLevelOfLoadTree;
  }
  public virtual void ChangeTheSecondaryLevelOfLoadTree(TheSecondaryLevelOfLoadTreeFacade NewTheSecondryLevelOfLoadTree)
  {
     CurrentTheSecondaryLevelOfLoadTree = NewTheSecondryLevelOfLoadTree;
  }
  public virtual void ChangeTheThirdLevelOfLoadTree(TheThirdLevelOfLoadTreeFacade NewTheThirdLevelOfLoadTree)
  {
        CurrentTheThirdLevelOfLoadTree = NewTheThirdLevelOfLoadTree;
  }
  public virtual void StartFacade()
  {
        StartLevelsOfLoadTree();
  }
  
  public virtual void UpdateFacade()
  {
        UpdateLevelsOfLoadTree();
  }
  
  public virtual void ReturnAllLevelOfLoadToBaseState()
  {
        UpdateFacade();

        CurrentTheFirstLevelOfLoadTree.ReturnAllObjectsToBaseState();
        CurrentTheSecondaryLevelOfLoadTree.ReturnAllObjectsToBaseState();
        CurrentTheThirdLevelOfLoadTree.ReturnAllObjectsToBaseState();
  }

  protected virtual void StartLevelsOfLoadTree()
  {
        CurrentTheFirstLevelOfLoadTree.StartFacade();
        CurrentTheSecondaryLevelOfLoadTree.StartFacade();
        CurrentTheThirdLevelOfLoadTree.StartFacade();
        
        UpdateLevelsOfLoadTree();
  }
  protected virtual void UpdateLevelsOfLoadTree()
  {
        UpdateRaycast();

        if (CurrentTheFirstLevelOfLoadTree.CurrentColiders.Length > 0)
        {
            UpdateTheFirstLevelOfLoad();
        }

        if (CurrentTheSecondaryLevelOfLoadTree.CurrentColiders.Length > 0)
        {
             UpdateTheSecondaryLevelOfLoad();
        }

        if (CurrentTheThirdLevelOfLoadTree.CurrentColiders.Length > 0)
        {
            UpdateTheThirdLevelOfLoad();
        }
        
  }
  
  protected virtual void UpdateTheFirstLevelOfLoad()
  {
     CheckTheFirstLevelOfLoadColider();
     CurrentTheFirstLevelOfLoadTree.TreatmentOfLoadObjects();
  }
  protected virtual void UpdateTheSecondaryLevelOfLoad()
  {
      CheckTheSecondaryLevelOfLoadColider();
      CurrentTheSecondaryLevelOfLoadTree.TreatmentOfLoadObjects();
  }
  protected virtual void UpdateTheThirdLevelOfLoad()
  {
       CheckTheThirdLevelOfLoadColider();
       CurrentTheThirdLevelOfLoadTree.TreatmentOfLoadObjects();
  }

  protected virtual void CheckTheFirstLevelOfLoadColider()
  {
        foreach (var i in CurrentTheFirstLevelOfLoadTree.CurrentColiders)
        {
            
            if (i.transform.gameObject.GetComponent<ObjectFacade>())
            {
                Debug.Log("TLoadTree2");
                CurrentTheFirstLevelOfLoadTree.AddToLoadObjects(i.transform.gameObject.GetComponent<ObjectFacade>());

               if(CurrentTheSecondaryLevelOfLoadTree.TheLoadObjects.Contains(i.transform.gameObject.GetComponent<ObjectFacade>()))
               {
                    CurrentTheSecondaryLevelOfLoadTree.RemoveFromLoadObject(i.transform.gameObject.GetComponent<ObjectFacade>());
               }
               else if (CurrentTheThirdLevelOfLoadTree.TheLoadObjects.Contains(i.transform.gameObject.GetComponent<ObjectFacade>()))
               {
                    CurrentTheThirdLevelOfLoadTree.RemoveFromLoadObject(i.transform.gameObject.GetComponent<ObjectFacade>());
               }
            }
        }
    }
  protected virtual void CheckTheSecondaryLevelOfLoadColider()
  {
        foreach (var i in CurrentTheSecondaryLevelOfLoadTree.CurrentColiders)
        {
           
            if (i.transform.gameObject.GetComponent<ObjectFacade>() && !CurrentTheFirstLevelOfLoadTree.CurrentColiders.Contains(i))
            {
                Debug.Log("TLoadTree2");
                CurrentTheSecondaryLevelOfLoadTree.AddToLoadObjects(i.transform.gameObject.GetComponent<ObjectFacade>());

                if (CurrentTheThirdLevelOfLoadTree.TheLoadObjects.Contains(i.transform.gameObject.GetComponent<ObjectFacade>()))
                {
                    CurrentTheThirdLevelOfLoadTree.RemoveFromLoadObject(i.transform.gameObject.GetComponent<ObjectFacade>());
                }
                                                 
            }
        }
  }
  protected virtual void CheckTheThirdLevelOfLoadColider()
  {
        
        foreach (var i in CurrentTheThirdLevelOfLoadTree.CurrentColiders)
        {
            
            if (i.transform.gameObject.GetComponent<ObjectFacade>() && !CurrentTheSecondaryLevelOfLoadTree.CurrentColiders.Contains(i) && !CurrentTheFirstLevelOfLoadTree.CurrentColiders.Contains(i))
            {
                Debug.Log("TLoadTree2");
                CurrentTheThirdLevelOfLoadTree.AddToLoadObjects(i.transform.gameObject.GetComponent<ObjectFacade>());

                if (CurrentTheSecondaryLevelOfLoadTree.TheLoadObjects.Contains(i.transform.gameObject.GetComponent<ObjectFacade>()))
                {
                    CurrentTheSecondaryLevelOfLoadTree.RemoveFromLoadObject(i.transform.gameObject.GetComponent<ObjectFacade>());
                }
                
            }
        }
  }
  protected virtual void UpdateRaycast()
  {
       CurrentTheFirstLevelOfLoadTree.ChangeCurrentColliders( Physics2D.OverlapCircleAll(CurrentTheFirstLevelOfLoadTree.TrackObject.gameObject.transform.position,CurrentTheFirstLevelOfLoadTree.RadiusOfCircle));
       CurrentTheSecondaryLevelOfLoadTree.ChangeCurrentColliders(Physics2D.OverlapCircleAll(CurrentTheSecondaryLevelOfLoadTree.TrackObject.gameObject.transform.position, CurrentTheSecondaryLevelOfLoadTree.RadiusOfCircle));
       CurrentTheThirdLevelOfLoadTree.ChangeCurrentColliders(Physics2D.OverlapCircleAll(CurrentTheThirdLevelOfLoadTree.TrackObject.gameObject.transform.position, CurrentTheThirdLevelOfLoadTree.RadiusOfCircle));
  }
}
