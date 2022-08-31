using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FindOfUI 
{
  public List<Facade> FindActiveFacade()
  {
     List<Facade> ActiveFacade = new List<Facade>();

     foreach (var i in Object.FindObjectsOfType<Facade>())
     {
        if (i.isActiveAndEnabled)
        {
           ActiveFacade.Add(i);
            Debug.Log("15");
        }
     }

     return ActiveFacade;
  }
  public List<ActiveFacade> FindActivingFacades()
  {
     List<ActiveFacade> ActivingFacade = new List<ActiveFacade>();

     foreach (var i in Object.FindObjectsOfType<ActiveFacade>())
     {
       if (i.isActiveAndEnabled)
       {
         ActivingFacade.Add(i);
         Debug.Log("15");
       }
     }

     return ActivingFacade;
  }
  public List<LoadMenuFacade> FindActiveLoadMenuFacade()
  {
     List<LoadMenuFacade> AllLoadMenuFacade = new List<LoadMenuFacade>();

     foreach (var i in Object.FindObjectsOfType<LoadMenuFacade>())
     {
         if (i.isActiveAndEnabled)
         {
            AllLoadMenuFacade.Add(i);
            Debug.Log(11);
         }
     }

     return AllLoadMenuFacade;
  }
  public List<SettingsFacade> FindActiveSettingsFacade()
  {
     List<SettingsFacade> AllSettingsFacade = new List<SettingsFacade>();

     foreach (var i in Object.FindObjectsOfType<SettingsFacade>())
     {
        if (i.isActiveAndEnabled)
            {
                AllSettingsFacade.Add(i);
                Debug.Log(11);
        }
     }

     return AllSettingsFacade;
  } 
  
  public List<Button> FindActiveButton()
  {
     List<Button> ActiveUI = new List<Button>();   

     foreach (var i in Object.FindObjectsOfType<Button>())
     {
            if (i.IsActive()) ActiveUI.Add(i);
            Debug.Log(5);
     }

     return ActiveUI;
  }

  public List<Image> FindActiveImages()
  {
     List<Image> AllImages = new List<Image>();

     foreach (var ImageToFacade in Object.FindObjectsOfType<Image>())
     {
        if (ImageToFacade.isActiveAndEnabled)
        {
          AllImages.Add(ImageToFacade);
          Debug.Log(6);
        }
     }

     return AllImages;
  }

  public List<UiFacade> FindActiveUIFacade()
  {
     List<UiFacade> ActiveFacade = new List<UiFacade>();

     foreach (UiFacade i in Object.FindObjectsOfType<UiFacade>())
     {

        if (i.isActiveAndEnabled)
        {
          ActiveFacade.Add(i.GetComponent<UiFacade>());
          Debug.Log(7);
        }
     }

     return ActiveFacade;
  }

  public List<SpriteFacade> FindActiveSpriteFacade()
  {       
     List<SpriteFacade> ActiveFacade = new List<SpriteFacade>();

      foreach ( var i in Object.FindObjectsOfType<SpriteFacade>())
      {
        ActiveFacade.Add(i);
      }

      return ActiveFacade;
  }
  public List<ActiveFacade> FindAllActivingFacades()
  {
     List<ActiveFacade> AllActivingFacade = new List<ActiveFacade>();

     foreach (var i in Object.FindObjectsOfType<ActiveFacade>())
     {
         AllActivingFacade.Add(i);
     }

     return AllActivingFacade;
  }
  public List<Button> FindAllButton()
  {
     List<Button> AllButton = new List<Button>();

     foreach (Button i in Object.FindObjectsOfType<Button>())
     {
        Debug.Log("66");
        AllButton.Add(i);
     }

     return AllButton;
  }
  
  public List<SettingsFacade> FindAllSettingsFacade()
  {
      List<SettingsFacade> AllSettingsFacade = new List<SettingsFacade>();

      foreach (var i in Object.FindObjectsOfType<SettingsFacade>())
      {
          AllSettingsFacade.Add(i);
      }

      return AllSettingsFacade;
  }

  public List<Facade> FindAllFacade()
  {
     List<Facade> AllFacade = new List<Facade>();

     foreach (var i in Object.FindObjectsOfType<Facade>())
     {
        AllFacade.Add(i);
        Debug.Log("15");
     }

     return AllFacade;
  }
  public List<UiFacade> FindAllUIFacade()
  {
     List<UiFacade> AllFacade = new List<UiFacade>();
     foreach (UiFacade i in Object.FindObjectsOfType<UiFacade>())
     {
        if (i.isActiveAndEnabled)
        {
          AllFacade.Add(i.GetComponent<UiFacade>());
          Debug.Log(7);
        }
     }

     return AllFacade;
  }
  public List<Image> FindAllImage()
  {
     List<Image> AllImage = new List<Image>();

     foreach (Image i in Object.FindObjectsOfType<Image>())
     {
        AllImage.Add(i);
     }

     return AllImage;
  }

  public List<SpriteFacade> FindAllSpriteFacade()
  {
     List<SpriteFacade> AllSpriteFacade = new List<SpriteFacade>();

     foreach (var i in Object.FindObjectsOfType<SpriteFacade>())
     {
        AllSpriteFacade.Add(i);
     }

     return AllSpriteFacade;
  }
  

  public List<LoadMenuFacade> FindAllLoadMenuFacade()
  {
     List<LoadMenuFacade> AllLoadMenuFacade = new List<LoadMenuFacade>();

     foreach (var i in Object.FindObjectsOfType<LoadMenuFacade>())
     {
        AllLoadMenuFacade.Add(i);
     }

     return AllLoadMenuFacade;
  }

  public List<TextFacade> FindAllText()
  {
     List<TextFacade> AllTextFacade = new List<TextFacade>();

     foreach (var i in Object.FindObjectsOfType<TextFacade>())
     {
         AllTextFacade.Add(i);
     }

     return AllTextFacade;
  }
  public List<Canvas> FindAllCanvas()
  { 
      List<Canvas> AllCanvas = new List<Canvas>();

      foreach (var i in Object.FindObjectsOfType<Canvas>())
      {
           AllCanvas.Add(i);
      }

      return AllCanvas ;
  }
  
   
}
