using InterAppConnector.DataModels;

namespace BasicCommandOutputEvents.Web.Models
{
    public class ResultViewModel
    {
        public string Color { get; set; }
        public CommandResult<string> CommandResult { get; set; }
    }
}
