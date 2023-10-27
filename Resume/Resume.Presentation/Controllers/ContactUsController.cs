using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly IContactUsService _contactUsService;
        public ContactUsController(IContactUsService contactUsService)
        {
			_contactUsService = contactUsService;

		}

        public async Task<IActionResult> ContactUs()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
		{
			await _contactUsService.AddContactUs(contactUsDTO);
			return View();
		}
	}
}
