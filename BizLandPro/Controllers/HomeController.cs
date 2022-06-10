using BizLandPro.DAL;
using BizLandPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BizLandPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }
      public async Task<IActionResult> Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                projects = await db.Projects.ToListAsync(),
                projectCategories = await db.ProjectCategories.ToListAsync()
            };
            return View(hvm);
        }
    }
}
