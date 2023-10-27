using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
	public class ContactUsService : IContactUsService
	{
		private readonly IContactUsRepository _contactUsRepository;

		public ContactUsService(IContactUsRepository contactUsRepository)
		{
			_contactUsRepository = contactUsRepository;
		}

		public async Task AddContactUs(ContactUsDTO contactUsDTO)
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
		}
	}
}
