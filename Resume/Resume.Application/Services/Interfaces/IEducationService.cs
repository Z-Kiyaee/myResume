using Resume.Domain.Models.Entities;

namespace Resume.Application.Services.Interfaces
{
    public interface IEducationService
    {
        Task<List<Education>> ListOfEducations();
        Task AddEducation(Education education);
        Task RemoveEducation(int educationId);
        Task<Education> GetAnEducationById(int educationId);
    }
}
