using Microsoft.AspNet.Mvc;

namespace CompileExample
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
