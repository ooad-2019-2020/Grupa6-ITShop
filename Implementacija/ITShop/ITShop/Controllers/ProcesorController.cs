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
    public class ProcesorController : Controller
    {
        private readonly OOADContext _context;

        public ProcesorController(OOADContext context)
        {
            _context = context;
        }

        // GET: Procesor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Procesor.ToListAsync());
        }

        // GET: Procesor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesor = await _context.Procesor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procesor == null)
            {
                return NotFound();
            }

            return View(procesor);
        }

        // GET: Procesor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Procesor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena,BrojJezgra,BrzinaJezgra")] Procesor procesor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(procesor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(procesor);
        }

        // GET: Procesor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesor = await _context.Procesor.FindAsync(id);
            if (procesor == null)
            {
                return NotFound();
            }
            return View(procesor);
        }

        // POST: Procesor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena,BrojJezgra,BrzinaJezgra")] Procesor procesor)
        {
            if (id != procesor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(procesor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcesorExists(procesor.Id))
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
            return View(procesor);
        }

        // GET: Procesor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesor = await _context.Procesor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procesor == null)
            {
                return NotFound();
            }

            return View(procesor);
        }

        // POST: Procesor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var procesor = await _context.Procesor.FindAsync(id);
            _context.Procesor.Remove(procesor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcesorExists(int id)
        {
            return _context.Procesor.Any(e => e.Id == id);
        }
    }
}
