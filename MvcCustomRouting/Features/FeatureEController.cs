using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features
{
    public class FeatureEController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature E");
        }
    }
}
