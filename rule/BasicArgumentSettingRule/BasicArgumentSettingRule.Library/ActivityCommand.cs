using InterAppConnector;
using InterAppConnector.Attributes;
using InterAppConnector.Interfaces;

namespace BasicArgumentSettingRule.Library
{
    [Command("activityexample")]
    public class ActivityCommand : ICommand<ActivityDataModel>
    {
        public string Main(ActivityDataModel arguments)
        {
            if (arguments.ActivityTracker == null)
            {
                arguments.ActivityTracker = new ActivityTracker("50");
                arguments.ActivityTracker.AddActivity("Maximum activity row number not set: Default value: 50");
            }

            arguments.ActivityTracker.AddActivity("Command start");
            return CommandOutput.Ok(arguments.ActivityTracker.GetActivityList());
        }
    }
}
