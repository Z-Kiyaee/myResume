using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities;

namespace Resume.Presentation.Models.ResumeDbContext;

public class ResumeDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-GT304K5\\MYSQLSERVER;Initial Catalog=Resume;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<MySkills> MySkills { get; set; }
}
