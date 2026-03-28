using Microsoft.AspNetCore.Mvc;

namespace PortalCampanas.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Campanas");
    }
}