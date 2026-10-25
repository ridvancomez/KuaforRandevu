using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.ViewComponents.Breadcrumb
{
    public class BreadcrumList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
