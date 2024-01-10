using InterAppConnector.Attributes;

namespace BasicArgumentSettingRule.Library
{
    public class ActivityDataModel
    {
        [Alias("maxactivityrownumber")]
        public ActivityTracker ActivityTracker { get; set; }
    }
}
