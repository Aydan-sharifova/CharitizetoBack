using Microsoft.AspNetCore.Mvc;

namespace CharitizeMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


}

