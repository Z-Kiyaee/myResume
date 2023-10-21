using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models;
using Resume.Presentation.Models.ResumeDbContext;
using System.Diagnostics;
using Resume.Application.DTOs.SiteSide.Home_Index;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ResumeDbContext _context;

        public HomeController(ResumeDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var mySkills = await _context.MySkills.ToListAsync();
            var myEducations = await _context.Educations.ToListAsync();
            var myExperiences = await _context.Experiences.ToListAsync();

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