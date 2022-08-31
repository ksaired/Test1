using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Facade : MonoBehaviour
{
    public virtual string ObjectPath { protected set; get; }
        
    public abstract void Load();
    public abstract void Save();
        

    public virtual void ChangeObjectPath(string NewObjectPath)
    {
        ObjectPath = NewObjectPath;
    }
}
