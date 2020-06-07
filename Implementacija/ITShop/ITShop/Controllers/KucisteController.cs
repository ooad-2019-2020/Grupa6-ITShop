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
    public class KucisteController : Controller
    {
        private readonly OOADContext _context;

        public KucisteController(OOADContext context)
        {
            _context = context;
        }

        // GET: Kuciste
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kuciste.ToListAsync());
        }

        // GET: Kuciste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kuciste = await _context.Kuciste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kuciste == null)
            {
                return NotFound();
            }

            return View(kuciste);
        }

        // GET: Kuciste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kuciste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena,Zapremina,BrojPortova")] Kuciste kuciste)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kuciste);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kuciste);
        }

        // GET: Kuciste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kuciste = await _context.Kuciste.FindAsync(id);
            if (kuciste == null)
            {
                return NotFound();
            }
            return View(kuciste);
        }

        // POST: Kuciste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena,Zapremina,BrojPortova,Id")] Kuciste kuciste)
        {
            if (id != kuciste.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kuciste);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KucisteExists(kuciste.Id))
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
            return View(kuciste);
        }

        // GET: Kuciste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kuciste = await _context.Kuciste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kuciste == null)
            {
                return NotFound();
            }

            return View(kuciste);
        }

        // POST: Kuciste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kuciste = await _context.Kuciste.FindAsync(id);
            _context.Kuciste.Remove(kuciste);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KucisteExists(int id)
        {
            return _context.Kuciste.Any(e => e.Id == id);
        }
    }
}
