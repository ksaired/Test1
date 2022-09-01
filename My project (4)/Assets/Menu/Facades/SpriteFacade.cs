using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public abstract class SpriteFacade : MonoBehaviour
{
    public virtual string PathToSprite { protected set; get;}
    public virtual string SpriteFacadePath { protected set; get; }
        
    protected string SpriteFacadeLoadKindPath = UIInfo.GetLinkToAssets("SpriteFacadeLoadPath");

    public virtual void LoadSprite()
    {
        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(SpriteFacadeLoadKindPath + PathToSprite);
    }
    public virtual void ChangePathToassets(string newPathToSprite)
    {
        PathToSprite = newPathToSprite;
    }
    public virtual void ChangeSpriteFacadePath(string NewSpriteFacadePath)
    {
        SpriteFacadePath = NewSpriteFacadePath;
    }
      
}
