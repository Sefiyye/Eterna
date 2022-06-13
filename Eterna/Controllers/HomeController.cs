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
        public async Task<IActionResult> Home()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Clients = await _context.Clients.FirstOrDefaultAsync(),
                Rules = await _context.Rules.FirstOrDefaultAsync(),
                HomeCards = await _context.HomeCards.ToListAsync(),
                LastCards = await _context.LastCards.ToListAsync(),
                ClientsImages = await _context.ClientsImages.ToListAsync(),
            };
            return View(model);
        }
    }
}
