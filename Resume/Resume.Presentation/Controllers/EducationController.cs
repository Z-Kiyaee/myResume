using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    public async Task<IActionResult> ListOfEducations()
    {
        //get list of educations
        List<Education> educationsList = await _context.Educations.ToListAsync();
        
        //get first education
        //Education firstEducation = educationsList.First();


        return View();
    }

    public async Task<IActionResult> AddEducation()
    {
        Education education1 = new Education()
        {
            EducatationTitle = "High School",
            EducationDuration = "2018-2022",
            Description = "Bachelor's degree"
        };
        await _context.Educations.AddAsync(education1);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(ListOfEducations));

    }

    public async Task<IActionResult> RemoveEducation()
    {
        Education? education = await _context.Educations.Where(e => e.Id == 2).FirstOrDefaultAsync();
        _context.Educations.Remove(education);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(ListOfEducations));
    }
}
