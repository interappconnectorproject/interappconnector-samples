using BasicCommand.Library;
using InterAppConnector.DataModels;
using InterAppConnector;
using System.Dynamic;

namespace BasicCommand.MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            CommandResult<string> commandResult = InterAppCommunication.CallSingleCommand<HelloCommand, EmptyDataModel>()
                .ExecuteAsBatch<string>("hello", new ExpandoObject());

            MessageStatus.Text = "MessageStatus: " + Enum.GetName(commandResult.MessageStatus);
            MessageType.Text = "MessageType: " + commandResult.MessageType;
            Message.Text = "Message: " + commandResult.Message;
        }
    }

}
