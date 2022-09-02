public abstract class VisitorObjectFacade : NPCObjectFacade,IQuestGiver
{
    public override NPCResource CurrentNPCInfo { get => CurrentVisitorInfo; set => CurrentVisitorInfo = (VisitorResource)value; }
    public override string PrefabLoadPath { get => ObjectFacadePrefabsPath + NPCObjectFacadePrefabsPath + VisitorObjectFacadePrefabsPath; protected set => base.PrefabLoadPath = value; }

    IQuestGiverResource IQuestGiver.CurrentIQuestGiverResource { get => CurrentVisitorInfo; set => CurrentVisitorInfo = (VisitorResource)value; }


    public virtual VisitorResource CurrentVisitorInfo { get; set; }

    protected string VisitorObjectFacadePrefabsPath = SceneInfo.GetLinkToAssets("VisitorObjectFacadePrefabsPath");
    protected string CurrentVisitorLoadPath = "VisitorResource";

    public virtual bool GetIQuestGiverState(out IQuestGiverState CurrentIQuestGiverState)
    {
        CurrentIQuestGiverState =  CurrentVisitorInfo.CurrentVisitorTreatmentState.CurrentVisitorState.Find(i => i is IQuestGiverState a) as IQuestGiverState;

        CurrentIQuestGiverState = CurrentVisitorInfo.CurrentVisitorTreatmentMainState.CurrentVisitorState.Find(i => i is IQuestGiverState a) as IQuestGiverState;

        if (CurrentIQuestGiverState == null) return false;
        
        return true;
    }
}
