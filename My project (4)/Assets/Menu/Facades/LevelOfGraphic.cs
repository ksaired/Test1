using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public abstract class LevelOfGraphic : LevelOfFacade
{
   
    public virtual string SpriteLink { protected set; get; }
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

    public abstract void ChangeSpriteLink(string newSpriteLink);
    public abstract void ChangeDefaultSprite(Sprite newSprite);
    public abstract void LoadSprite(string link);
   
   
}
