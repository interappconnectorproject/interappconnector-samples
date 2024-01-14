using BasicCommandOutput.Library;
using InterAppConnector.DataModels;
using InterAppConnector;
using System.Dynamic;

namespace BasicCommandOutput.Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            InterAppCommunication communication = InterAppCommunication.CallSingleCommand<ReadCommand, EmptyDataModel>();
            CommandResult<string> commandResult = communication.ExecuteAsBatch<string>("read", new ExpandoObject());

            MessageStatus.Text = "MessageStatus: " + Enum.GetName(commandResult.MessageStatus);
            MessageType.Text = "MessageType: " + commandResult.MessageType;
            Message.Text = "Message: " + commandResult.Message;
        }
    }

}
