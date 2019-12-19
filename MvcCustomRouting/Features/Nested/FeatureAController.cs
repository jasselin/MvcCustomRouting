using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features.Nested
{
    public class FeatureAController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature A (nested)");
        }
    }
}
