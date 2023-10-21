using Resume.Domain.Models.Entities;

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
