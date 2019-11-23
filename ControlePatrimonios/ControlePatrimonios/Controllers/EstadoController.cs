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
    public class EstadoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbEstado.ToListAsync());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbEstado = await _context.TbEstado
                .FirstOrDefaultAsync(m => m.IdEstado == id);
            if (tbEstado == null)
            {
                return NotFound();
            }

            return Json(new { success = true, message = tbEstado.DescricaoEstado });
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEstado,DescricaoEstado")] TbEstado tbEstado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbEstado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbEstado);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbEstado = await _context.TbEstado.FindAsync(id);
            if (tbEstado == null)
            {
                return NotFound();
            }
            return View(tbEstado);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEstado,DescricaoEstado")] TbEstado tbEstado)
        {
            if (id != tbEstado.IdEstado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbEstado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbEstadoExists(tbEstado.IdEstado))
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
            return View(tbEstado);
        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbEstado = await _context.TbEstado.FindAsync(id);
            _context.TbEstado.Remove(tbEstado);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = tbEstado.DescricaoEstado });
        }

        private bool TbEstadoExists(int id)
        {
            return _context.TbEstado.Any(e => e.IdEstado == id);
        }

        public async Task<IActionResult> GetDescricaoEstadoById(int id)
        {
            var tbEstado = await _context.TbEstado.FindAsync(id);
            return Json(new { message = tbEstado.DescricaoEstado });
        }
    }
}
