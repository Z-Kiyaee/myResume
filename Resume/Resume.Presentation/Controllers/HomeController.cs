using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models;
using Resume.Domain.Models.Entities;
using Resume.Presentation.Models.ResumeDbContext;
using System.Diagnostics;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
		private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
		{
            var model = await _homeService.FillHomeModel();

			return View(model);
        }

    }
}