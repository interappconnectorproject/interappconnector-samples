using InterAppConnector.Attributes;

namespace BasicArgumentDefinitionRule.Library
{
    public class ActivityDataModel
    {
        [ExcludeItemFromCommand]
        public ActivityTracker ActivityTracker { get; set; } = new ActivityTracker("50");
    }
}
