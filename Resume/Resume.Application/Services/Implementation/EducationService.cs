using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Resume.Application.Services.Implementation
{
    public class EducationService : IEducationService
    {
        private ResumeDbContext _context;

        public EducationService(ResumeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Education>> ListOfEducations()
        {
            //get list of educations
            List<Education> educationsList = await _context.Educations.ToListAsync();

            return educationsList;
        }

        public async Task AddEducation(Education education)
        {
            Education education1 = new Education()
            {
                EducatationTitle = "High School",
                EducationDuration = "2018-2022",
                Description = "Bachelor's degree"
            };
            await _context.Educations.AddAsync(education1);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveEducation(int educationId)
        {
            Education education = await GetAnEducationById(educationId);
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
        }

        public async Task<Education> GetAnEducationById(int educationId)
        {
            Education? education = await _context.Educations.Where(e => e.Id == educationId).FirstOrDefaultAsync();
            if (education == null)
            {
                return null;
            }
            return education;
        }
    }
}
