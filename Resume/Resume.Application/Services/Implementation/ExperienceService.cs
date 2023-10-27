using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
	public class ExperienceService : IExperienceService
	{
		private readonly IExperienceRepository _experienceRepository;

        public ExperienceService(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

		public async Task<List<Experience>> GetListOfExperience()
		{
			return await _experienceRepository.GetListOfExperience();
		}
	}
}
