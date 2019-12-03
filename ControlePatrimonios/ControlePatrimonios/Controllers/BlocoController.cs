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
    public class BlocoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();

        public async Task<IActionResult> Index(string search)
        {
            var context = await _context.TbBloco.ToListAsync();
            var list = from a in context select a;
            if(!String.IsNullOrEmpty(search))
                list = list.Where(t => t.NomeBloco.ToLower().Contains(search.ToLower()));
            return View(list.ToList());
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
            bool exist = false;
            if (ModelState.IsValid)
            {
                foreach (var bloco in await _context.TbBloco.ToArrayAsync())
                {
                    if (bloco.NomeBloco.ToLower().Equals(tbBloco.NomeBloco.ToLower()))
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    _context.Add(tbBloco);
                    ViewBag.Message = new Message("Bloco", "O Bloco foi criado com sucesso", "success");
                    await _context.SaveChangesAsync();
                }
            }
            if(exist)
                ViewBag.Message = new Message("Error", "Este Bloco ja foi criado", "error");
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
                bool exist = false;
                try
                {
                    foreach (var bloco in await _context.TbBloco.ToArrayAsync())
                    {
                        if (bloco.NomeBloco.ToLower().Equals(tbBloco.NomeBloco.ToLower()))
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        _context.Update(tbBloco);
                        await _context.SaveChangesAsync();
                        ViewBag.Message = new Message("Bloco", "O Bloco foi editado com sucesso", "success");
                    }
                    else
                    {
                        ViewBag.Message = new Message("Falha", "Este nome ja esta sendo usado em outro Bloco", "warning");
                    }
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
                return View(tbBloco);
            }
            ViewBag.Message = new Message("Erro", "Não foi possível editar este Bloco", "error");
            return View(tbBloco);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var tbBloco = await _context.TbBloco.FindAsync(id);
            try
            {
                _context.TbBloco.Remove(tbBloco);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = tbBloco.NomeBloco });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = tbBloco.NomeBloco });
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var tbBloco = await _context.TbBloco.FindAsync(id);
        //    foreach (var tbSetor in await _context.TbSetor.ToListAsync())
        //    {
        //        if (tbBloco.IdBloco == tbSetor.IdBloco)
        //        {
        //            _context.TbSetor.Remove(tbSetor);
        //            foreach (var tbItem in await _context.TbItem.ToListAsync())
        //            {
        //                if (tbSetor.IdSetor == tbItem.IdSetor)
        //                {
        //                    _context.TbItem.Remove(tbItem);
        //                }
        //            }
        //        }
        //    }
        //    _context.TbBloco.Remove(tbBloco);
        //    await _context.SaveChangesAsync();
        //    return Json(new { success = true, message = tbBloco.NomeBloco });
        //}

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
