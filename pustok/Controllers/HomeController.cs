using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pustok.Context;
using System.Diagnostics;

namespace pustok.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            using ApplicationDbContext context = new ApplicationDbContext();
            var sliders = await context.Sliders.ToListAsync();

            return View(sliders);
        }
    }
}