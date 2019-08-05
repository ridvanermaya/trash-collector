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
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = await _context.DEmployee.FirstOrDefaultAsync(x => x.UserId == userId);

            if (employee != null)
            {
                return RedirectToAction("Edit", new { id = employee.EmployeeId });
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        public async Task<IActionResult> TodaysPickUps([FromQuery(Name = "Day")]string day)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var selectedDay = DateTime.Now.DayOfWeek;
            var employee = await _context.DEmployee.FirstOrDefaultAsync(x => x.UserId == userId);

            if (!string.IsNullOrEmpty(day))
            {
                selectedDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
            }

            var customers = _context.DCustomer.Where(x => x.PickUpDay == selectedDay);
            var todaysPickUpCustomers = new List<DCustomer>();

            foreach (var customer in customers)
            {
                var address = await _context.DAddress.FirstOrDefaultAsync(x => x.UserId == customer.UserId && x.ZipCode == employee.ZipCode);
                if (address != null)
                {
                    todaysPickUpCustomers.Add(customer);
                }
            }
            
            return View(todaysPickUpCustomers);
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.DEmployee.Include(d => d.User).Where(x => x.UserId == userId);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dEmployee = await _context.DEmployee
                .Include(d => d.User)
                .FirstOrDefaultAsync(x => x.EmployeeId == id && x.UserId == userId);
            if (dEmployee == null)
            {
                return NotFound();
            }

            return View(dEmployee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,FirstName,LastName,ZipCode,UserId")] DEmployee dEmployee)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                dEmployee.UserId = userId;
                _context.Add(dEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dEmployee.UserId);
            return View(dEmployee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dEmployee = await _context.DEmployee.FirstOrDefaultAsync(x => x.EmployeeId == id && x.UserId == userId);
            if (dEmployee == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dEmployee.UserId);
            return View(dEmployee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,FirstName,LastName,ZipCode,UserId")] DEmployee dEmployee)
        {
            if (id != dEmployee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dEmployee.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    _context.Update(dEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DEmployeeExists(dEmployee.EmployeeId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", dEmployee.UserId);
            return View(dEmployee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dEmployee = await _context.DEmployee
                .Include(d => d.User)
                .FirstOrDefaultAsync(x => x.EmployeeId == id && x.UserId == userId);
            if (dEmployee == null)
            {
                return NotFound();
            }

            return View(dEmployee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dEmployee = await _context.DEmployee.FirstOrDefaultAsync(x => x.EmployeeId == id && x.UserId == userId);
            _context.DEmployee.Remove(dEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DEmployeeExists(int id)
        {
            return _context.DEmployee.Any(e => e.EmployeeId == id);
        }
    }
}
