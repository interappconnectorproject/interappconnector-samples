namespace BasicArgumentSettingRule.Library
{
    public class ActivityTracker
    {
        private List<string> _activityList { get; set; } = new List<string>();
        private readonly int _maximumRowNumber;

        public ActivityTracker(string maximumRowNumber)
        {
            if (!int.TryParse(maximumRowNumber, out _maximumRowNumber) && _maximumRowNumber >= 0)
            {
                throw new ArgumentException("The value inserted is not a number or you have inserted a negative number");
            }
        }

        public void AddActivity(string activity)
        {
            if (_maximumRowNumber > 0 && _activityList.Count < _maximumRowNumber + 1)
            {
                if (_activityList.Count == _maximumRowNumber)
                {
                    _activityList.Add("Maximum number of rows reached");
                }
                else
                {
                    _activityList.Add(activity);
                }
            }
            else
            {
                _activityList.Add(activity);
            }
        }

        public List<string> GetActivityList()
        {
            return _activityList;
        }
    }
}
