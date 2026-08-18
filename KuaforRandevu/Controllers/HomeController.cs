using System.Diagnostics;
using KuaforRandevu.Models;
using Microsoft.AspNetCore.Mvc;

namespace KuaforRandevu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
