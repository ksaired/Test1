using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelOfFacade : MonoBehaviour
{
    public virtual string LevelOf { protected set; get; }

    public abstract void StartFacade();
    public abstract void ChangeLevelOfGraphic(string newLevelOfGraphic);
}
