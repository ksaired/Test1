using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisitorGiveTaskState : VisitorState,IQuestGiverState
{
   public VisitorTestResource CurrentVisitorTestResource = new VisitorTestResource();

   private string VisitorGiveTaskStatePath = "VisitorGiveTaskState";

   private Vector3 DeffaultPositionOfExitFromTableButton = new Vector3(17,10);

   private string DeffaultPrefabsLoadPath = SceneInfo.GetLinkToAssets("VisitorQuestGiverLoadKindPath");
   private float DeffaultDistanceForButtonOnX = 1f;
   private float DeffaultDistanceForButtonOnY = 0.5f;

   private string DeffaultUiObjectLinkToTheFirstUiQuestGiverMenu = "TheFirstUiQuestGiverMenu";
   private string DeffaultUiObjectLinkToTheSecondaryUiQuestGiverMenu = "TheSecondaryUiQuestGiverMenu";
   private string DeffaultLinkToBaseUiButton = "BaseButton";
   private string DeffaultLinkToDropdownBaseObject = "BaseDropdown";

   private float DeffaultDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject = 1f;
   private float DeffaultDistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu = 1f;

   private List<TaskFacade> DeffaultCurrentTreatmentTasks;

   private TaskFacade DeffaultCurrentTreatmentTask;
   private GameObject DeffaultCurrentTaskTable;
   private Dropdown DeffaultCurrentDropDown;

   private GameObject DeffaultCurrentQuestTaskTaker;
   private GameObject DeffaultCurrentGameObject;

   private GameObject DeffaultTheFirstUiQuestGiverMenu;
   private GameObject DeffaultTheSecondaryUiQuestgiverMenu;
      
   public override VisitorResource CurrentVisitorInfo { get =>  CurrentVisitorTestResource; set => CurrentVisitorTestResource = (VisitorTestResource)value; }
   public override string StatePath { get => VisitorGiveTaskStatePath; protected set => VisitorGiveTaskStatePath = value; }

   IQuestGiverResource IQuestGiverState.CurrentResource { get => CurrentVisitorTestResource; set => CurrentVisitorTestResource = (VisitorTestResource)value; }

   Vector3 IQuestGiverState.PositionOfExitFromTableButton { get => DeffaultPositionOfExitFromTableButton; set => DeffaultPositionOfExitFromTableButton = value; }

   string IQuestGiverState.PreafabsLoadPath { get => DeffaultPrefabsLoadPath; set => DeffaultPrefabsLoadPath = value; }
   float IQuestGiverState.DistanceForButtonOnX { get => DeffaultDistanceForButtonOnX; set => DeffaultDistanceForButtonOnX = value; }
   float IQuestGiverState.DistanceForButtonOnY { get => DeffaultDistanceForButtonOnY; set => DeffaultDistanceForButtonOnY = value; }

   string IQuestGiverState.UiObjectLinkToTheFirstUiQuestGiverMenu { get => DeffaultUiObjectLinkToTheFirstUiQuestGiverMenu; set => DeffaultUiObjectLinkToTheFirstUiQuestGiverMenu = value; }
   string IQuestGiverState.UiObjectLinkToTheSecondaryUiQuestGiverMenu { get => DeffaultUiObjectLinkToTheSecondaryUiQuestGiverMenu; set => DeffaultUiObjectLinkToTheSecondaryUiQuestGiverMenu = value; }
   string IQuestGiverState.LinkToBaseUiButton { get => DeffaultLinkToBaseUiButton; set => DeffaultLinkToBaseUiButton = value; }
   string IQuestGiverState.LinkToDropdownBaseObject { get => DeffaultLinkToDropdownBaseObject; set => DeffaultLinkToDropdownBaseObject = value; }

   float IQuestGiverState.DistanceBetweenTheFirstUiQuestGiverMenuAndGameObject { get => DeffaultDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject; set => DeffaultDistanceBetweenTheFirstUiQuestGiverMenuAndGameObject = value; }
   float IQuestGiverState.DistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu { get => DeffaultDistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu; set => DeffaultDistanceBeetwenTheFirstUiQuestGiverMenuAndTheSecondaryUiQuestGiverMenu  = value; }

   List<TaskFacade> IQuestGiverState.CurrentTreatmentTasks { get => DeffaultCurrentTreatmentTasks; set =>DeffaultCurrentTreatmentTasks = value; }
   TaskFacade IQuestGiverState.CurrentTreatmentTask { get => DeffaultCurrentTreatmentTask; set =>DeffaultCurrentTreatmentTask = value; }
   GameObject IQuestGiverState.CurrentTaskTable { get => DeffaultCurrentTaskTable; set => DeffaultCurrentTaskTable = value; }
   Dropdown IQuestGiverState.CurrentDropDown { get => DeffaultCurrentDropDown; set => DeffaultCurrentDropDown = value; }
   GameObject IQuestGiverState.CurrentQuestTaskTaker { get => DeffaultCurrentQuestTaskTaker; set => DeffaultCurrentQuestTaskTaker = value; }
   GameObject IQuestGiverState.CurrentGameObject { get => DeffaultCurrentGameObject; set => DeffaultCurrentGameObject = value; }
   GameObject IQuestGiverState.TheFirstUiQuestGiverMenu { get => DeffaultTheFirstUiQuestGiverMenu; set => DeffaultTheFirstUiQuestGiverMenu = value; }
   GameObject IQuestGiverState.TheSecondaryUiQuestgiverMenu { get => DeffaultTheSecondaryUiQuestgiverMenu; set => DeffaultTheSecondaryUiQuestgiverMenu = value; }
 

    public override Resource StartFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;


        return this.CurrentInfo;
    }

    public override Resource UpdateFacade(Resource CurrentInfo)
    {
        this.CurrentInfo = CurrentInfo;


        return this.CurrentInfo = CurrentInfo;
    }

    public override void StopState()
    {
        Debug.Log("stopstate");

        
    }

    void IQuestGiverState.DestroyTable()
    {

    }
    

}
