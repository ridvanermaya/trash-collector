using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Web.Data;
using TrashCollector.Web.Models;

namespace TrashCollector.Web.Controllers
{
    public class AddressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Address
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DAddress.Include(d => d.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Address/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dAddress = await _context.DAddress
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.AddressId == id);
            if (dAddress == null)
            {
                return NotFound();
            }

            return View(dAddress);
        }

        // GET: Address/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Address/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressId,AddressTitle,AddressLine1,AddressLine2,City,StateAbbreviation,ZipCode,UserId")] DAddress dAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Customer");
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dAddress.UserId);
            return RedirectToAction("Create", "Customer");
        }

        // GET: Address/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dAddress = await _context.DAddress.FindAsync(id);
            if (dAddress == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dAddress.UserId);
            return View(dAddress);
        }

        // POST: Address/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddressId,AddressTitle,AddressLine1,AddressLine2,City,StateAbbreviation,ZipCode,UserId")] DAddress dAddress)
        {
            if (id != dAddress.AddressId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DAddressExists(dAddress.AddressId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dAddress.UserId);
            return View(dAddress);
        }

        // GET: Address/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dAddress = await _context.DAddress
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.AddressId == id);
            if (dAddress == null)
            {
                return NotFound();
            }

            return View(dAddress);
        }

        // POST: Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dAddress = await _context.DAddress.FindAsync(id);
            _context.DAddress.Remove(dAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DAddressExists(int id)
        {
            return _context.DAddress.Any(e => e.AddressId == id);
        }
    }
}
