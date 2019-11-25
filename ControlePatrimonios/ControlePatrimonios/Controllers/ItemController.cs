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
    public class ItemController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        
        public async Task<IActionResult> Index(string searchString)
        {
            var controlePatrimoniosContext = _context.TbItem.Include(t => t.IdEstadoNavigation).Include(t => t.IdSetorNavigation).Include(t => t.IdTipoNavigation);
            //var itens = from a in _context.TbItem.Include(t => t.IdEstadoNavigation).Include(t => t.IdSetorNavigation).Include(t => t.IdTipoNavigation) select a;
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    itens = itens.Where(s => s.Descricao.Contains(searchString));
            //}
            return View(await controlePatrimoniosContext.ToListAsync());
        }
        
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

            return Json(new
            {
                success = true,
                message = new
                {
                    patrimonio = tbItem.Patrimonio,
                    serviceTag = tbItem.ServiceTag,
                    descricao = tbItem.Descricao,
                    dataCriacao = tbItem.DataCriacao.ToString("dd/MM/yyy"),
                    descricaoEstado = tbItem.IdEstadoNavigation.DescricaoEstado,
                    nomeSetor = tbItem.IdSetorNavigation.NomeSetor,
                    descricaoTipo = tbItem.IdTipoNavigation.DescricaoTipo,
                }
            });
        }
        
        public IActionResult Create()
        {
            ViewData["IdEstado"] = new SelectList(_context.TbEstado, "IdEstado", "DescricaoEstado");
            ViewData["IdSetor"] = new SelectList(_context.TbSetor, "IdSetor", "NomeSetor");
            ViewData["IdTipo"] = new SelectList(_context.TbTipo, "IdTipo", "DescricaoTipo");
            return View();
        }
        
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
        
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbItem = await _context.TbItem.FindAsync(id);
            _context.TbItem.Remove(tbItem);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = tbItem.Descricao });
        }

        private bool TbItemExists(int id)
        {
            return _context.TbItem.Any(e => e.IdItem == id);
        }

        public async Task<IActionResult> GetDescricaoItemById(int id)
        {
            var tbItem = await _context.TbItem.FindAsync(id);
            return Json(new { message = tbItem.Descricao });
        }
    }
}
