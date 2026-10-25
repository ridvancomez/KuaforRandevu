using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.Controllers
{
    public class AdminCrudBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
