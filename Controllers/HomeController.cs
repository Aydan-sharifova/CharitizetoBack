using CharitizeMVC.Data;
using CharitizeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CharitizeMVC.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        HomeVM homeVm = new()
        {

        };
        return View(homeVm);
        
    }


}

