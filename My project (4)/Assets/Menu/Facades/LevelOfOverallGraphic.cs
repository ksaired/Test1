using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelOfOverallGraphic : LevelOfGraphic
{
    public override string SpriteLoadKindPath { get => LevelOfGraphicSpriteLoadKindPath + LevelOfOverallGraphicLoadKindPath; protected set => base.SpriteLoadKindPath = value; }
       
    protected string LevelOfOverallGraphicLoadKindPath = UIInfo.GetLinkToAssets("LevelOfOverallGraphicSpriteKindLoadPath");
}
