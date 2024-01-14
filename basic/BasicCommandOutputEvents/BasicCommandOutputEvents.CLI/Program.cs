using BasicCommandOutputEvents.Library;
using InterAppConnector;
using InterAppConnector.DataModels;
using InterAppConnector.Enumerations;

namespace BasicCommandOutputEvents.CLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandManager command = new CommandManager();
            command.AddCommand<ReadCommand, EmptyDataModel>();

            InterAppCommunication connector = new InterAppCommunication(command);
            connector.ErrorMessageEmitted += Connector_ErrorMessageEmitted;
            connector.ExecuteAsInteractiveCLI(args);
        }

        private static void Connector_ErrorMessageEmitted(CommandExecutionMessageType messageStatus, int exitCode, object message)
        {
            Console.WriteLine("This is a custom error that replaces the standard one");
        }
    }
}