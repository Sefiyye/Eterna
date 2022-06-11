using Eterna.DAL;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
            private readonly AppDbContext _context;

            public HomeController(AppDbContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Index()
            {
                HomeVM model = new HomeVM
                {
                   
                    Settings = await _context.Settings.FirstOrDefaultAsync()
                };
                return View(model);
            }
        }
    }

