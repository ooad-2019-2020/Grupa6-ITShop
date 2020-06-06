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
    public class KupacController : Controller
    {
        private readonly OOADContext _context;

        public KupacController(OOADContext context)
        {
            _context = context;
        }

        // GET: Kupac
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kupac.ToListAsync());
        }

        // GET: Kupac/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupac = await _context.Kupac
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kupac == null)
            {
                return NotFound();
            }

            return View(kupac);
        }

        // GET: Kupac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kupac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("")] Kupac kupac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kupac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kupac);
        }

        // GET: Kupac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupac = await _context.Kupac.FindAsync(id);
            if (kupac == null)
            {
                return NotFound();
            }
            return View(kupac);
        }

        // POST: Kupac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("")] Kupac kupac)
        {
            if (id != kupac.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kupac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KupacExists(kupac.Id))
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
            return View(kupac);
        }

        // GET: Kupac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupac = await _context.Kupac
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kupac == null)
            {
                return NotFound();
            }

            return View(kupac);
        }

        // POST: Kupac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kupac = await _context.Kupac.FindAsync(id);
            _context.Kupac.Remove(kupac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KupacExists(int id)
        {
            return _context.Kupac.Any(e => e.Id == id);
        }
    }
}
