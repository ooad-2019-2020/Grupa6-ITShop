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
    public class HardDiskController : Controller
    {
        private readonly OOADContext _context;

        public HardDiskController(OOADContext context)
        {
            _context = context;
        }

        // GET: HardDisk
        public async Task<IActionResult> Index()
        {
            return View(await _context.HDisk.ToListAsync());
        }

        // GET: HardDisk/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardDisk = await _context.HDisk
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hardDisk == null)
            {
                return NotFound();
            }

            return View(hardDisk);
        }

        // GET: HardDisk/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HardDisk/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("")] HardDisk hardDisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hardDisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hardDisk);
        }

        // GET: HardDisk/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardDisk = await _context.HDisk.FindAsync(id);
            if (hardDisk == null)
            {
                return NotFound();
            }
            return View(hardDisk);
        }

        // POST: HardDisk/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("")] HardDisk hardDisk)
        {
            if (id != hardDisk.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hardDisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HardDiskExists(hardDisk.Id))
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
            return View(hardDisk);
        }

        // GET: HardDisk/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardDisk = await _context.HDisk
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hardDisk == null)
            {
                return NotFound();
            }

            return View(hardDisk);
        }

        // POST: HardDisk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hardDisk = await _context.HDisk.FindAsync(id);
            _context.HDisk.Remove(hardDisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HardDiskExists(int id)
        {
            return _context.HDisk.Any(e => e.Id == id);
        }
    }
}
