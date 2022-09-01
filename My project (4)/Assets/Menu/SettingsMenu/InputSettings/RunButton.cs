using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunButton : InputButtonValueFacade
{
    public override string ButtonKey { get => DeffaultButtonKey; protected set => DeffaultButtonKey = value; }
    public override string SpriteLink { get => DeffaultSpriteLink; protected set => DeffaultSpriteLink = value; }
    public override KeyCode ButtonValue { get => DeffaultKeyKode; protected set => DeffaultKeyKode = value; }
    public override Sprite DefaultSprite => base.DefaultSprite;
    
    private KeyCode DeffaultKeyKode = KeyCode.LeftShift;
    private string DeffaultButtonKey = "RunButton";
    private string DeffaultSpriteLink = "/Image7";

    public override void ChangeOfButtonKey(string newbuttonkey)
    {
        base.ChangeOfButtonKey(newbuttonkey);
    }

    public override void ChangeOfButtonValue(KeyCode newButtonValue)
    {
        base.ChangeOfButtonValue(newButtonValue);
    }

    public override void ChangeSpriteLink(string newspriteLink)
    {
        base.ChangeSpriteLink(newspriteLink);
    }

    public override void ChangeDeffaultSprite(Sprite newDeffaultSprite)
    {
        base.ChangeDeffaultSprite(newDeffaultSprite);
    }

    public override void LoadSrite(string SpriteLink)
    {
        base.LoadSrite(SpriteLink);
    }
    public override void StartFacade()
    {
        base.StartFacade();
    }
}
