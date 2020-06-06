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
    public class SlusaliceController : Controller
    {
        private readonly OOADContext _context;

        public SlusaliceController(OOADContext context)
        {
            _context = context;
        }

        // GET: Slusalice
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slusalice.ToListAsync());
        }

        // GET: Slusalice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slusalice = await _context.Slusalice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slusalice == null)
            {
                return NotFound();
            }

            return View(slusalice);
        }

        // GET: Slusalice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slusalice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProizvodId,VrstaPrikljucka,ImaLiMikrofon")] Slusalice slusalice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slusalice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slusalice);
        }

        // GET: Slusalice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slusalice = await _context.Slusalice.FindAsync(id);
            if (slusalice == null)
            {
                return NotFound();
            }
            return View(slusalice);
        }

        // POST: Slusalice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProizvodId,VrstaPrikljucka,ImaLiMikrofon")] Slusalice slusalice)
        {
            if (id != slusalice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slusalice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlusaliceExists(slusalice.Id))
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
            return View(slusalice);
        }

        // GET: Slusalice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slusalice = await _context.Slusalice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slusalice == null)
            {
                return NotFound();
            }

            return View(slusalice);
        }

        // POST: Slusalice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slusalice = await _context.Slusalice.FindAsync(id);
            _context.Slusalice.Remove(slusalice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlusaliceExists(int id)
        {
            return _context.Slusalice.Any(e => e.Id == id);
        }
    }
}
