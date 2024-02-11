using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuickReceipts.Data;
using QuickReceipts.Helper;
using QuickReceipts.Models;

namespace QuickReceipts.Controllers
{
    public class SettingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SettingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Settings
        public async Task<IActionResult> Index()
        {
              return _context.Settings != null ? 
                          View(await _context.Settings.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Settings'  is null.");
        }

        // GET: Settings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Settings == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (settings == null)
            {
                return NotFound();
            }

            return View(settings);
        }

        // GET: Settings/Create
        public IActionResult Create()
        {

            ViewBag.LanguageList = EnumHelper.ToSelectList<Language>();
            ViewBag.CurrencyList = EnumHelper.ToSelectList<Currency>();
            return View();
        }

        // POST: Settings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Language,Currency")] Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(settings);
        }

        // GET: Settings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Settings == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings.FindAsync(id);
            if (settings == null)
            {
                return NotFound();
            }
            return View(settings);
        }

        // POST: Settings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Language,Currency")] Settings settings)
        {
            if (id != settings.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(settings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SettingsExists(settings.Id))
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
            return View(settings);
        }

        // GET: Settings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Settings == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (settings == null)
            {
                return NotFound();
            }

            return View(settings);
        }

        // POST: Settings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Settings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Settings'  is null.");
            }
            var settings = await _context.Settings.FindAsync(id);
            if (settings != null)
            {
                _context.Settings.Remove(settings);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SettingsExists(int id)
        {
          return (_context.Settings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
