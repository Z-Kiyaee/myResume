using Microsoft.AspNetCore.Mvc;
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
		public async Task<IActionResult> ContactUs(ContactUs contactUs)
		{
			//object mapping

				contactUs.CreateDate = DateTime.Now;
				contactUs.IsSeenByAdmin = false;

			//add to DB
			await _contactUsRepository.AddContactUsToDB(contactUs);

			return View();
		}
	}
}
