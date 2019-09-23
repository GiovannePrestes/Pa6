using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControlePatrimonios.Models;

namespace ControlePatrimonios.Controllers
{
    public class BlocoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        // GET: Bloco
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbBloco.ToListAsync());
        }

        // GET: Bloco/Details/5
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

            return View(tbBloco);
        }

        // GET: Bloco/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bloco/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Bloco/Edit/5
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

        // POST: Bloco/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Bloco/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            return View(tbBloco);
        }

        // POST: Bloco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbBloco = await _context.TbBloco.FindAsync(id);
            _context.TbBloco.Remove(tbBloco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbBlocoExists(int id)
        {
            return _context.TbBloco.Any(e => e.IdBloco == id);
        }
    }
}
