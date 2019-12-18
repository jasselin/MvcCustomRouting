using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features
{
    public class FeatureAController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature A");
        }
    }
}
