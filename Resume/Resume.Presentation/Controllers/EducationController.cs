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
        //get list of educations
        List<Education> educationsList = _context.Educations.ToList();
        
        //get first education
        Education firstEducation = educationsList.First();


        return View();
    }

    public IActionResult AddRecords()
    {
        Education education1 = new Education()
        {
            EducatationTitle = "High School",
            EducationDuration = "2018-2022",
            Description = "Bachelor's degree"
        };
        _context.Educations.Add(education1);
        _context.SaveChanges();

        return View();

    }
}
