using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Web.Data;
using TrashCollector.Web.Models;

namespace TrashCollector.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var address = await _context.DAddress.FirstOrDefaultAsync(x => x.UserId == userId);

            if (address == null)
            {
                return RedirectToAction("Create", "Address");
            }

            var customer = await _context.DCustomer.FirstOrDefaultAsync(x => x.UserId == userId);

            if (customer != null)
            {
                return RedirectToAction("Edit", new { id = customer.CustomerId });
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        public async Task<IActionResult> MyBill()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _context.DCustomer.FirstOrDefaultAsync(x => x.UserId == userId);
            var pickups = _context.DPickups.Where(x => x.CustomerId == customer.CustomerId);

            return View(await pickups.ToListAsync());
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var filteredCustomers = new List<DCustomer>();
            var addressList = new List<DAddress>();

            if (User.IsInRole("Employee"))
            {
                var employee = await _context.DEmployee.FirstOrDefaultAsync(x => x.UserId == userId);
                if (employee == null) return NotFound("Employee information not found.");
                var customers = await _context.DCustomer.ToListAsync();
                foreach (var customer in customers)
                {
                    var address = await _context.DAddress.FirstOrDefaultAsync(x => x.UserId == customer.UserId && x.ZipCode == employee.ZipCode);
                    if (address != null)
                    {
                        filteredCustomers.Add(customer);
                        addressList.Add(address);
                    }
                }
            }
            else
            {
                filteredCustomers = await _context.DCustomer.Where(x => x.UserId == userId).ToListAsync();
            }

            ViewBag.AddressList = addressList;

            return View(filteredCustomers);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var isEmployee = User.IsInRole("Employee");
            var customer = isEmployee
            ? await _context.DCustomer.FirstOrDefaultAsync(x => x.CustomerId == id)
            : await _context.DCustomer.FirstOrDefaultAsync(x => x.CustomerId == id && x.UserId == userId);

            if (customer == null)
            {
                return NotFound();
            }

            var address = await _context.DAddress.FirstOrDefaultAsync(x => x.UserId == customer.UserId);
            ViewBag.Address = $"{address.AddressLine1}, {address.AddressLine2}, {address.City}, {address.StateAbbreviation}, {address.ZipCode}";

            return View(customer);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,PickUpDay,UserId,OneTimePickUpDate")] DCustomer dCustomer)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                dCustomer.UserId = userId;
                _context.Add(dCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dCustomer.UserId);
            return RedirectToAction("Index", "Home");
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var dCustomer = await _context.DCustomer.FirstOrDefaultAsync(x => x.CustomerId == id && x.UserId == userId);
            if (dCustomer == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dCustomer.UserId);
            return View(dCustomer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,PickUpDay,OneTimePickUpDate")] DCustomer dCustomer)
        {
            if (id != dCustomer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dCustomer.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    _context.Update(dCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DCustomerExists(dCustomer.CustomerId))
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
            return View(dCustomer);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dCustomer = await _context.DCustomer
                .Include(d => d.User)
                .FirstOrDefaultAsync(x => x.CustomerId == id && x.UserId == userId);
            if (dCustomer == null)
            {
                return NotFound();
            }

            return View(dCustomer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dCustomer = await _context.DCustomer.FirstOrDefaultAsync(x => x.CustomerId == id && x.UserId == userId);
            _context.DCustomer.Remove(dCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DCustomerExists(int id)
        {
            return _context.DCustomer.Any(e => e.CustomerId == id);
        }
    }
}
