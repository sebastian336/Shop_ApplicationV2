#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop_Application.Data;
using Shop_Application.Models;

namespace Shop_Application.Controllers
{
    [Authorize]
    public class PlacementOfOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlacementOfOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlacementOfOrders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PlacementOfOrder.Include(p => p.Order);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PlacementOfOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placementOfOrder = await _context.PlacementOfOrder
                .Include(p => p.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placementOfOrder == null)
            {
                return NotFound();
            }

            return View(placementOfOrder);
        }

        // GET: PlacementOfOrders/Create
        public IActionResult Create(String order)
        {
            int.TryParse(order, out int iOrderId);
            PlacementOfOrder Placement = new PlacementOfOrder();
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "NameCustomer");
 
            Placement.Order = _context.Order.FirstOrDefault(Order => Order.Id == iOrderId);


            Placement.OrderId = iOrderId;

            Placement.PriceOfBuy = Placement.Order.PriceOfOrder;

            return View(Placement);
        }

        // POST: PlacementOfOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PriceOfBuy,OrderId")] PlacementOfOrder placementOfOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(placementOfOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "NameCustomer", placementOfOrder.OrderId);
            return View(placementOfOrder);
        }

        // GET: PlacementOfOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placementOfOrder = await _context.PlacementOfOrder.FindAsync(id);
            if (placementOfOrder == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "City", placementOfOrder.OrderId);
            return View(placementOfOrder);
        }

        // POST: PlacementOfOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PriceOfBuy,OrderId")] PlacementOfOrder placementOfOrder)
        {
            if (id != placementOfOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(placementOfOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlacementOfOrderExists(placementOfOrder.Id))
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
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "City", placementOfOrder.OrderId);
            return View(placementOfOrder);
        }

        // GET: PlacementOfOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placementOfOrder = await _context.PlacementOfOrder
                .Include(p => p.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placementOfOrder == null)
            {
                return NotFound();
            }

            return View(placementOfOrder);
        }

        // POST: PlacementOfOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var placementOfOrder = await _context.PlacementOfOrder.FindAsync(id);
            _context.PlacementOfOrder.Remove(placementOfOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlacementOfOrderExists(int id)
        {
            return _context.PlacementOfOrder.Any(e => e.Id == id);
        }
    }
}
