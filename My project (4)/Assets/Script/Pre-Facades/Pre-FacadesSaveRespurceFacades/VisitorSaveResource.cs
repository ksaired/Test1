using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorSaveResource : NPCSaveResource
{
    public override Dictionary<string, List<string>> CurrentLinkToStates { get => DeffaultCurrentLinkToStates; set => DeffaultCurrentLinkToStates = value; }

    public Dictionary<string, List<string>> DeffaultCurrentLinkToStates = new Dictionary<string, List<string>>();
}
