using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }
    }
}
