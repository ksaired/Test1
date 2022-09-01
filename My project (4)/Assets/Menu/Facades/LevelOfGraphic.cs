using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public abstract class LevelOfGraphic : LevelOfFacade
{
   
    public virtual string SpriteLink { protected set; get; }

    public virtual string SpriteLoadKindPath { protected set; get; }
       
    public virtual Sprite DefaultSprite { protected set; get;}
    public  virtual  List<string> DeffaultTypeLevelOfGraphic 
      {protected set => DeffaultTypeLevelOfGraphic = value ; get => new List<string>() 
      {
        {"MinimalLevelOfGraphic"},
        { "MediumLevelOfGraphic"},
        {"HighLevelOfGraphic"},
        {"YourselfullLevelOfGraphic" }
      }; 
    }

    protected string LevelOfGraphicSpriteLoadKindPath = UIInfo.GetLinkToAssets("LevelOfGraphicSpriteLoadKindPath");

    public abstract void ChangeSpriteLink(string newSpriteLink);
    public abstract void ChangeDefaultSprite(Sprite newSprite);
    public virtual void LoadSprite(string link)
    {
        DefaultSprite = gameObject.GetComponent<Image>().sprite;
        
        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(SpriteLoadKindPath + link);
    }
   
   
}
