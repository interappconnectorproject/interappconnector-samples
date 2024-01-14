using InterAppConnector;
using InterAppConnector.Attributes;
using InterAppConnector.DataModels;
using InterAppConnector.Interfaces;

namespace BasicCommandOutput.Library
{
    [Command("read", Description = "Read the content of the file")]
    public class ReadCommand : ICommand<EmptyDataModel>
    {
        public string Main(EmptyDataModel arguments)
        {
            string filePath = Path.Combine(Path.GetFullPath("."), "testfile.txt");
            string output;
            CommandOutput.Info("Checking if the file " + filePath + " exists");
            if (File.Exists(filePath))
            {
                CommandOutput.Info("The file " + filePath + " exists. Reading its content");
                output = CommandOutput.Ok(File.ReadAllText(filePath));
            }
            else
            {
                output = CommandOutput.Error("Cannot read the content of the file in " + filePath + ". File is not accessible or does not exist");
            }
            return output;
        }
    }
}