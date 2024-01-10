using BasicArgumentDefinitionRule.Library;
using InterAppConnector;

namespace BasicArgumentDefinitionRule.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandManager manager = new CommandManager();
            manager.AddCommand<ActivityCommand, ActivityDataModel>();

            InterAppCommunication communication = new InterAppCommunication(manager);
            communication.ExecuteAsInteractiveCLI(args);
        }
    }
}
