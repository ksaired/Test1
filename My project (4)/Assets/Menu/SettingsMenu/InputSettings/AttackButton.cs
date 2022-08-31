using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : InputButtonValueFacade
{
    public override string ButtonKey => "Attack1Button";
    public override string SpriteLink => "Image7";
    public override KeyCode ButtonValue  { get => base.ButtonValue = DeffaultKeyKode; protected set => base.ButtonValue = DeffaultKeyKode; }
    public override Sprite DefaultSprite => base.DefaultSprite;

    private KeyCode DeffaultKeyKode = KeyCode.Mouse0;
    public override void ChangeOfButtonKey(string newbuttonkey)
    {
        ButtonKey = newbuttonkey;
    }

    public override void ChangeOfButtonValue(KeyCode newButtonValue)
    {
        DeffaultKeyKode = newButtonValue;
    }

    public override void ChangeSpriteLink(string newspriteLink)
    {
        SpriteLink = newspriteLink;
    }

    public override void ChangeDeffaultSprite(Sprite newDeffaultSprite)
    {
        DefaultSprite = newDeffaultSprite;
    }

    public override void LoadSrite(string SpriteLink)
    {
        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + SpriteLink);
    }
    public override void StartFacade()
    {
        DefaultSprite = gameObject.GetComponent<Image>().sprite;
        if (transform.gameObject.GetComponentInChildren<Text>()) transform.gameObject.GetComponentInChildren<Text>().text = ButtonValue.ToString();
    }
}
