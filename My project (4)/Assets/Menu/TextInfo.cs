using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInfo : TextFacade
{
    public override string TextPath => DeffaultTextPath;
    [SerializeField]
    private string DeffaultTextPath;
    public override void ChangeTextPath(string newTextPath)
    {
        DeffaultTextPath = newTextPath;
    }

    public override void LoadText(string newValue)
    {
        base.LoadText(newValue);
    }
}
