using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
	public class MySkillService : IMySkillService
	{
		private readonly ISkillRepository _skillRepository;
        public MySkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

		public async Task<List<MySkills>> GetListOfMySkills()
		{
			return await _skillRepository.GetListOfMySkills();
		}
	}
}
