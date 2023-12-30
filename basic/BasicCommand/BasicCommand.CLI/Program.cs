using InterAppConnector;
using InterAppConnector.DataModels;
using BasicCommand.Library;

namespace HelloApplication.CLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandManager command = new CommandManager();
            command.AddCommand<HelloCommand, EmptyDataModel>();

            InterAppCommunication connector = new InterAppCommunication(command);
            connector.ExecuteAsInteractiveCLI(args);
        }
    }
}