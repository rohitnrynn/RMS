using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Retail.Models;
using Retail.Models.DBModels;

namespace Retail.Controllers
{
  public class ModelBag
  {
    public LoginView Login { get; set; }

    public ModelBag()
    {
      Login = new LoginView();
    }
  }
  public class LoginController : Controller
  {
    public ModelBag ModelHolder { get; set; }
    public RetailContext db;
    public LoginController(RetailContext context)
    {
      db = context;
      ModelHolder = new ModelBag();
    }
    public IActionResult Index()
    {
      var cookie= User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
      if(cookie=="admin")
        return RedirectToAction("Index", "CentralInventory");
      else if(cookie== "localstoremanager")
        return RedirectToAction("Index", "LocalStoreManager");
      return View();
    }
    //User authentication
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Signin(LoginView login)
    {
      if (ModelState.IsValid)
      {
        //Get matched user from database
        var user = (from u in db.Staff
                    where u.Username == login.Username && u.Password == login.Password
                    select u);

        if (user.Count() == 0)
        {
          //If no match then return alert message
          ViewData["LoginStatus"] = "Failed";
          return View("Index");
        }
        Staff vuser = user.First();
        //Add claims to the user (Cookie based authentication
        var identity = new ClaimsIdentity(new[]{
                    new Claim(ClaimTypes.Name, vuser.Name),
                    new Claim(ClaimTypes.Role, vuser.Role),
                    new Claim(ClaimTypes.Actor,vuser.OutletId.ToString()),
                    new Claim(ClaimTypes.PrimarySid,vuser.Id.ToString())
                }, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        if (vuser.Role == "admin")
          return RedirectToAction("Index", "CentralInventory");
        else if(vuser.Role=="localstoreincharge")
          return RedirectToAction("Index", "LocalStoreIncharge");
        else if (vuser.Role == "localstoremanager")
          return RedirectToAction("Index", "LocalStoreManager");
        else if (vuser.Role == "pos")
          return RedirectToAction("Index", "POS");
        else
        return RedirectToAction("Index");
      }
      ModelHolder.Login = login;
      return View("Contact", ModelHolder);
    }
    public async Task<IActionResult> Signout()
    {
      await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
      return RedirectToAction("Index");
      //return RedirectToAction(nameof(Index));
    }
  }
}
