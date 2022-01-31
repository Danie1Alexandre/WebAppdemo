using Microsoft.AspNetCore.Mvc;

namespace WebAppdemo.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
