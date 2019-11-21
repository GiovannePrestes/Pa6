﻿using System;
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
    public class SetorController : Controller
    {
        private readonly ControlePatrimoniosContext _context = new ControlePatrimoniosContext();
        

        // GET: Setor
        public async Task<IActionResult> Index()
        {
            var controlePatrimoniosContext = _context.TbSetor.Include(t => t.IdBlocoNavigation);
            return View(await controlePatrimoniosContext.ToListAsync());
        }

        // GET: Setor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbSetor = await _context.TbSetor
                .Include(t => t.IdBlocoNavigation)
                .FirstOrDefaultAsync(m => m.IdSetor == id);
            if (tbSetor == null)
            {
                return NotFound();
            }

            return Json(new {
                            success = true,
                            message = new {
                                            nomeSetor = tbSetor.NomeSetor,
                                            nomeBloco = tbSetor.IdBlocoNavigation.NomeBloco
                                        } });
        }

        // GET: Setor/Create
        public IActionResult Create()
        {
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco");
            return View();
        }

        // POST: Setor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSetor,NomeSetor,IdBloco")] TbSetor tbSetor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbSetor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco", tbSetor.IdBloco);
            return View(tbSetor);
        }

        // GET: Setor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbSetor = await _context.TbSetor.FindAsync(id);
            if (tbSetor == null)
            {
                return NotFound();
            }
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco", tbSetor.IdBloco);
            return View(tbSetor);
        }

        // POST: Setor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSetor,NomeSetor,IdBloco")] TbSetor tbSetor)
        {
            if (id != tbSetor.IdSetor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbSetor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbSetorExists(tbSetor.IdSetor))
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
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco", tbSetor.IdBloco);
            return View(tbSetor);
        }

        // GET: Setor/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var tbSetor = await _context.TbSetor
        //        .Include(t => t.IdBlocoNavigation)
        //        .FirstOrDefaultAsync(m => m.IdSetor == id);
        //    if (tbSetor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tbSetor);
        //}

        // POST: Setor/Delete/5
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbSetor = await _context.TbSetor.FindAsync(id);
            _context.TbSetor.Remove(tbSetor);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = tbSetor.NomeSetor });
        }

        private bool TbSetorExists(int id)
        {
            return _context.TbSetor.Any(e => e.IdSetor == id);
        }

        public async Task<IActionResult> GetNomeSetor(int id)
        {
            var tbSetor = await _context.TbSetor.FindAsync(id);
            return Json(new { message = tbSetor.NomeSetor });
        }
    }
}
