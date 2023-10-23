using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
	public class EducationRepository : IEducationRepository
	{
		private readonly ResumeDbContext _context;

		public EducationRepository(ResumeDbContext context)
		{
			_context = context;
		}

		public async Task<List<Education>> GetListOfEducations()
		{
			return await _context.Educations.ToListAsync();
		}
	}
}
