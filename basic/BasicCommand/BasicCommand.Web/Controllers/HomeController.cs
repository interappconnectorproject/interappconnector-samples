using BasicCommand.Library;
using BasicCommand.Web.Models;
using InterAppConnector;
using InterAppConnector.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace BasicCommand.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected CommandResult<string> commandResult = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            commandResult = InterAppCommunication.CallSingleCommand<HelloCommand, EmptyDataModel>().ExecuteAsBatch<string>("hello", new ExpandoObject());
            return View(commandResult);
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
