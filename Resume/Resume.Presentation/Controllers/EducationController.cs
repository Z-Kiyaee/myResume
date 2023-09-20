using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models.Entities;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Presentation.Controllers;

public class EducationController : Controller
{
    private ResumeDbContext _context;

    public EducationController(ResumeDbContext context)
    {
        _context = context;
    }

    public IActionResult ListOfEducations()
    {
        List<Education> educationsList = _context.Educations.ToList();
        return View();
    }
}
