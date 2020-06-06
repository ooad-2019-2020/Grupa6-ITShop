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
    public class RacunarController : Controller
    {
        private readonly OOADContext _context;

        public RacunarController(OOADContext context)
        {
            _context = context;
        }

        // GET: Racunar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Racunar.ToListAsync());
        }

        // GET: Racunar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var racunar = await _context.Racunar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (racunar == null)
            {
                return NotFound();
            }

            return View(racunar);
        }

        // GET: Racunar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Racunar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("")] Racunar racunar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(racunar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(racunar);
        }

        // GET: Racunar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var racunar = await _context.Racunar.FindAsync(id);
            if (racunar == null)
            {
                return NotFound();
            }
            return View(racunar);
        }

        // POST: Racunar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("")] Racunar racunar)
        {
            if (id != racunar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(racunar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RacunarExists(racunar.Id))
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
            return View(racunar);
        }

        // GET: Racunar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var racunar = await _context.Racunar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (racunar == null)
            {
                return NotFound();
            }

            return View(racunar);
        }

        // POST: Racunar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var racunar = await _context.Racunar.FindAsync(id);
            _context.Racunar.Remove(racunar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RacunarExists(int id)
        {
            return _context.Racunar.Any(e => e.Id == id);
        }
    }
}
