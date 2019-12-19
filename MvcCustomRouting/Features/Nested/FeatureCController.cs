using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features.Nested
{
    public class FeatureCController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature C (nested)");
        }
    }
}
