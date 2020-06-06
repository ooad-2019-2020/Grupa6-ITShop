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
    public class MaticnaPlocaController : Controller
    {
        private readonly OOADContext _context;

        public MaticnaPlocaController(OOADContext context)
        {
            _context = context;
        }

        // GET: MaticnaPloca
        public async Task<IActionResult> Index()
        {
            return View(await _context.MaticnaPloca.ToListAsync());
        }

        // GET: MaticnaPloca/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maticnaPloca = await _context.MaticnaPloca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maticnaPloca == null)
            {
                return NotFound();
            }

            return View(maticnaPloca);
        }

        // GET: MaticnaPloca/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaticnaPloca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProizvodId,BrojRAMSlotova,SocketProcesora")] MaticnaPloca maticnaPloca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maticnaPloca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maticnaPloca);
        }

        // GET: MaticnaPloca/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maticnaPloca = await _context.MaticnaPloca.FindAsync(id);
            if (maticnaPloca == null)
            {
                return NotFound();
            }
            return View(maticnaPloca);
        }

        // POST: MaticnaPloca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProizvodId,BrojRAMSlotova,SocketProcesora")] MaticnaPloca maticnaPloca)
        {
            if (id != maticnaPloca.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maticnaPloca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaticnaPlocaExists(maticnaPloca.Id))
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
            return View(maticnaPloca);
        }

        // GET: MaticnaPloca/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maticnaPloca = await _context.MaticnaPloca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maticnaPloca == null)
            {
                return NotFound();
            }

            return View(maticnaPloca);
        }

        // POST: MaticnaPloca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maticnaPloca = await _context.MaticnaPloca.FindAsync(id);
            _context.MaticnaPloca.Remove(maticnaPloca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaticnaPlocaExists(int id)
        {
            return _context.MaticnaPloca.Any(e => e.Id == id);
        }
    }
}
