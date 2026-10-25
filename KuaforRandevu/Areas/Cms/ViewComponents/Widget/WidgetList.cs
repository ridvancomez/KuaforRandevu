using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.ViewComponents.Widget
{
    public class WidgetList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
