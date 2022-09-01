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

   protected string InputButtonValueFacadeSpriteKindPath = UIInfo.GetLinkToAssets("InputButtonValueFacadeSpriteKindPath");
   public virtual void ChangeOfButtonKey(string newbuttonkey)
   {
       ButtonKey = newbuttonkey;
   }

   public virtual void ChangeOfButtonValue(KeyCode newButtonValue)
   {
       ButtonValue = newButtonValue;
   }

   public virtual void ChangeSpriteLink(string newspriteLink)
   {
       SpriteLink = newspriteLink;
   }
   public virtual void LoadSrite(string SpriteLink)
   {
       gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(InputButtonValueFacadeSpriteKindPath + SpriteLink);
   }
   public virtual void ChangeDeffaultSprite(Sprite newDeffaultSprite)
   {
        DefaultSprite = newDeffaultSprite;
   }

   public virtual void StartFacade()
   {
      DefaultSprite = gameObject.GetComponent<Image>().sprite;
      if (transform.gameObject.GetComponentInChildren<Text>()) transform.gameObject.GetComponentInChildren<Text>().text = ButtonValue.ToString();
   }
}
