using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlePatrimonios.Models;
using Microsoft.AspNetCore.Authorization;

namespace ControlePatrimonios.Controllers
{
    [Authorize]
    public class BlocoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbBloco.ToListAsync());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbBloco = await _context.TbBloco
                .FirstOrDefaultAsync(m => m.IdBloco == id);
            if (tbBloco == null)
            {
                return NotFound();
            }

            return Json(new { success = true, message = tbBloco.NomeBloco });
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBloco,NomeBloco")] TbBloco tbBloco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbBloco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbBloco);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbBloco = await _context.TbBloco.FindAsync(id);
            if (tbBloco == null)
            {
                return NotFound();
            }
            return View(tbBloco);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBloco,NomeBloco")] TbBloco tbBloco)
        {
            if (id != tbBloco.IdBloco)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbBloco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbBlocoExists(tbBloco.IdBloco))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tbBloco);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbBloco = await _context.TbBloco.FindAsync(id);
            _context.TbBloco.Remove(tbBloco);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = tbBloco.NomeBloco });
        }

        private bool TbBlocoExists(int id)
        {
            return _context.TbBloco.Any(e => e.IdBloco == id);
        }

        public async Task<IActionResult> GetNomeBlocoById(int id)
        {
            var tbBloco = await _context.TbBloco.FindAsync(id);
            return Json(new { success = true, message = tbBloco.NomeBloco });
        }
    }
}
