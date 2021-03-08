using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spindle_Ledger.Data;
using Spindle_Ledger.Models;

namespace Spindle_Ledger
{
    //[Authorize(Roles = "User")]
    [Authorize(Roles = "Admin")]
    //[Authorize(Roles = "User")]

    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductsCRUD
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: ProductsCRUD/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }


        [Authorize(Roles = "Admin")]
        // GET: ProductsCRUD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductsCRUD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Product_Name,Product_Description,Product_Cost,Product_Quantity,Customer_Name,Customer_Address,Customer_Contact,Seller_Name,Seller_Address,Seller_Contact,WareHouse_Name,WareHouse_Address,WareHouse_Cost,WareHouse_Contact,TransportFromSeller_Name,TransportFromSeller_Description,TransportFromSeller_Cost,TransportFromSeller_Contact,TransportFromSeller_Date,TransportToCustomer_Name,TransportToCustomer_Description,TransportToCustomer_Cost,TransportToCustomer_Contact,TransportToCustomer_Date")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }


        [Authorize(Roles = "Admin")]
        // GET: ProductsCRUD/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        // POST: ProductsCRUD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Product_Name,Product_Description,Product_Cost,Product_Quantity,Customer_Name,Customer_Address,Customer_Contact,Seller_Name,Seller_Address,Seller_Contact,WareHouse_Name,WareHouse_Address,WareHouse_Cost,WareHouse_Contact,TransportFromSeller_Name,TransportFromSeller_Description,TransportFromSeller_Cost,TransportFromSeller_Contact,TransportFromSeller_Date,TransportToCustomer_Name,TransportToCustomer_Description,TransportToCustomer_Cost,TransportToCustomer_Contact,TransportToCustomer_Date")] Products products)
        {
            if (id != products.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.ID))
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
            return View(products);
        }



        [Authorize(Roles = "Admin")]
        // GET: ProductsCRUD/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: ProductsCRUD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(string id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
