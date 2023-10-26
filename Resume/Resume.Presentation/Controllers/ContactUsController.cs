using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{

		public async Task<IActionResult> ContactUs()
		{
			return View();
		}
	}
}
