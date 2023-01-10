using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bercelle.Models;

namespace Bercelle.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Category()
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

