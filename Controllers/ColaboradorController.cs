﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalPietra.Models;

namespace ProjetoFinalPietra.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly Contexto _context;

        public ColaboradorController(Contexto context)
        {
            _context = context;
        }

        // GET: Colaborador
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Colaborador.Include(c => c.Cidade).Include(c => c.Tipocolaborador);
            return View(await contexto.ToListAsync());
        }

        // GET: Colaborador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Colaborador == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaborador
                .Include(c => c.Cidade)
                .Include(c => c.Tipocolaborador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return View(colaborador);
        }

        // GET: Colaborador/Create
        public IActionResult Create()
        {
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome");
            ViewData["TipocolaboradorId"] = new SelectList(_context.Tipocolaborador, "Id", "TipoColaboradorNome");
            return View();
        }

        // POST: Colaborador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ColaboradorNome,ColaboradorCpf,ClienteSexo,ColaboradorTelefone,CidadeId,TipocolaboradorId")] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(colaborador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome", colaborador.CidadeId);
            ViewData["TipocolaboradorId"] = new SelectList(_context.Tipocolaborador, "Id", "TipoColaboradorNome", colaborador.TipocolaboradorId);
            return View(colaborador);
        }

        // GET: Colaborador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Colaborador == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaborador.FindAsync(id);
            if (colaborador == null)
            {
                return NotFound();
            }
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome", colaborador.CidadeId);
            ViewData["TipocolaboradorId"] = new SelectList(_context.Tipocolaborador, "Id", "TipoColaboradorNome", colaborador.TipocolaboradorId);
            return View(colaborador);
        }

        // POST: Colaborador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ColaboradorNome,ColaboradorCpf,ClienteSexo,ColaboradorTelefone,CidadeId,TipocolaboradorId")] Colaborador colaborador)
        {
            if (id != colaborador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(colaborador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColaboradorExists(colaborador.Id))
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
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome", colaborador.CidadeId);
            ViewData["TipocolaboradorId"] = new SelectList(_context.Tipocolaborador, "Id", "TipoColaboradorNome", colaborador.TipocolaboradorId);
            return View(colaborador);
        }

        // GET: Colaborador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Colaborador == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaborador
                .Include(c => c.Cidade)
                .Include(c => c.Tipocolaborador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return View(colaborador);
        }

        // POST: Colaborador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Colaborador == null)
            {
                return Problem("Entity set 'Contexto.Colaborador'  is null.");
            }
            var colaborador = await _context.Colaborador.FindAsync(id);
            if (colaborador != null)
            {
                _context.Colaborador.Remove(colaborador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColaboradorExists(int id)
        {
          return (_context.Colaborador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
