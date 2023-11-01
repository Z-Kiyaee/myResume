using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IActionResult GetListOfEducation()
        {
            var model = _educationService.GetListOfEducationForAdminPanel();
            //or _educationService.GetListOfEducations();

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
