using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlePatrimonios.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace ControlePatrimonios.Controllers
{
    [Authorize]
    public class TipoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        public async Task<IActionResult> Index(string search)
        {
            var context = await _context.TbTipo.ToListAsync();
            var list = from a in context select a;
            if (!String.IsNullOrEmpty(search))
                list = list.Where(t => t.DescricaoTipo.ToLower().Contains(search.ToLower()));
            return View(list.ToList());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTipo = await _context.TbTipo
                .FirstOrDefaultAsync(m => m.IdTipo == id);
            if (tbTipo == null)
            {
                return NotFound();
            }

            return Json(new { success = true, message = tbTipo.DescricaoTipo });
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipo,DescricaoTipo")] TbTipo tbTipo)
        {
            bool exist = false;
            if (ModelState.IsValid)
            {
                foreach (var tipo in await _context.TbTipo.ToArrayAsync())
                {
                    if (tipo.DescricaoTipo.Equals(tbTipo.DescricaoTipo))
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    _context.Add(tbTipo);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = new Message("Tipo", "Tipo criado com sucesso", "success");
                    return View(tbTipo); 
                }
            }
            ViewBag.Message = new Message("Falha", "Descricao de Tipo ja existente", "warning");
            return View(tbTipo);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTipo = await _context.TbTipo.FindAsync(id);
            if (tbTipo == null)
            {
                return NotFound();
            }
            return View(tbTipo);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipo,DescricaoTipo")] TbTipo tbTipo)
        {
            if (id != tbTipo.IdTipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                bool exist = false;
                try
                {
                    foreach (var tipo in await _context.TbTipo.ToArrayAsync())
                    {
                        if (tipo.DescricaoTipo.Equals(tbTipo.DescricaoTipo) && tipo.IdTipo != tbTipo.IdTipo)
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        _context.Update(tbTipo);
                        await _context.SaveChangesAsync();
                        ViewBag.Message = new Message("Tipo", "Tipo editado com sucesso", "success");
                    }
                    else
                    {
                        ViewBag.Message = new Message("Falha", "Esta descriçao ja esta sendo usada em outro Tipo", "warning");
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbTipoExists(tbTipo.IdTipo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View(tbTipo);
            }
            ViewBag.Message = new Message("Falha", "Falha ao editar Tipo", "warning");
            return View(tbTipo);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var tbTipo = await _context.TbTipo.FindAsync(id);
            try
            {
                _context.TbTipo.Remove(tbTipo);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = tbTipo.DescricaoTipo });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = tbTipo.DescricaoTipo });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbTipo = await _context.TbTipo.FindAsync(id);
            foreach (var tbItem in await _context.TbItem.ToListAsync())
            {
                if(tbItem.IdTipo == tbTipo.IdTipo)
                {
                    _context.TbItem.Remove(tbItem);
                }
            }
            _context.TbTipo.Remove(tbTipo);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = tbTipo.DescricaoTipo });
        }

        private bool TbTipoExists(int id)
        {
            return _context.TbTipo.Any(e => e.IdTipo == id);
        }

        public async Task<IActionResult> GetDescricaoTipoById(int id)
        {
            var tbTipo = await _context.TbTipo.FindAsync(id);
            return Json(new { message = tbTipo.DescricaoTipo });
        }
    }
}
