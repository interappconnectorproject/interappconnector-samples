using InterAppConnector;
using InterAppConnector.DataModels;
using BasicCommandOutput.Library;

namespace BasicCommandOutput.CLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandManager command = new CommandManager();
            command.AddCommand<ReadCommand, EmptyDataModel>();

            InterAppCommunication connector = new InterAppCommunication(command);
            connector.ExecuteAsInteractiveCLI(args);
        }
    }
}