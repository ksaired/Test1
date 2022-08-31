﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardDifficult : LevelOfDificult
{
    public override string LevelOf => base.LevelOf;
    public override void ChangeLevelOfGraphic(string newLevelOf)
    {
        LevelOf = newLevelOf;
    }

    public override void StartFacade()
    {
        LevelOf = "Hard";

    }
}
