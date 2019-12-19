using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features.Nested
{
    public class FeatureBController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature B (nested)");
        }
    }
}
