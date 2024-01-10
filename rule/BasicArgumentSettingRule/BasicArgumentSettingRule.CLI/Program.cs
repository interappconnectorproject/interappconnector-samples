using BasicArgumentSettingRule.Library;
using InterAppConnector;

namespace BasicArgumentSettingRule.CLI
{
    public class Program
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
