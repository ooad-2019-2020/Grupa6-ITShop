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
    public class KupovinaProizvodaController : Controller
    {
        private readonly OOADContext _context;

        public KupovinaProizvodaController(OOADContext context)
        {
            _context = context;
        }

        // GET: KupovinaProizvoda
        public async Task<IActionResult> Index()
        {
            var oOADContext = _context.KupovinaProizvod.Include(k => k.Kupovina).Include(k => k.Proizvod);
            return View(await oOADContext.ToListAsync());
        }

        // GET: KupovinaProizvoda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupovinaProizvoda = await _context.KupovinaProizvod
                .Include(k => k.Kupovina)
                .Include(k => k.Proizvod)
                .FirstOrDefaultAsync(m => m.ProizvodId == id);
            if (kupovinaProizvoda == null)
            {
                return NotFound();
            }

            return View(kupovinaProizvoda);
        }

        // GET: KupovinaProizvoda/Create
        public IActionResult Create()
        {
            ViewData["KupovinaId"] = new SelectList(_context.Kupovina, "Id", "Id");
            ViewData["ProizvodId"] = new SelectList(_context.Proizvod, "Id", "Naziv");
            return View();
        }

        // POST: KupovinaProizvoda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProizvodId,KupovinaId")] KupovinaProizvoda kupovinaProizvoda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kupovinaProizvoda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KupovinaId"] = new SelectList(_context.Kupovina, "Id", "Id", kupovinaProizvoda.KupovinaId);
            ViewData["ProizvodId"] = new SelectList(_context.Proizvod, "Id", "Naziv", kupovinaProizvoda.ProizvodId);
            return View(kupovinaProizvoda);
        }

        // GET: KupovinaProizvoda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupovinaProizvoda = await _context.KupovinaProizvod.FindAsync(id);
            if (kupovinaProizvoda == null)
            {
                return NotFound();
            }
            ViewData["KupovinaId"] = new SelectList(_context.Kupovina, "Id", "Id", kupovinaProizvoda.KupovinaId);
            ViewData["ProizvodId"] = new SelectList(_context.Proizvod, "Id", "Naziv", kupovinaProizvoda.ProizvodId);
            return View(kupovinaProizvoda);
        }

        // POST: KupovinaProizvoda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProizvodId,KupovinaId")] KupovinaProizvoda kupovinaProizvoda)
        {
            if (id != kupovinaProizvoda.ProizvodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kupovinaProizvoda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KupovinaProizvodaExists(kupovinaProizvoda.ProizvodId))
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
            ViewData["KupovinaId"] = new SelectList(_context.Kupovina, "Id", "Id", kupovinaProizvoda.KupovinaId);
            ViewData["ProizvodId"] = new SelectList(_context.Proizvod, "Id", "Naziv", kupovinaProizvoda.ProizvodId);
            return View(kupovinaProizvoda);
        }

        // GET: KupovinaProizvoda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupovinaProizvoda = await _context.KupovinaProizvod
                .Include(k => k.Kupovina)
                .Include(k => k.Proizvod)
                .FirstOrDefaultAsync(m => m.ProizvodId == id);
            if (kupovinaProizvoda == null)
            {
                return NotFound();
            }

            return View(kupovinaProizvoda);
        }

        // POST: KupovinaProizvoda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kupovinaProizvoda = await _context.KupovinaProizvod.FindAsync(id);
            _context.KupovinaProizvod.Remove(kupovinaProizvoda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KupovinaProizvodaExists(int id)
        {
            return _context.KupovinaProizvod.Any(e => e.ProizvodId == id);
        }
    }
}
