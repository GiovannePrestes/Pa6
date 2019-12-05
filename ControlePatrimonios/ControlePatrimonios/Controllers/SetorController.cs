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
        
        
        public async Task<IActionResult> Index(string search)
        {
            var controlePatrimoniosContext = _context.TbSetor.Include(t => t.IdBlocoNavigation);
            var itens = from a in controlePatrimoniosContext select a;
            if (!String.IsNullOrEmpty(search))
            {
                itens = itens.Where(t => t.NomeSetor.ToLower().Contains(search.ToLower()));
            }
            return View(await itens.ToListAsync());
        }
        
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
        
        public IActionResult Create()
        {
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSetor,NomeSetor,IdBloco")] TbSetor tbSetor)
        {
            if (ModelState.IsValid)
            {
                if (Verifica(tbSetor))
                {
                    _context.Add(tbSetor);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = new Message("Setor", "Setor criado com sucesso", "success");
                }
                else
                {
                    ViewBag.Message = new Message("Setor", "Este Setor ja foi criado", "warning");
                }
            }
            else
            {
                ViewBag.Message = new Message("Error", "Nao foi possivel criar o Setor", "error");
            }
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco", tbSetor.IdBloco);
            return View(tbSetor);
        }
        
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
                    if (Verifica(tbSetor))
                    {
                        _context.Update(tbSetor);
                        await _context.SaveChangesAsync();
                        ViewBag.Message = new Message("Setor", "Setor editado com sucesso", "success");
                    }
                    else
                    {
                        ViewBag.Message = new Message("Setor", "Este setor ja foi criado", "warning");
                    }
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
            }
            else
            {
                ViewBag.Message = new Message("Error", "Não foi possivel editar o Setor", "error");
            }
            ViewData["IdBloco"] = new SelectList(_context.TbBloco, "IdBloco", "NomeBloco", tbSetor.IdBloco);
            return View(tbSetor);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var tbSetor = await _context.TbSetor.FindAsync(id);
            try
            {
                _context.TbSetor.Remove(tbSetor);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = tbSetor.NomeSetor });
            }catch(Exception e)
            {
                return Json(new { success = false, message = tbSetor.NomeSetor });
            }
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

        private bool Verifica(TbSetor tabela)
        {
            var aux = _context.TbSetor.Count(t => t.NomeSetor == tabela.NomeSetor 
                                            && t.IdBloco == tabela.IdBloco
                                            && t.IdSetor != tabela.IdSetor);
            return aux == 0 ? true : false;
        }
    }
}
