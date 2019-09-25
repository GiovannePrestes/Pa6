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
    public class ItemController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        // GET: Item
        public async Task<IActionResult> Index()
        {
            var controlePatrimoniosContext = _context.TbItem.Include(t => t.IdEstadoNavigation).Include(t => t.IdSetorNavigation).Include(t => t.IdTipoNavigation);
            return View(await controlePatrimoniosContext.ToListAsync());
        }

        // GET: Item/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbItem = await _context.TbItem
                .Include(t => t.IdEstadoNavigation)
                .Include(t => t.IdSetorNavigation)
                .Include(t => t.IdTipoNavigation)
                .FirstOrDefaultAsync(m => m.IdItem == id);
            if (tbItem == null)
            {
                return NotFound();
            }

            return View(tbItem);
        }

        // GET: Item/Create
        public IActionResult Create()
        {
            ViewData["IdEstado"] = new SelectList(_context.TbEstado, "IdEstado", "DescricaoEstado");
            ViewData["IdSetor"] = new SelectList(_context.TbSetor, "IdSetor", "NomeSetor");
            ViewData["IdTipo"] = new SelectList(_context.TbTipo, "IdTipo", "DescricaoTipo");
            return View();
        }

        // POST: Item/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdItem,IdSetor,IdTipo,IdEstado,Patrimonio,ServiceTag,Descricao,DataCriacao")] TbItem tbItem)
        {
            if (ModelState.IsValid)
            {
                tbItem.DataCriacao = DateTime.Now;
                _context.Add(tbItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEstado"] = new SelectList(_context.TbEstado, "IdEstado", "DescricaoEstado", tbItem.IdEstado);
            ViewData["IdSetor"] = new SelectList(_context.TbSetor, "IdSetor", "NomeSetor", tbItem.IdSetor);
            ViewData["IdTipo"] = new SelectList(_context.TbTipo, "IdTipo", "DescricaoTipo", tbItem.IdTipo);
            return View(tbItem);
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbItem = await _context.TbItem.FindAsync(id);
            if (tbItem == null)
            {
                return NotFound();
            }
            ViewData["IdEstado"] = new SelectList(_context.TbEstado, "IdEstado", "DescricaoEstado", tbItem.IdEstado);
            ViewData["IdSetor"] = new SelectList(_context.TbSetor, "IdSetor", "NomeSetor", tbItem.IdSetor);
            ViewData["IdTipo"] = new SelectList(_context.TbTipo, "IdTipo", "DescricaoTipo", tbItem.IdTipo);
            return View(tbItem);
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdItem,IdSetor,IdTipo,IdEstado,Patrimonio,ServiceTag,Descricao,DataCriacao")] TbItem tbItem)
        {
            if (id != tbItem.IdItem)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbItemExists(tbItem.IdItem))
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
            ViewData["IdEstado"] = new SelectList(_context.TbEstado, "IdEstado", "DescricaoEstado", tbItem.IdEstado);
            ViewData["IdSetor"] = new SelectList(_context.TbSetor, "IdSetor", "NomeSetor", tbItem.IdSetor);
            ViewData["IdTipo"] = new SelectList(_context.TbTipo, "IdTipo", "DescricaoTipo", tbItem.IdTipo);
            return View(tbItem);
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbItem = await _context.TbItem
                .Include(t => t.IdEstadoNavigation)
                .Include(t => t.IdSetorNavigation)
                .Include(t => t.IdTipoNavigation)
                .FirstOrDefaultAsync(m => m.IdItem == id);
            if (tbItem == null)
            {
                return NotFound();
            }

            return View(tbItem);
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbItem = await _context.TbItem.FindAsync(id);
            _context.TbItem.Remove(tbItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbItemExists(int id)
        {
            return _context.TbItem.Any(e => e.IdItem == id);
        }
    }
}
