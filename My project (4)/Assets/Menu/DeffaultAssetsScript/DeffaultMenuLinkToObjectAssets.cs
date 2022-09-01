using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeffaultMenuLinkToObjectAssets 
{
    public Dictionary<string, string> LinksToAssets = new Dictionary<string, string>()
    {
        //LoadPathToKindAssetsPath
        {"LoadMenuLoadPathToKindAssetsPath","Prefabs" },
        {"ChooseMenuLoadPathToKindAssetsPath","/ChooseMenu" },
        {"MenuPrefabsLoadPathToKindAssetsPath","/MenuPrefabs" },
        
        //SpriteLoadPath
        {"SpriteFacadeLoadPath","ResourceAssets/MenuAssets/Sprites" },
        {"LevelOfGraphicSpriteLoadKindPath","ResourceAssets/MenuAssets/Sprites" },
        {"LevelOfMinimalGraphicSpriteLoadKindPath","/MinimalLevelOfGraphic" },
        {"LevelOfMediumGraphicSpriteLoadKindPath","/MediumLevelOfGraphic" },
        {"LevelOfHighGraphicSpriteKindLoadPath","/HighLevelOfGraphic" },
        {"LevelOfOverallGraphicSpriteKindLoadPath","/LevelOfOverallGraphic" },
        {"LevelOfOverallYourselfullGraphicSpriteLoadKindPath","/YourselfullLevelOfGraphic" },
        {"LevelOfMinimalOverallGraphicSpriteKindLoadPath","/MinimalLevelOfGraphic"},
        {"LevelOfMediumOverallGraphicSpriteKindLoadPath","/MediumLevelOfGraphic" },
        {"LevelOfHighOverallGraphicSpriteKindLoadPath","/HighLevelOfGraphic" },
        {"InputButtonValueFacadeSpriteKindPath","ResourceAssets/MenuAssets/Sprites/ButtonOutInputButtonMenuSprite" }
    };
}
