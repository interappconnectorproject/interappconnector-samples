using BasicCommandOutputEvents.Library;
using BasicCommandOutputEvents.Web.Models;
using InterAppConnector;
using InterAppConnector.DataModels;
using InterAppConnector.Enumerations;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace BasicCommandOutputEvents.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ResultViewModel commandResult = new ResultViewModel();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            InterAppCommunication communication = InterAppCommunication.CallSingleCommand<ReadCommand, EmptyDataModel>();
            communication.ErrorMessageEmitted += Communication_ErrorMessageEmitted;
            commandResult.CommandResult = communication.ExecuteAsBatch<string>("read", new ExpandoObject());
            return View(commandResult);
        }

        private void Communication_ErrorMessageEmitted(CommandExecutionMessageType messageStatus, int exitCode, object message)
        {
            commandResult.Color = "#f99";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
