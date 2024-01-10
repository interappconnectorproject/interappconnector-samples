using BasicArgumentSettingRule.Web.Models;
using InterAppConnector;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using BasicArgumentSettingRule.Library;

namespace BasicArgumentSettingRule.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(InterAppCommunication.CallSingleCommand<ActivityCommand, ActivityDataModel>().ExecuteAsBatch<List<string>>("activityexample", new ExpandoObject()));
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
