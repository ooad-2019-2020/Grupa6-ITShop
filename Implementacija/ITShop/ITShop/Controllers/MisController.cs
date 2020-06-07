using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITShop.Data;

namespace ITShop.Controllers
{
    public class MisController : Controller
    {
        private readonly OOADContext _context;

        public MisController(OOADContext context)
        {
            _context = context;
        }

        // GET: Mis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mis.ToListAsync());
        }

        // GET: Mis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mis = await _context.Mis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mis == null)
            {
                return NotFound();
            }

            return View(mis);
        }

        // GET: Mis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena,VrstaPrikljucka,DuzinaKabla,DodatneTipke")] Mis mis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mis);
        }

        // GET: Mis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mis = await _context.Mis.FindAsync(id);
            if (mis == null)
            {
                return NotFound();
            }
            return View(mis);
        }

        // POST: Mis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena,VrstaPrikljucka,DuzinaKabla,DodatneTipke,Id")] Mis mis)
        {
            if (id != mis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MisExists(mis.Id))
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
            return View(mis);
        }

        // GET: Mis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mis = await _context.Mis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mis == null)
            {
                return NotFound();
            }

            return View(mis);
        }

        // POST: Mis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mis = await _context.Mis.FindAsync(id);
            _context.Mis.Remove(mis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MisExists(int id)
        {
            return _context.Mis.Any(e => e.Id == id);
        }
    }
}
