﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WasteManagementProgram.Data;
using WasteManagementProgram.Models;

namespace WasteManagementProgram.Controllers
{
    public class ServiceInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServiceInfo.ToListAsync());
        }

        // GET: ServiceInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceInfo = await _context.ServiceInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceInfo == null)
            {
                return NotFound();
            }

            return View(serviceInfo);
        }

        // GET: ServiceInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Balance,StartDate,EndDate,PickUpDay,OneTimePickUP,IsPickedUp,IsSuspended")] ServiceInfo serviceInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceInfo);
        }

        // GET: ServiceInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceInfo = await _context.ServiceInfo.FindAsync(id);
            if (serviceInfo == null)
            {
                return NotFound();
            }
            return View(serviceInfo);
        }

        // POST: ServiceInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Balance,StartDate,EndDate,PickUpDay,OneTimePickUP,IsPickedUp,IsSuspended")] ServiceInfo serviceInfo)
        {
            if (id != serviceInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceInfoExists(serviceInfo.Id))
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
            return View(serviceInfo);
        }

        // GET: ServiceInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceInfo = await _context.ServiceInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceInfo == null)
            {
                return NotFound();
            }

            return View(serviceInfo);
        }

        // POST: ServiceInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceInfo = await _context.ServiceInfo.FindAsync(id);
            _context.ServiceInfo.Remove(serviceInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceInfoExists(int id)
        {
            return _context.ServiceInfo.Any(e => e.Id == id);
        }
    }
}