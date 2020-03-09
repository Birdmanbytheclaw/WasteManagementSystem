using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customer.FirstOrDefault(a => a.UserId == userId);
            if (customer is null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("Details");
        }

        // GET: Customers/Details/5
        public IActionResult Details(int? id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customer.FirstOrDefault(a => a.UserId == userId);
            if (userId == null)
            {
                return RedirectToAction("Create", "Customer");
            }
            if (customer == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }
            // GET: Customers/Create
            public IActionResult Create()
            {
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
                return View();
            }
        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FirstName,LastName,Address,ServiceInfo")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.UserId = userId;
                //customer.Pickup = new Pickup();
                _context.Customer.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index", "Addresses");
            }
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customer.AddressId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", customer.UserId);
            //ViewData["PickupId"] = new SelectList(_context.Set<Pickup>(), "Id", "Id", customer.PickupId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public IActionResult Edit(int? id)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customer.FirstOrDefault(a => a.UserId == userId);
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", customer.AddressId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", customer.UserId);
            ViewData["ServiceInfoId"] = new SelectList(_context.Set<ServiceInfo>(), "Id", "Id", customer.ServiceInfoId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,AddressId,ServiceInfoId,UserId")] Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customerOne = _context.Customer.FirstOrDefault(a => a.UserId == userId);
            if (id != customerOne.Id)
            {
                return NotFound();
            }

            Customer editCustomer = _context.Customer.Find(id);
            editCustomer.FirstName = customer.FirstName;
            editCustomer.LastName = customer.LastName;
            editCustomer.AddressId = customer.AddressId;
            editCustomer.ServiceInfoId = customer.ServiceInfoId;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", customer.AddressId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", customer.UserId);
            ViewData["ServiceInfoId"] = new SelectList(_context.Set<ServiceInfo>(), "Id", "Id", customer.ServiceInfoId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.Address)
                .Include(c => c.IdentityUser)
                .Include(c => c.ServiceInfo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
