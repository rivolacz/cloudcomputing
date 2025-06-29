using CloudComputing;
using CloudComputing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudComputing.Controllers;

public class ProductsController(AppDbContext db) : Controller
{
    // GET /Products
    public async Task<IActionResult> Index()
    {
        var products = await db.Products.AsNoTracking().ToListAsync();
        return View(products);
    }

    // GET /Products/Create
    public IActionResult Create() => View();

    // POST /Products/Create
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product p)
    {
        if (!ModelState.IsValid) return View(p);

        db.Products.Add(p);
        await db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
