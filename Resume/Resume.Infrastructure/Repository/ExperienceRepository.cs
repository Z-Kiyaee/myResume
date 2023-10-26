using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
	public class ExperienceRepository : IExperienceRepository
	{
		private readonly ResumeDbContext _context;

		public ExperienceRepository(ResumeDbContext context)
		{
			_context = context;
		}

		public async Task<List<Experience>> GetListOfExperience()
		{
			return await _context.Experiences.ToListAsync();
		}
	}
}
