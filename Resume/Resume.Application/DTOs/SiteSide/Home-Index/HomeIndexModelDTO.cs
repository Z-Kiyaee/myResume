using Resume.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.SiteSide.Home_Index
{
	public record HomeIndexModelDTO
	{
        public List<Resume.Domain.Models.Entities.Education> Educations { get; set; }
        public List<Resume.Domain.Models.Entities.MySkills> Skills { get; set; }
        public List<Resume.Domain.Models.Entities.Experience> Experiences { get; set; }
    }
}
