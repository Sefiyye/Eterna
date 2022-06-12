using Eterna.DAL;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
            private readonly AppDbContext _context;

            public ServiceController(AppDbContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Index()
            {
                ServiceVM model = new ServiceVM
                {  
                    Cards= await _context.Cards.ToListAsync(),
                    Statistics = await _context.Statistics.FirstOrDefaultAsync(),
                    News = await _context.News.FirstOrDefaultAsync(),
                    Contacts = await _context.Contacts.ToListAsync()

                };
                return View(model);
            }
        }
    }

