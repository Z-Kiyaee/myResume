using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
	public class ContactUsRepository : IContactUsRepository
	{
		private readonly ResumeDbContext _context;
        public ContactUsRepository(ResumeDbContext context)
        {
            _context = context;
        }

        public async Task AddContactUsToDB(ContactUs contactUs)
		{
			await _context.AddAsync(contactUs);
			await _context.SaveChangesAsync();
		}
	}
}
