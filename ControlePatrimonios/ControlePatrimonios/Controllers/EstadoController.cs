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
    public class EstadoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        
        public async Task<IActionResult> Index(string search)
        {
            var context = await _context.TbEstado.ToListAsync();
            var list = from a in context select a;
            if (!String.IsNullOrEmpty(search))
                list = list.Where(t => t.DescricaoEstado.ToLower().Contains(search.ToLower()));
            return View(list.ToList());
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
            bool exist = false;
            if (ModelState.IsValid)
            {
                foreach (var estado in await _context.TbEstado.ToArrayAsync())
                {
                    if (estado.DescricaoEstado.ToLower().Equals(tbEstado.DescricaoEstado.ToLower()))
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    _context.Add(tbEstado);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = new Message("Estado", "Estado criado com Sucesso", "success");
                    return View(tbEstado); 
                }
            }
            ViewBag.Message = new Message("Falha", "Esta descriçao ja esta sendo usada por outro Estado", "warning");
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
                bool exist = false;
                try
                {
                    foreach (var estado in await _context.TbEstado.ToArrayAsync())
                    {
                        if (estado.DescricaoEstado.ToLower().Equals(tbEstado.DescricaoEstado.ToLower()))
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        _context.Update(tbEstado);
                        await _context.SaveChangesAsync();
                        ViewBag.Message = new Message("Estado", "Estado editado com sucesso", "success");
                    }
                    else
                    {
                        ViewBag.Message = new Message("Estado", "Esta descriçao esta sendo usada por outro Estado", "warning");
                    }
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
                return View(tbEstado);
            }
            ViewBag.Message = new Message("Falha", "Erro ao editar Estado", "warning");
            return View(tbEstado);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var tbEstado = await _context.TbEstado.FindAsync(id);
            try
            {
                _context.TbEstado.Remove(tbEstado);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = tbEstado.DescricaoEstado });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = tbEstado.DescricaoEstado });
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var tbEstado = await _context.TbEstado.FindAsync(id);
        //    foreach (var tbItem in await _context.TbItem.ToListAsync())
        //    {
        //        if (tbEstado.IdEstado == tbItem.IdEstado)
        //        {
        //            _context.TbItem.Remove(tbItem);
        //        }
        //    }
        //    _context.TbEstado.Remove(tbEstado);
        //    await _context.SaveChangesAsync();
        //    return Json(new { success = true, message = tbEstado.DescricaoEstado });
        //}

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
