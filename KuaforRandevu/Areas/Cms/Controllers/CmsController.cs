using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.Controllers
{
    [Area("Cms")]
    public class CmsController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
