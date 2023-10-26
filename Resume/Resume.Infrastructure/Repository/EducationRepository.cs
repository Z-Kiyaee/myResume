using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;

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
