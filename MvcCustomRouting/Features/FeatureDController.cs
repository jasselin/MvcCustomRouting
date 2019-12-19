using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features
{
    public class FeatureDController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature D");
        }
    }
}
