using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features.Nested
{
    public class FeatureDController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature D (nested)");
        }
    }
}
