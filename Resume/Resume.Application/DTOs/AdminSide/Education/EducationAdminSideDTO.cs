using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.AdminSide.Education
{
    public class EducationAdminSideDTO
    {
        public int Id { get; set; }
        public string EducatationTitle { get; set; }
        public string EducationDuration { get; set; }
        public string Description { get; set; }
    }
}
