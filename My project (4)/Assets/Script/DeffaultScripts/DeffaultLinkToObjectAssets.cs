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
        {"NPCStateKindPath","/NPCObjects" },
        {"VisitorStatePath","/VisitorObjects/States/VisitorState" },
        {"MainVisitorStatePath","/VisitorObjects/States/MainVisitorState" },


        //ObjectFacadePaths
        {"ObjectFacadePrefabsPath","Prefabs/Objects" },
        {"PlayerObjectFacadePrefabsPath","/PlayerPrefabs" },
        {"NPCObjectFacadePrefabsPath","/NPCPrefabs" },
        {"VisitorObjectFacadePrefabsPath","/VisitorPrefabs" },

        //KindPathToAssetsForResource
        {"ResourceKindPathToAssetsForResource","ResourceAssets"},
        {"PlayerResourceKindPathToAssetsForResource","/PlayerAssets" },
        {"NPCResourceKindPathToAssetsForResource","/NPCAssets" },
        {"VisitorResourceKindPathToAssetsForResource","/VisitorAssets" },

        //TaskPrefabsLoadKindPath 
        {"TaskFacadePrefabsLoadKindPath","/UiTask" },
        {"TaskForActivingObjectFacadePrefabsLoadKindPath","/UiTaskForActivingObject" },

        //QuestGiverLoadKindPath
        {"VisitorQuestGiverLoadKindPath","/VisitorGiverUi" }
    };

}
