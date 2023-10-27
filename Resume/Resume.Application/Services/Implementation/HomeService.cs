using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interfaces;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
	public class HomeService : IHomeService
	{
		private readonly IEducationService _educationService;
		private readonly IExperienceService _experienceService;
		private readonly IMySkillService _skillService;

		public HomeService(IEducationService educationService,
							  IExperienceService experienceService,
							  IMySkillService skillService)
		{
			_educationService = educationService;
			_experienceService = experienceService;
			_skillService = skillService;
		}

		public async Task<HomeIndexModelDTO> FillHomeModel()
		{
			var mySkills = await _skillService.GetListOfMySkills();
			var myEducations = await _educationService.GetListOfEducations();
			var myExperiences = await _experienceService.GetListOfExperience();

			HomeIndexModelDTO model = new HomeIndexModelDTO
			{
				Educations = myEducations,
				Experiences = myExperiences,
				Skills = mySkills
			};
			return model;
		}
		
	}
}
