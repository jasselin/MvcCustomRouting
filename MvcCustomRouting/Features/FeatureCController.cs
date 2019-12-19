using Microsoft.AspNetCore.Mvc;

namespace MvcCustomRouting.Features
{
    public class FeatureCController : Controller
    {
        public IActionResult Index()
        {
            return Content("Feature C");
        }
    }
}
