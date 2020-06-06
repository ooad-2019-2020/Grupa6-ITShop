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
    public class GrafickaKarticaController : Controller
    {
        private readonly OOADContext _context;

        public GrafickaKarticaController(OOADContext context)
        {
            _context = context;
        }

        // GET: GrafickaKartica
        public async Task<IActionResult> Index()
        {
            return View(await _context.GrafickaKartica.ToListAsync());
        }

        // GET: GrafickaKartica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grafickaKartica = await _context.GrafickaKartica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grafickaKartica == null)
            {
                return NotFound();
            }

            return View(grafickaKartica);
        }

        // GET: GrafickaKartica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GrafickaKartica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProizvodId,KolicinaMemorije,BrojVentilatora")] GrafickaKartica grafickaKartica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grafickaKartica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grafickaKartica);
        }

        // GET: GrafickaKartica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grafickaKartica = await _context.GrafickaKartica.FindAsync(id);
            if (grafickaKartica == null)
            {
                return NotFound();
            }
            return View(grafickaKartica);
        }

        // POST: GrafickaKartica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProizvodId,KolicinaMemorije,BrojVentilatora")] GrafickaKartica grafickaKartica)
        {
            if (id != grafickaKartica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grafickaKartica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrafickaKarticaExists(grafickaKartica.Id))
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
            return View(grafickaKartica);
        }

        // GET: GrafickaKartica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grafickaKartica = await _context.GrafickaKartica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grafickaKartica == null)
            {
                return NotFound();
            }

            return View(grafickaKartica);
        }

        // POST: GrafickaKartica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grafickaKartica = await _context.GrafickaKartica.FindAsync(id);
            _context.GrafickaKartica.Remove(grafickaKartica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrafickaKarticaExists(int id)
        {
            return _context.GrafickaKartica.Any(e => e.Id == id);
        }
    }
}
