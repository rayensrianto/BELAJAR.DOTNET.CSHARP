using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public string Index()
        //{
        //    return "This is my default action";
        //}

        //public string Welcome()
        //{
        //    return "This is from Welcome() action method..";
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public string TestParameter(String name, int numTimes = 1)
        {
            return $"Hello {name}, your Num Times is {numTimes}";
        }
    }
}
