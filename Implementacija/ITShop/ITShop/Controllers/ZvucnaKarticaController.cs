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
    public class ZvucnaKarticaController : Controller
    {
        private readonly OOADContext _context;

        public ZvucnaKarticaController(OOADContext context)
        {
            _context = context;
        }

        // GET: ZvucnaKartica
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZvucnaKartica.ToListAsync());
        }

        // GET: ZvucnaKartica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zvucnaKartica = await _context.ZvucnaKartica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zvucnaKartica == null)
            {
                return NotFound();
            }

            return View(zvucnaKartica);
        }

        // GET: ZvucnaKartica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZvucnaKartica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena")] ZvucnaKartica zvucnaKartica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zvucnaKartica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zvucnaKartica);
        }

        // GET: ZvucnaKartica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zvucnaKartica = await _context.ZvucnaKartica.FindAsync(id);
            if (zvucnaKartica == null)
            {
                return NotFound();
            }
            return View(zvucnaKartica);
        }

        // POST: ZvucnaKartica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena")] ZvucnaKartica zvucnaKartica)
        {
            if (id != zvucnaKartica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zvucnaKartica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZvucnaKarticaExists(zvucnaKartica.Id))
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
            return View(zvucnaKartica);
        }

        // GET: ZvucnaKartica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zvucnaKartica = await _context.ZvucnaKartica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zvucnaKartica == null)
            {
                return NotFound();
            }

            return View(zvucnaKartica);
        }

        // POST: ZvucnaKartica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zvucnaKartica = await _context.ZvucnaKartica.FindAsync(id);
            _context.ZvucnaKartica.Remove(zvucnaKartica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZvucnaKarticaExists(int id)
        {
            return _context.ZvucnaKartica.Any(e => e.Id == id);
        }
    }
}
