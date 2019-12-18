using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features
{
    public class FeatureBController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature B");
        }
    }
}
