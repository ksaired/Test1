using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimalLevelOfGraphic1 : LevelOfOverallGraphic
{
    public override Sprite DefaultSprite => base.DefaultSprite;
    public override string SpriteLink { protected set => DeffaultSpriteLink = value; get => DeffaultSpriteLink; }
    public override string LevelOf { get => base.DeffaultTypeLevelOfGraphic[0]; }

    private string DeffaultSpriteLink = "Image7";
    public override void ChangeDefaultSprite(Sprite newSprite)
    {
        DefaultSprite = newSprite;
    }

    public override void ChangeLevelOfGraphic(string newLevelOfGraphic)
    {
        LevelOf = newLevelOfGraphic;
    }

    public override void ChangeSpriteLink(string newSpriteLink)
    {
        SpriteLink = newSpriteLink;
    }

    public override void LoadSprite(string link)
    {
        DefaultSprite = gameObject.GetComponent<Image>().sprite;
        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + link);

    }

    public override void StartFacade()
    {
       
    }
}
