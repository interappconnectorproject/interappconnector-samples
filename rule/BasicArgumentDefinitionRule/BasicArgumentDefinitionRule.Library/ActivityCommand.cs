using InterAppConnector;
using InterAppConnector.Attributes;
using InterAppConnector.Interfaces;

namespace BasicArgumentDefinitionRule.Library
{
    [Command("activityexample")]
    public class ActivityCommand : ICommand<ActivityDataModel>
    {
        public string Main(ActivityDataModel arguments)
        {
            arguments.ActivityTracker.AddActivity("Command start");
            return CommandOutput.Ok(arguments.ActivityTracker.GetActivityList());
        }
    }
}
