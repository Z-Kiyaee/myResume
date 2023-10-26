using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
	public class SkillRepository : ISkillRepository
	{
		private readonly ResumeDbContext _context;

		public SkillRepository(ResumeDbContext context)
		{
			_context = context;
		}

		public async Task<List<MySkills>> GetListOfMySkills()
		{
			return await _context.MySkills.ToListAsync();
		}
	}
}
