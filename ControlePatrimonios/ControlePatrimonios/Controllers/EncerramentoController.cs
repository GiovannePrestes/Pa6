using System;
using System.Collections.Generic;
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

        // GET: Encerramento
        public async Task<IActionResult> Index()
        {
            var controlePatrimoniosContext = _context.TbEncerramento.Include(t => t.IdItemNavigation);
            return View(await controlePatrimoniosContext.ToListAsync());
        }

        // GET: Encerramento/Details/5
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

            return View(tbEncerramento);
        }

        // GET: Encerramento/Create
        public IActionResult Create()
        {
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "Descricao");
            return View();
        }

        // POST: Encerramento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEncerramento,IdItem,DataEncerramento,Motivo")] TbEncerramento tbEncerramento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbEncerramento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "Descricao", tbEncerramento.IdItem);
            return View(tbEncerramento);
        }

        // GET: Encerramento/Edit/5
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
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "Descricao", tbEncerramento.IdItem);
            return View(tbEncerramento);
        }

        // POST: Encerramento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "Descricao", tbEncerramento.IdItem);
            return View(tbEncerramento);
        }

        // GET: Encerramento/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            return View(tbEncerramento);
        }

        // POST: Encerramento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbEncerramento = await _context.TbEncerramento.FindAsync(id);
            _context.TbEncerramento.Remove(tbEncerramento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbEncerramentoExists(int id)
        {
            return _context.TbEncerramento.Any(e => e.IdEncerramento == id);
        }
    }
}
