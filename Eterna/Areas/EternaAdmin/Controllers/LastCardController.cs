using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eterna.Areas.EternaAdmin.Controllers
{
    [Area("EternaAdmin")]
    public class LastCardController :Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public LastCardController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<LastCard> lastCards = await _context.LastCards.ToListAsync();
            return View(lastCards);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Detail(int id)
        {
            LastCard lastCards = await _context.LastCards.FirstOrDefaultAsync(c => c.Id == id);
            if (lastCards == null) return NotFound();

            return View(lastCards);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(LastCard lastCard)
        {
            if (!ModelState.IsValid) return View();
            await _context.AddAsync(lastCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            LastCard lastCard = await _context.LastCards.FirstOrDefaultAsync(c => c.Id == id);
            if (lastCard == null) return NotFound();

            return View(lastCard);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, LastCard lastCard)
        {
            LastCard existedlastCard = await _context.LastCards.FirstOrDefaultAsync(c => c.Id == id);
            if (existedlastCard == null) return NotFound();

            if (existedlastCard.Id != id) return BadRequest();

            existedlastCard.Id = lastCard.Id;
            existedlastCard.Title = lastCard.Title;
            existedlastCard.Subtitle = lastCard.Subtitle;
            existedlastCard.Icon = lastCard.Icon;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            LastCard lastCard = await _context.LastCards.FirstOrDefaultAsync(c => c.Id == id);
            if (lastCard == null) return NotFound();
            return View(lastCard);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteLastCard(int id)
        {
            LastCard lastCard = await _context.LastCards.FirstOrDefaultAsync(c => c.Id == id);
            _context.LastCards.Remove(lastCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
