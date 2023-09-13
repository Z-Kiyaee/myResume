using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
	public class AdminController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Index(string Email, string Username)
        {
            return View();
        }
    }
}
