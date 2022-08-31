using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitFromMenuButton : UiFacade
{
    public void Exit()
    {
        Destroy(transform.parent.gameObject);
        
        UIInfo.ActivingAnotherButton();
    }
}
