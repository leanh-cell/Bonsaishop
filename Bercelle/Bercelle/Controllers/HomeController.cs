using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bercelle.Models;
using Microsoft.EntityFrameworkCore;
using Bercelle.Data;
using System;

namespace Bercelle.Controllers;

public class HomeController : Controller
{
    private readonly BercelleContext _context;

    public HomeController(BercelleContext context)
    {
        _context = context;
    }
    //home 
    public IActionResult Index()
    {
        var products = _context.Products.AsQueryable();
        var categories = _context.Categorys.ToList();
        var viewModel = new ViewData
        {
            Products = products.ToList(),
            Danhmuc = categories
        };

        return View(viewModel);
    }

    //danh muc san pham
    public IActionResult Category()
    {
        var products = _context.Products.ToList();
        var categories = _context.Categorys.ToList();

        var viewModel = new ViewData
        {
            Products = products,
            Danhmuc = categories
        };

        return View(viewModel);
    }
    //tìm kiếm sản phẩm 
    public IActionResult Search_product(string searchString,float? price)
    {
        var products = _context.Products.AsQueryable();
        char[] chartotrim = { ' ','*' };
        
        if (!string.IsNullOrEmpty(searchString.Trim()))
        {
            searchString = searchString.Trim();
            products = products.Where(p => p.nameprd!.Contains(searchString) || p.namectg!.Contains(searchString));
        }
        if (price.HasValue)
        {
            products = products.Where(e => e.price >= price);
        }
        var categories = _context.Categorys.ToList();
        var viewModel = new ViewData
        {
            Products = products.ToList(),
            Danhmuc = categories
        };

        return View(viewModel);
    }
    //tìm kiếm sản phẩm end
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult error()
    {
        return View();
    }

    public IActionResult blog_details()
    {
        return View();
    }

    public IActionResult blog()
    {
        return View();
    }

    public IActionResult checkout()
    {
        return View();
    }

    public IActionResult contact()
    {
        return View();
    }

    public IActionResult detail()
    {
        return View();
    }

    public IActionResult faq()
    {
        return View();
    }

    public IActionResult my_wishlist()
    {
        return View();
    }


    public IActionResult product_comparison()
    {
        return View();
    }


    public IActionResult shopping_cart()
    {
        return View();
    }

    public IActionResult sign_in()
    {
        return View();
    }


    public IActionResult terms_conditions()
    {
        return View();
    }


    public IActionResult track_orders()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

