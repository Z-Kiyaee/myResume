using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models;
using Resume.Presentation.Models.ResumeDbContext;
using System.Diagnostics;

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

            return View(myEducations);
        }

    }
}