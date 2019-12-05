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
        
        public async Task<IActionResult> Index(string search)
        {
            var controlePatrimoniosContext = _context.TbEncerramento.Include(t => t.IdItemNavigation);
            var itens = from a in controlePatrimoniosContext select a;
            if (!String.IsNullOrEmpty(search))
            {
                itens = itens.Where(t=>t.IdItemNavigation.NomeItem.Contains(search));
            }
            return View(await itens.ToListAsync());
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
                if (Verifica(tbEncerramento))
                {
                    tbEncerramento.DataEncerramento = DateTime.Now;
                    _context.Add(tbEncerramento);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = new Message("Encerramento", "Sucesso ao criar encerramento", "success");
                }
                else
                {
                    ViewBag.Message = new Message("Encerramento", "Este item já foi encerrado", "warning");
                }
            }
            else
            {
                ViewBag.Message = new Message("Error", "Falha ao encerrar item", "error");
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
                    if (Verifica(tbEncerramento))
                    {
                        tbEncerramento.DataEncerramento = _context.TbEncerramento.Where(t => t.IdEncerramento == tbEncerramento.IdEncerramento).Select(t => t.DataEncerramento).First();
                        _context.Update(tbEncerramento);
                        await _context.SaveChangesAsync();
                        ViewBag.Message = new Message("Encerramento", "Encerramento editado com sucesso", "success");
                    }
                    else
                    {
                        ViewBag.Message = new Message("Encerramento", "Este item ja foi encerrado", "warning");
                    }
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
            }
            else
            {
                ViewBag.Message = new Message("Error", "Falha ao editar Encerramento", "error");
            }
            ViewData["IdItem"] = new SelectList(_context.TbItem, "IdItem", "NomeItem", tbEncerramento.IdItem);
            return View(tbEncerramento);
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

        private bool Verifica(TbEncerramento tabela)
        {
            var aux = _context.TbEncerramento.Count(t => t.IdItem == tabela.IdItem
                                            && t.IdEncerramento != tabela.IdEncerramento);
            return aux == 0 ? true : false;
        }
    }
}
