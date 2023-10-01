using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Presentation.Controllers;

public class EducationController : Controller
{


    public async Task<IActionResult> ListOfEducations()
    {
        return View();
    }

    public async Task<IActionResult> AddEducation()
    {
        return RedirectToAction(nameof(ListOfEducations));
    }

    public async Task<IActionResult> RemoveEducation(int educationId)
    {
        return RedirectToAction(nameof(ListOfEducations));
    }
}
