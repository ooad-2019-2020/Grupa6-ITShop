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
    public class MemorijaController : Controller
    {
        private readonly OOADContext _context;

        public MemorijaController(OOADContext context)
        {
            _context = context;
        }

        // GET: Memorija
        public async Task<IActionResult> Index()
        {
            return View(await _context.Memorija.ToListAsync());
        }

        // GET: Memorija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memorija = await _context.Memorija
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memorija == null)
            {
                return NotFound();
            }

            return View(memorija);
        }

        // GET: Memorija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Memorija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena,Kolicina")] Memorija memorija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memorija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memorija);
        }

        // GET: Memorija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memorija = await _context.Memorija.FindAsync(id);
            if (memorija == null)
            {
                return NotFound();
            }
            return View(memorija);
        }

        // POST: Memorija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena,Kolicina")] Memorija memorija)
        {
            if (id != memorija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memorija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemorijaExists(memorija.Id))
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
            return View(memorija);
        }

        // GET: Memorija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memorija = await _context.Memorija
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memorija == null)
            {
                return NotFound();
            }

            return View(memorija);
        }

        // POST: Memorija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memorija = await _context.Memorija.FindAsync(id);
            _context.Memorija.Remove(memorija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemorijaExists(int id)
        {
            return _context.Memorija.Any(e => e.Id == id);
        }
    }
}
