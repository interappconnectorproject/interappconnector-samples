using InterAppConnector.DataModels;
using InterAppConnector;
using System.Dynamic;
using BasicCommandOutputEvents.Library;

namespace BasicCommandOutputEvents.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            InterAppCommunication communication = InterAppCommunication.CallSingleCommand<ReadCommand, EmptyDataModel>();
            communication.ErrorMessageEmitted += Communication_ErrorMessageEmitted;
            CommandResult<string> commandResult = communication.ExecuteAsBatch<string>("read", new ExpandoObject());

            MessageStatus.Text = "MessageStatus: " + Enum.GetName(commandResult.MessageStatus);
            MessageType.Text = "MessageType: " + commandResult.MessageType;
            Message.Text = "Message: " + commandResult.Message;
        }

        private void Communication_ErrorMessageEmitted(InterAppConnector.Enumerations.CommandExecutionMessageType messageStatus, int exitCode, object message)
        {
            Message.BackgroundColor = Color.FromArgb("ffff5555");
        }
    }

}
