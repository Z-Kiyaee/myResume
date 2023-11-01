using Resume.Application.DTOs.AdminSide.Education;
using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Interfaces
{
    public interface IEducationService
    {
		Task<List<Education>> GetListOfEducations();
        Task<List<EducationAdminSideDTO>> GetListOfEducationForAdminPanel();

        /*				Task<List<Education>> ListOfEducations();
                        Task AddEducation(Education education);
                        Task RemoveEducation(int educationId);
                        Task<Education> GetAnEducationById(int educationId);*/
    }
}
