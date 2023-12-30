using InterAppConnector;
using InterAppConnector.Attributes;
using InterAppConnector.DataModels;
using InterAppConnector.Interfaces;

namespace BasicCommand.Library
{
    [Command("hello", Description = "A simple hello world command")]
    public class HelloCommand : ICommand<EmptyDataModel>
    {
        public string Main(EmptyDataModel arguments)
        {
            return CommandOutput.Ok("Hello World");
        }
    }
}