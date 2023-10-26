using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly IContactUsRepository _contactUsRepository;

		public ContactUsController(IContactUsRepository contactUsRepository)
		{
			_contactUsRepository = contactUsRepository;
		}

		public async Task<IActionResult> ContactUs()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
		{
			//object mapping
			ContactUs contactUs = new ContactUs()
			{
				Name = contactUsDTO.Name,
				PhoneNumber = contactUsDTO.PhoneNumber,
				Message = contactUsDTO.Message,
				CreateDate = DateTime.Now,
				IsSeenByAdmin = false
			};


			//add to DB
			await _contactUsRepository.AddContactUsToDB(contactUs);

			return View();
		}
	}
}
