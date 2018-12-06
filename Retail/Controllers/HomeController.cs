using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Retail.Models;

namespace Retail.Controllers
{
  public class HomeController : Controller
  {
    private readonly RetailContext _context;
    public HomeController(RetailContext context)
    {
      _context = context;
    }
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }
    public IActionResult Login()
    {
      return View();
    }
    public IActionResult LoginFunction(LoginView login)
    {
      List <Login> lg = _context.Login.ToList();
      if (ModelState.IsValid)
      {
        var isValid = (login.Username == "username" && login.Password == "password");
      }
      Console.Write(login);
      return RedirectToAction("Index");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
