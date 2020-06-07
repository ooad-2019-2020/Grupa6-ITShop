using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITShop.Data;
using ITShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace ITShop.Controllers
{
    public class SSDController : Controller
    {
        private readonly OOADContext _context;

        public SSDController(OOADContext context)
        {
            _context = context;
        }

        // GET: SSD
        public async Task<IActionResult> Index()
        {
            return View(await _context.SDisk.ToListAsync());
        }

        // GET: SSD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sSD = await _context.SDisk
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sSD == null)
            {
                return NotFound();
            }

            return View(sSD);
        }

        // GET: SSD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SSD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator, Uposlenik")]
        public async Task<IActionResult> Create([Bind("Naziv,Proizvodjac,Cijena,Kapacitet,Brzina,Velicina")] SSD sSD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sSD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sSD);
        }

        // GET: SSD/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sSD = await _context.SDisk.FindAsync(id);
            if (sSD == null)
            {
                return NotFound();
            }
            return View(sSD);
        }

        // POST: SSD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator, Uposlenik")]
        public async Task<IActionResult> Edit(int id, [Bind("Naziv,Proizvodjac,Cijena,Kapacitet,Brzina,Velicina,Id")] SSD sSD)
        {
            if (id != sSD.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sSD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SSDExists(sSD.Id))
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
            return View(sSD);
        }

        // GET: SSD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sSD = await _context.SDisk
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sSD == null)
            {
                return NotFound();
            }

            return View(sSD);
        }

        // POST: SSD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sSD = await _context.SDisk.FindAsync(id);
            _context.SDisk.Remove(sSD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SSDExists(int id)
        {
            return _context.SDisk.Any(e => e.Id == id);
        }
    }
}
