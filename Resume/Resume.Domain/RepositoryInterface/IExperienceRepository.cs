using Resume.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
	public interface IExperienceRepository
	{
		Task<List<Experience>> GetListOfExperience();
	}
}
