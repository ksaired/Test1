using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeffaultLinkToObjectAssets 
{
    public Dictionary<string, string> LinksToAssets = new Dictionary<string, string>()
    {
        //TreatmentStatePath
        {"TreatmentStateFacadeKindPath","Scripts/Objects/GameObject" },
        {"TreatmentOfNPCStateKindPath","/NPCObjects" },
        {"TreatmentOfVisitorStateKindPath","/VisitorObjects/TreatmentStates" },
        {"TreatmentOfPlayerStateKindPath","/PlayerObjects/TreatmentStates" },


        //StatePaths
        {"StateKindPath","Objects/GameObject" },
        {"PlayerStatePath","/PlayerObjects/States/PlayerState" },
        {"MainPlayerStatePath","/MainPlayerState" },
        {"NPCStateKindPath","/NPCObject" },
        {"VisitorStatePath","/VisitorObjects/States/VisitorState" },
        {"MainVisitorStatePath","/VisitorObjects/States/MainVisitorState" },


        //ObjectFacadePaths
        {"ObjectFacadePrefabsPath","Prefabs/Objects" },
        {"PlayerObjectFacadePrefabsPath","/PlayerPrefabs" },
        {"NPCObjectFacadePrefabsPath","/NPCPrefabs" },
        {"VisitorObjectFacadePrefabsPath","/VisitorPrefabs" }
};

}
