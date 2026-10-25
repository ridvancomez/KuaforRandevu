using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Areas.Cms.ViewComponents.Chat
{
    public class ChatList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
