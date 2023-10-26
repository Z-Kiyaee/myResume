using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models;
using Resume.Domain.Models.Entities;
using Resume.Presentation.Models.ResumeDbContext;
using System.Diagnostics;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.RepositoryInterface;


namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEducationRepository _educationRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly ISkillRepository _skillRepository;

        public HomeController(IEducationRepository educationRepository, 
                              IExperienceRepository experienceRepository,
                              ISkillRepository skillRepository)
        {
            _educationRepository = educationRepository;
            _experienceRepository = experienceRepository;
            _skillRepository = skillRepository;
        }

        public async Task<IActionResult> Index()
        {
            var mySkills = await _skillRepository.GetListOfMySkills();
            var myEducations = await _educationRepository.GetListOfEducations();
            var myExperiences = await _experienceRepository.GetListOfExperience();

			HomeIndexModelDTO model = new HomeIndexModelDTO
            {
                Educations = myEducations,
                Experiences = myExperiences,
                Skills = mySkills
            };

			#region ViewBag
			//ViewBag.Skills = mySkills;
			//ViewBag.Educations = myEducations;
			//ViewBag.Experiences = myExperiences;
			#endregion

			return View(model);
        }

    }
}