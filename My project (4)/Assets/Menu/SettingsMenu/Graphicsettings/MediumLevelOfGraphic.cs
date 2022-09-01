using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediumLevelOfGraphic : LevelOfGraphic
{
    public override Sprite DefaultSprite => base.DefaultSprite;
    public override string SpriteLink { protected set => DeffaultSpriteLink = value; get => DeffaultSpriteLink;  }
    public override string LevelOf { get => base.DeffaultTypeLevelOfGraphic[1]; }
    public override string SpriteLoadKindPath { get => LevelOfGraphicSpriteLoadKindPath + LevelOfMediumGraphicLoadKindPath; protected set => base.SpriteLoadKindPath = value; }

    protected string LevelOfMediumGraphicLoadKindPath = UIInfo.GetLinkToAssets("LevelOfMediumGraphicSpriteLoadKindPath");

    private string DeffaultSpriteLink = "/Image7";
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
        base.LoadSprite(link);
    }

    public override void StartFacade()
    {
       
    }
}
