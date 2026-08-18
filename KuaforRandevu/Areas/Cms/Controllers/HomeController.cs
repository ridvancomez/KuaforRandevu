using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.Controllers
{
    [Area("Cms")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
