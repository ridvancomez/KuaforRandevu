using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.ViewComponents.CmsService
{
    public class CmsServiceList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
