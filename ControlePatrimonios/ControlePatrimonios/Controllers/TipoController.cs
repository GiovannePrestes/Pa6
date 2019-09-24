using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlePatrimonios.Models;
using Microsoft.AspNetCore.Authorization;

namespace ControlePatrimonios.Controllers
{
    [Authorize]
    public class TipoController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();

        // GET: Tipo
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbTipo.ToListAsync());
        }

        // GET: Tipo/Details/5
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

            return View(tbTipo);
        }

        // GET: Tipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipo,DescricaoTipo")] TbTipo tbTipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbTipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbTipo);
        }

        // GET: Tipo/Edit/5
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

        // POST: Tipo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                try
                {
                    _context.Update(tbTipo);
                    await _context.SaveChangesAsync();
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
                return RedirectToAction(nameof(Index));
            }
            return View(tbTipo);
        }

        // GET: Tipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            return View(tbTipo);
        }

        // POST: Tipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbTipo = await _context.TbTipo.FindAsync(id);
            _context.TbTipo.Remove(tbTipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbTipoExists(int id)
        {
            return _context.TbTipo.Any(e => e.IdTipo == id);
        }
    }
}
