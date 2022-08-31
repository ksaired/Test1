using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public abstract class TextFacade : MonoBehaviour
{
   public virtual string TextPath { protected set; get; }


   public virtual void LoadText(string newText)
   {
        gameObject.GetComponent<Text>().text = newText;
   }

   public virtual void ChangeTextPath(string NewTextPath)
   {
       TextPath = NewTextPath;
   }
}
