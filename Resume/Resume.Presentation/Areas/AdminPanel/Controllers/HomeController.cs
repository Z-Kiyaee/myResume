using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{

    [Area("AdminPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
