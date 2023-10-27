using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interfaces;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using Resume.Presentation.Models.ResumeDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Repositories

builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();

#endregion

#region Services

builder.Services.AddScoped<IContactUsService, ContactUsService>();

#endregion
builder.Services.AddDbContext<ResumeDbContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
