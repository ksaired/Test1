using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public abstract class InputButtonValueFacade : MonoBehaviour
{

   public virtual KeyCode ButtonValue { protected set; get; }
   public virtual string ButtonKey { protected set; get; }
   public virtual string SpriteLink { protected set; get; }
   public virtual Sprite DefaultSprite { protected set; get; }

   public abstract void ChangeOfButtonValue(KeyCode newButtonValue);
   public abstract void ChangeOfButtonKey(string newbuttonkey);
   public abstract void ChangeSpriteLink(string newspriteLink);
   public abstract void LoadSrite(string SpriteLink);
   public abstract void ChangeDeffaultSprite(Sprite newDeffaultSprite);
   public abstract void StartFacade();
}
