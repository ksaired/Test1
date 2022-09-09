using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisitorSaveResource : NPCSaveResource,IQuestGiverSaveResource
{
    public override Dictionary<string, List<string>> CurrentLinkToStates { get => DeffaultCurrentLinkToStates; set => DeffaultCurrentLinkToStates = value; }

    public List<TaskFacade> TaskForGive { get => DeffaultTaskForGive.ConvertAll(new System.Converter<TaskForActivingObjectFacade, TaskFacade>(i => i)); set => DeffaultTaskForGive = value.ConvertAll(new System.Converter<TaskFacade, TaskForActivingObjectFacade>(i => (TaskForActivingObjectFacade)i)); }
    public List<TaskFacade> GivedTask { get => DeffaultGivedTask.ConvertAll(new System.Converter<TaskForActivingObjectFacade, TaskFacade>(i => i)); set => DeffaultGivedTask = value.ConvertAll(new System.Converter<TaskFacade, TaskForActivingObjectFacade>(i => (TaskForActivingObjectFacade)i)); }
    public int LimitOfTaskforGive { get => DeffaultLimitOfTaskforGive; set => DeffaultLimitOfTaskforGive = value; }
    public int LimitOfGivedTask { get => DeffaultLimitOfGivedTask; set => DeffaultLimitOfGivedTask = value; }

    public Dictionary<string, List<string>> DeffaultCurrentLinkToStates = new Dictionary<string, List<string>>();

    public List<TaskForActivingObjectFacade> DeffaultTaskForGive = new List<TaskForActivingObjectFacade>()
    {
        new TakeSomethingTaskForActivingObject("TestTask","JustTestTask",

        new Dictionary<string, List<int>>()
        {
              {"currentint",new List<int>()
                        {
                            10
                        }
              }
        },
        new Dictionary<string, List<float>>()
        {
            {"currentfloat",new List<float>()
                        {
                            5f
                        }
            }
        },
        new Dictionary<string, List<float>>()
        {
             {"currentfloat",new List<float>()
                        {
                            5f
                        }
             }

        }

        )
    
    };

    public List<TaskForActivingObjectFacade> DeffaultGivedTask = new List<TaskForActivingObjectFacade>();

    public int DeffaultLimitOfTaskforGive = 2;
    public int DeffaultLimitOfGivedTask = 2;
}
