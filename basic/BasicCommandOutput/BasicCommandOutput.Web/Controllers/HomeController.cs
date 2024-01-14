using BasicCommandOutput.Library;
using BasicCommandOutput.Web.Models;
using InterAppConnector.DataModels;
using InterAppConnector;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace BasicCommandOutput.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected CommandResult<string> CommandResult { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            InterAppCommunication communication = InterAppCommunication.CallSingleCommand<ReadCommand, EmptyDataModel>();
            CommandResult = communication.ExecuteAsBatch<string>("read", new ExpandoObject());
            return View(CommandResult);
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
