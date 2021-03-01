using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace Lab5.Controllers
{
    public class ProductListController : Controller
    {
        private readonly ProductContext _context;
        public ProductListController(ProductContext context)
        {
            _context = context;
        }
        // GET: Products
        [Authorize]
        public async Task<IActionResult> Index(int? categoryId)
        {
            ViewBag.Title = "Продукти";
            IQueryable<Product> products =
            _context.Products.Include(p => p.Category);
            if (categoryId.HasValue && categoryId > 0)
            {
                products = products.Where(p => p.CategoryID == categoryId);
            }
            return View((await products.ToListAsync())
            .OrderByDescending(x => x.CategoryID));
        }
        [Authorize]
        public async Task<IActionResult> Details(int? productID)
        {
            if (productID == null)
            {
                return NotFound();
            }
            var product = await _context.Products
            .Include(p => p.Category)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.ProductID == productID);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}