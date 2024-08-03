using Microsoft.AspNetCore.Mvc;

namespace SailorWebServer.Controllers;

public class ContactController : Controller
{
    public IActionResult Form()
    {
        return View();
    } 
}