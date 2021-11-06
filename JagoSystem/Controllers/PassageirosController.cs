using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JagoSystem.Models;

namespace JagoSystem.Controllers
{
    public class PassageirosController : Controller
    {
        private readonly SystemContext _context;

        public PassageirosController(SystemContext context)
        {
            _context = context;
        }

        // GET: Passageiros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passageiros.ToListAsync());
        }

        // GET: Passageiros/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passageiro = await _context.Passageiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passageiro == null)
            {
                return NotFound();
            }

            return View(passageiro);
        }

        // GET: Passageiros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Passageiros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,RG,CPF,Celular,Email")] Passageiro passageiro)
        {
            if (ModelState.IsValid)
            {
                passageiro.Id = Guid.NewGuid();
                _context.Add(passageiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passageiro);
        }

        // GET: Passageiros/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passageiro = await _context.Passageiros.FindAsync(id);
            if (passageiro == null)
            {
                return NotFound();
            }
            return View(passageiro);
        }

        // POST: Passageiros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,RG,CPF,Celular,Email")] Passageiro passageiro)
        {
            if (id != passageiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passageiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassageiroExists(passageiro.Id))
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
            return View(passageiro);
        }

        // GET: Passageiros/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passageiro = await _context.Passageiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passageiro == null)
            {
                return NotFound();
            }

            return View(passageiro);
        }

        // POST: Passageiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var passageiro = await _context.Passageiros.FindAsync(id);
            _context.Passageiros.Remove(passageiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassageiroExists(Guid id)
        {
            return _context.Passageiros.Any(e => e.Id == id);
        }
    }
}
