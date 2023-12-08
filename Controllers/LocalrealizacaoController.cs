using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalPietra.Models;

namespace ProjetoFinalPietra.Controllers
{
    public class LocalrealizacaoController : Controller
    {
        private readonly Contexto _context;

        public LocalrealizacaoController(Contexto context)
        {
            _context = context;
        }

        // GET: Localrealizacao
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Localrealizacao.Include(l => l.Cidade);
            return View(await contexto.ToListAsync());
        }

        // GET: Localrealizacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Localrealizacao == null)
            {
                return NotFound();
            }

            var localrealizacao = await _context.Localrealizacao
                .Include(l => l.Cidade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localrealizacao == null)
            {
                return NotFound();
            }

            return View(localrealizacao);
        }

        // GET: Localrealizacao/Create
        public IActionResult Create()
        {
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome");
            return View();
        }

        // POST: Localrealizacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LocalNome,CidadeId")] Localrealizacao localrealizacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localrealizacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome", localrealizacao.CidadeId);
            return View(localrealizacao);
        }

        // GET: Localrealizacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Localrealizacao == null)
            {
                return NotFound();
            }

            var localrealizacao = await _context.Localrealizacao.FindAsync(id);
            if (localrealizacao == null)
            {
                return NotFound();
            }
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome", localrealizacao.CidadeId);
            return View(localrealizacao);
        }

        // POST: Localrealizacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LocalNome,CidadeId")] Localrealizacao localrealizacao)
        {
            if (id != localrealizacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localrealizacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalrealizacaoExists(localrealizacao.Id))
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
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "CidadeNome", localrealizacao.CidadeId);
            return View(localrealizacao);
        }

        // GET: Localrealizacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Localrealizacao == null)
            {
                return NotFound();
            }

            var localrealizacao = await _context.Localrealizacao
                .Include(l => l.Cidade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localrealizacao == null)
            {
                return NotFound();
            }

            return View(localrealizacao);
        }

        // POST: Localrealizacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Localrealizacao == null)
            {
                return Problem("Entity set 'Contexto.Localrealizacao'  is null.");
            }
            var localrealizacao = await _context.Localrealizacao.FindAsync(id);
            if (localrealizacao != null)
            {
                _context.Localrealizacao.Remove(localrealizacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalrealizacaoExists(int id)
        {
          return (_context.Localrealizacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
