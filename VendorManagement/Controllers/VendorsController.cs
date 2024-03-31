using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VendorManagement.Data;
using VendorManagement.Models;
using System.Linq;
using System.Threading.Tasks;

namespace VendorManagement.Controllers
{
    public class VendorsController : Controller
    {
        private readonly VendorManagementContext _context;

        public VendorsController(VendorManagementContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Vendors == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var Vendors = from m in _context.Vendors
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Vendors = Vendors.Where(s => s.Name!.Contains(searchString) || s.Contact!.Contains(searchString));
            }

            return View(await Vendors.ToListAsync());
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendors = await _context.Vendors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendors == null)
            {
                return NotFound();
            }

            return View(vendors);
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Contact,Position,Phone,Email,Address,City,State,ZipCode,Notes")] Vendors vendors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendors);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendors = await _context.Vendors.FindAsync(id);
            if (vendors == null)
            {
                return NotFound();
            }
            return View(vendors);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Contact,Position,Phone,Email,Address,City,State,ZipCode,Notes")] Vendors vendors)
        {
            if (id != vendors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorsExists(vendors.Id))
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
            return View(vendors);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendors = await _context.Vendors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendors == null)
            {
                return NotFound();
            }

            return View(vendors);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendors = await _context.Vendors.FindAsync(id);
            if (vendors != null)
            {
                _context.Vendors.Remove(vendors);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorsExists(int id)
        {
            return _context.Vendors.Any(e => e.Id == id);
        }
    }
}
