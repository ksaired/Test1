using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteInfo : SpriteFacade
{
    public override string PathToSprite { get => base.PathToSprite; protected set => base.PathToSprite = value; }
    public override string SpriteFacadePath { protected set => DeffaultSpriteFacadePath = value; get => DeffaultSpriteFacadePath; }

    [SerializeField]
    private string DeffaultSpriteFacadePath = "Sprite1";

    public override void ChangePathToassets(string newPathToSprite)
    {
        base.ChangePathToassets(newPathToSprite);
    }
    public override void ChangeSpriteFacadePath(string NewSpriteFacadePath)
    {
        base.ChangeSpriteFacadePath(NewSpriteFacadePath);
    }
    public override void LoadSprite()
    {
        base.LoadSprite();
    }
}
