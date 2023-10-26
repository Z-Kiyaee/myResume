using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.Models.Entities;


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
    public DbSet<MyLanguages> MyLanguages { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }
}
