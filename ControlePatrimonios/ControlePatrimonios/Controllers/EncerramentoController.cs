using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControlePatrimonios.Models;
using Microsoft.AspNetCore.Authorization;

namespace ControlePatrimonios.Controllers
{
    [Authorize]
    public class EncerramentoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();        
        
        public async Task<IActionResult> Index()
        {
            var controlePatrimoniosContext = _context.TbEncerramento.Include(t => t.IdItemNavigation);
            return View(await controlePatrimoniosContext.ToListAsync());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbEncerramento = await _context.TbEncerramento
                .Include(t => t.IdItemNavigation)
                .FirstOrDefaultAsync(m => m.IdEncerramento == id);
            if (tbEncerramento == null)
            {
                return NotFound();
            }

            return Json(new { success = true, message = tbEncerramento.IdItemNavigation.NomeItem });
        }
        
        public IActionResult Create()
        {
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "NomeItem");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEncerramento,IdItem,DataEncerramento,Motivo")] TbEncerramento tbEncerramento)
        {
            if (ModelState.IsValid)
            {
                tbEncerramento.DataEncerramento = DateTime.Now;
                _context.Add(tbEncerramento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "NomeItem", tbEncerramento.IdItem);
            return View(tbEncerramento);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbEncerramento = await _context.TbEncerramento.FindAsync(id);
            if (tbEncerramento == null)
            {
                return NotFound();
            }
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "NomeItem", tbEncerramento.IdItem);
            return View(tbEncerramento);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEncerramento,IdItem,DataEncerramento,Motivo")] TbEncerramento tbEncerramento)
        {
            if (id != tbEncerramento.IdEncerramento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbEncerramento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbEncerramentoExists(tbEncerramento.IdEncerramento))
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
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "NomeItem", tbEncerramento.IdItem);
            return View(tbEncerramento);
        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbEncerramento = await _context.TbEncerramento.FindAsync(id);
            _context.TbEncerramento.Remove(tbEncerramento);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = tbEncerramento.IdItemNavigation.NomeItem });
        }

        private bool TbEncerramentoExists(int id)
        {
            return _context.TbEncerramento.Any(e => e.IdEncerramento == id);
        }

        public async Task<IActionResult> GetNomeItemEncerramentoById(int id)
        {
            var tbEncerramento = await _context.TbEncerramento
                .Include(t => t.IdItemNavigation)
                .FirstOrDefaultAsync(m => m.IdEncerramento == id);
            if (tbEncerramento != null)
                return Json(new { success = true, message = tbEncerramento.IdItemNavigation.NomeItem });
            return Json(new { success = false });
        }
    }
}
