using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VSC7WebAppMVCHelloWorld.Models;

namespace VSC7WebAppMVCHelloWorld.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

