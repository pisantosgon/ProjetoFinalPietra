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
    public class ProcedimentorealizadoController : Controller
    {
        private readonly Contexto _context;

        public ProcedimentorealizadoController(Contexto context)
        {
            _context = context;
        }

        // GET: Procedimentorealizado
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Procedimentorealizado.Include(p => p.Cliente).Include(p => p.Colaborador).Include(p => p.Localrealizacao).Include(p => p.Procedimento);
            return View(await contexto.ToListAsync());
        }

        // GET: Procedimentorealizado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Procedimentorealizado == null)
            {
                return NotFound();
            }

            var procedimentorealizado = await _context.Procedimentorealizado
                .Include(p => p.Cliente)
                .Include(p => p.Colaborador)               
                .Include(p => p.Localrealizacao)
                .Include(p => p.Procedimento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procedimentorealizado == null)
            {
                return NotFound();
            }

            return View(procedimentorealizado);
        }

        // GET: Procedimentorealizado/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome");
            ViewData["ColaboradorId"] = new SelectList(_context.Colaborador, "Id", "ColaboradorNome");
            ViewData["LocalrealizacaoId"] = new SelectList(_context.Localrealizacao, "Id", "LocalNome");
            ViewData["ProcedimentoId"] = new SelectList(_context.Procedimento, "Id", "ProcedimentoNome");
            return View();
        }

        // POST: Procedimentorealizado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClienteId,ProcedimentoId,ColaboradorId,LocalrealizacaoId,DataRealizacao,ObservacaoRealizacao")] Procedimentorealizado procedimentorealizado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(procedimentorealizado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome", procedimentorealizado.ClienteId);
            ViewData["ColaboradorId"] = new SelectList(_context.Colaborador, "Id", "ColaboradorNome", procedimentorealizado.ColaboradorId);
            ViewData["LocalrealizacaoId"] = new SelectList(_context.Localrealizacao, "Id", "LocalNome", procedimentorealizado.LocalrealizacaoId);
            ViewData["ProcedimentoId"] = new SelectList(_context.Procedimento, "Id", "ProcedimentoNome", procedimentorealizado.ProcedimentoId);
            return View(procedimentorealizado);
        }

        // GET: Procedimentorealizado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Procedimentorealizado == null)
            {
                return NotFound();
            }

            var procedimentorealizado = await _context.Procedimentorealizado.FindAsync(id);
            if (procedimentorealizado == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome", procedimentorealizado.ClienteId);
            ViewData["ColaboradorId"] = new SelectList(_context.Colaborador, "Id", "ColaboradorNome", procedimentorealizado.ColaboradorId);
            ViewData["LocalrealizacaoId"] = new SelectList(_context.Localrealizacao, "Id", "LocalNome", procedimentorealizado.LocalrealizacaoId);
            ViewData["ProcedimentoId"] = new SelectList(_context.Procedimento, "Id", "ProcedimentoNome", procedimentorealizado.ProcedimentoId);
            return View(procedimentorealizado);
        }

        // POST: Procedimentorealizado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteId,ProcedimentoId,ColaboradorId,LocalrealizacaoId,DataRealizacao,ObservacaoRealizacao")] Procedimentorealizado procedimentorealizado)
        {
            if (id != procedimentorealizado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(procedimentorealizado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcedimentorealizadoExists(procedimentorealizado.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome", procedimentorealizado.ClienteId);
            ViewData["ColaboradorId"] = new SelectList(_context.Colaborador, "Id", "ColaboradorNome", procedimentorealizado.ColaboradorId);
            ViewData["LocalrealizacaoId"] = new SelectList(_context.Localrealizacao, "Id", "LocalNome", procedimentorealizado.LocalrealizacaoId);
            ViewData["ProcedimentoId"] = new SelectList(_context.Procedimento, "Id", "ProcedimentoNome", procedimentorealizado.ProcedimentoId);
            return View(procedimentorealizado);
        }

        // GET: Procedimentorealizado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Procedimentorealizado == null)
            {
                return NotFound();
            }

            var procedimentorealizado = await _context.Procedimentorealizado
                .Include(p => p.Cliente)
                .Include(p => p.Colaborador)
                .Include(p => p.Localrealizacao)
                .Include(p => p.Procedimento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procedimentorealizado == null)
            {
                return NotFound();
            }

            return View(procedimentorealizado);
        }

        // POST: Procedimentorealizado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Procedimentorealizado == null)
            {
                return Problem("Entity set 'Contexto.Procedimentorealizado'  is null.");
            }
            var procedimentorealizado = await _context.Procedimentorealizado.FindAsync(id);
            if (procedimentorealizado != null)
            {
                _context.Procedimentorealizado.Remove(procedimentorealizado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcedimentorealizadoExists(int id)
        {
          return (_context.Procedimentorealizado?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Imprimir(int? id)
        {
            if (id == null || _context.Procedimentorealizado == null)
            {
                return NotFound();
            }

            var resultado = await _context.Procedimentorealizado
                    .Include(p => p.Cliente)
                    .Include(p => p.Colaborador)
                     .Include(p => p.Colaborador.Tipocolaborador)
                    .Include(p => p.Localrealizacao)
                    .Include(p => p.Procedimento)
                    .FirstOrDefaultAsync(m => m.Id == id);

            if (resultado == null)
            {
                return NotFound();
            }

            return View(resultado);

        }
    }
}
