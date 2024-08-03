using Microsoft.AspNetCore.Mvc;

namespace SailorWebServer.Controllers;

public class PageController : Controller
{
    public IActionResult About()
    {
        return View();
    }
    
    public IActionResult Services()
    {
        return View();
    }
    
    public IActionResult Portfolio()
    {
        return View();
    }  
    
    public IActionResult Pricing()
    {
        return View();
    }
    
    public IActionResult Blog()
    {
        return View();
    }  
}