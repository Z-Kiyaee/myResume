using Resume.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
	public interface IMySkillService
	{
		Task<List<MySkills>> GetListOfMySkills();
	}
}
