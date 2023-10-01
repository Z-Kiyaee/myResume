using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    internal interface IEducationService
    {
        Task<List<Education>> ListOfEducations();
        Task AddEducation(Education education);
        Task RemoveEducation(int educationId);
        Task<Education> GetAnEducationById(int educationId);
    }
}
