using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TakeSomethingTaskForActivingObject : TaskForActivingObjectFacade
{
    public override string TaskTablePrefabsLoadPath { get => TaskTakeSomethingTaskForActivingObjectTablePrefabsLoadPath; protected set => TaskTakeSomethingTaskForActivingObjectTablePrefabsLoadPath = value; }

    public override string NameOfTask { get => base.NameOfTask; protected set => base.NameOfTask = value; }
    public override string DescriptionOfTask { get => base.DescriptionOfTask; protected set => base.DescriptionOfTask = value; }

    public Dictionary<string, List<int>> Rewards = new Dictionary<string, List<int>>();

    public Dictionary<string, List<float>> GoalsResource = new Dictionary<string, List<float>>();

    public Dictionary<string, List<float>> Goals = new Dictionary<string, List<float>>();

    private string TaskTakeSomethingTaskForActivingObjectTablePrefabsLoadPath = "/TakeSomethingTaskForActivingObject";
    public TakeSomethingTaskForActivingObject(string NameOfTask, string DescriptionOfTask, Dictionary<string, List<int>> Rewards, Dictionary<string, List<float>> GoalsResource, Dictionary<string, List<float>> Goals)
    {
        this.NameOfTask = NameOfTask;
        this.DescriptionOfTask = DescriptionOfTask;

        this.Rewards = Rewards;
        this.GoalsResource = GoalsResource;
        this.Goals = Goals;
    }

    public override void ChangeNameOfTask(string NewNameOfTask)
    {
        base.ChangeNameOfTask(NewNameOfTask);
    }
    public override void ChangeDescriptionOfTask(string NewDescriptionOfTask)
    {
        base.ChangeDescriptionOfTask(NewDescriptionOfTask);
    }
    public override GameObject CreateCurrentTaskTable()
    {
        return base.CreateCurrentTaskTable();
    }

    public override void StartTask()
    {
        
    }
    public override bool CheckOfGoal(IQuestTaker CurrentQuestTaker)
    {
        foreach (var i in Goals.Keys)
        {
            if (Goals.TryGetValue(i, out List<float> CurrentGoals))
            {
                if (CheckAllGoals(CurrentQuestTaker, CurrentGoals,i))
                {
                    return true;
                }
            }
        }

        return false;
    }
    public override bool CheckOfCompleteTask(ref IQuestTaker CurrentQuestTaker,ref IQuestGiverResource CurrentGiverResource)
    {
        foreach (var i in Goals.Keys)
        {
            if (Goals.TryGetValue(i,out List<float> CurrentGoals))
            {
                if (CheckAllGoals(CurrentQuestTaker,CurrentGoals,i))
                {
                    if(TakeReward(ref CurrentQuestTaker))
                    {
                        CurrentQuestTaker.CurrentIQuestTakerResource.RemoveFromRecivedTask(this);
                        CurrentGiverResource.RemoveFromGivedTask(this);

                        return true;
                    }
                }
            }
        }

        return false;
    }
    
    protected override bool TakeReward(ref IQuestTaker CurrentQuestTaker)
    {
        RemoveGoalsResource(ref CurrentQuestTaker);

        return RecieveRewards(ref CurrentQuestTaker);
    }

    protected bool CheckAllGoals(IQuestTaker CurrentQuestTaker, List<float> CurrentGoals,string CurrentTag)
    {
        foreach (var a in CurrentGoals)
        {
            if (CurrentQuestTaker.CheckOnCompleteGoal(a,CurrentTag))
            {
                return true;
            }
        }

        return false;
    }

    protected bool RemoveGoalsResource(ref IQuestTaker CurrentQuestTaker)
    {
        foreach (var i in GoalsResource.Keys)
        {
            if (GoalsResource.TryGetValue(i, out List<float> CurrentGoalsResource))
            {
                foreach (var a in CurrentGoalsResource)
                {
                    CurrentQuestTaker.RemoveGoalResource(a,i);

                    return true;
                }
            }
            
            
        }

        return false;
    }
    protected bool RecieveRewards(ref IQuestTaker CurrentQuestTaker)
    {
        foreach (var i in Rewards.Keys)
        {
            if (Rewards.TryGetValue(i, out List<int> CurrentRewards))
            {
                foreach (var a in CurrentRewards)
                {
                    CurrentQuestTaker.RemoveGoalResource(a, i);

                    return true;
                }
            }


        }


        return false;
    }
}
