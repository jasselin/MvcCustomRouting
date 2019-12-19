using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features.Nested
{
    public class FeatureEController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature E (nested)");
        }
    }
}
