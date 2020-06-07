using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITShop.Data;
using ITShop.Models;

namespace ITShop.Controllers
{
    public class TastaturaController : Controller
    {
        private readonly OOADContext _context;

        public TastaturaController(OOADContext context)
        {
            _context = context;
        }

        // GET: Tastatura
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tastatura.ToListAsync());
        }

        // GET: Tastatura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tastatura = await _context.Tastatura
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tastatura == null)
            {
                return NotFound();
            }

            return View(tastatura);
        }

        // GET: Tastatura/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tastatura/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena,VrstaPrikljucka")] Tastatura tastatura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tastatura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tastatura);
        }

        // GET: Tastatura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tastatura = await _context.Tastatura.FindAsync(id);
            if (tastatura == null)
            {
                return NotFound();
            }
            return View(tastatura);
        }

        // POST: Tastatura/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena,VrstaPrikljucka,Id")] Tastatura tastatura)
        {
            if (id != tastatura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tastatura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TastaturaExists(tastatura.Id))
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
            return View(tastatura);
        }

        // GET: Tastatura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tastatura = await _context.Tastatura
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tastatura == null)
            {
                return NotFound();
            }

            return View(tastatura);
        }

        // POST: Tastatura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tastatura = await _context.Tastatura.FindAsync(id);
            _context.Tastatura.Remove(tastatura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TastaturaExists(int id)
        {
            return _context.Tastatura.Any(e => e.Id == id);
        }
    }
}
