using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Retail.Models;
using Retail.Models.CustomModels;
using Retail.Models.DBModels;
using Retail.Models.ViewModel;

namespace Retail.Controllers
{
    public class LocalStoreManagerController : Controller
    {
        public static List<CustomOrder> prods = new List<CustomOrder>();
        public RetailContext db;
        public LocalStoreManagerController(RetailContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public int GetProductQuantityInStock(int prodId)
        {
            int StoreId = Convert.ToInt32((User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor).Value).ToString());
            return db.LocalInventory.Where(w => w.ProductId == prodId && w.OutletId == StoreId).Count();
        }
        public IActionResult PlaceOrder()
        {
            var products = db.Product.ToList();
            var spec = db.Spec.ToList();
            ViewBag.outletid = Convert.ToInt32((User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value));
            int outletid = ViewBag.outletid;
            var querylocal = db.LocalInventory.Where(s => s.OutletId == outletid);
            ViewBag.LocalProducts = querylocal;
            ViewBag.Products = products;
            ViewBag.Spec = spec;
            return View();
        }
        public IActionResult AddtoOrder(CustomOrder details)
        {
            int Id = details.ProdId;
            var query = from u in prods where u.ProdId == Id select u;
            if (query.Count() != 0)
            {
                return RedirectToAction("PlaceOrder");
            }
            prods.Add(details);
            var querylocal = db.LocalInventory.ToList();
            int id = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value);
            List<LocalInventory> lo = new List<LocalInventory>();
            querylocal.ForEach(x => { if (x.OutletId == id) { lo.Add(x); } });
            var products = db.Product.ToList();
            var spec = db.Spec.ToList();
            ViewBag.LocalProducts = querylocal;
            ViewBag.Product = products;
            ViewBag.Spec = spec;
            ViewBag.prods = prods;
            return RedirectToAction("PlaceOrder");
        }
        public IActionResult Cart(CustomOrder details)
        {
            var querylocal = db.LocalInventory.ToList();
            int id = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value);
            List<LocalInventory> lo = new List<LocalInventory>();
            querylocal.ForEach(x => { if (x.OutletId == id) { lo.Add(x); } });
            var products = db.Product.ToList();
            var spec = db.Spec.ToList();
            ViewBag.LocalProducts = querylocal;
            ViewBag.Product = products;
            ViewBag.Spec = spec;
            ViewBag.prods = prods;
            return View();
        }
        public async Task<IActionResult> SubmitOrder()
        {
            Order odr = new Order();
            odr.OrderId = DateTime.Now.GetHashCode();
            odr.StaffId = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.PrimarySid)?.Value);
            odr.OrderDate = System.DateTime.Now;
            odr.Status = "Pending";
            db.Order.Add(odr);
            int id = await db.SaveChangesAsync();
            int pid = odr.OrderId;
            OrderDetails det = new OrderDetails();
            for (int i = 0; i < prods.Count(); i++)
            {
                det.DetailsId = DateTime.Now.GetHashCode();
                det.OrderId = pid;
                det.ProductId = prods[i].ProdId;
                det.Quantity = prods[i].Qty;
                db.OrderDetails.Add(det);
                db.SaveChanges();
            }
            prods.Clear();
            return RedirectToAction("PlaceOrder");
        }
        public async Task<IActionResult> MakeModel(int Id)
        {
            var products = await db.Product.FindAsync(Id);
            var check = from u in db.LocalInventory where u.ProductId == Id select u;
            var user = await db.Staff.FindAsync();
            if (check.Count() != 0)
            {
                ViewBag.InventoryStatus = "Failed";
                return RedirectToAction("ManageProduct");
            }
            if (ModelState.IsValid)
            {
                ViewData["StaffId"] = new SelectList(db.Staff, "StaffId", "StaffId", user.Id);
                ViewData["ProductId"] = new SelectList(db.Product, "ProductId", "ProductId", products.ProductId);
                return View();
            }
            return View();
        }
        public IActionResult ManageOrder()
        {
            int staffid = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.PrimarySid)?.Value);
            var pending = from u in db.Order where u.Status == "Pending" && u.StaffId == staffid select u;
            var dispatched = from u in db.Order where u.Status == "Dispatched" && u.StaffId == staffid select u;
            var completed = from u in db.Order where u.Status == "Completed" && u.StaffId == staffid select u;
            ViewBag.Completed = completed.ToList();
            ViewBag.Pending = pending.ToList();
            ViewBag.Dispatched = dispatched.ToList();
            var odr = db.Order.ToList();
            var odrdet = db.OrderDetails.ToList();
            var prod = db.Product.ToList();
            ViewBag.Prod = prod;
            ViewBag.Order = odr;
            ViewBag.OrderDetails = odrdet;
            return View();
        }
        public IActionResult AcceptOrder(int id)
        {
            var tbl = db.Order.Find(id);
            int outletid = int.Parse(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value);
            //var prod = from u in db.LocalInventories where u.OutletId == outletid select u;
            var prod = db.LocalInventory.Where(s => s.OutletId == outletid);
            var detail = db.OrderDetails.Where(s => s.OrderId == id);
            List<LocalInventory> local = new List<LocalInventory>();
            local = prod.ToList();
            List<Order> det = new List<Order>();
            List<OrderDetails> dt = new List<OrderDetails>();
            dt = detail.ToList();
            Order remove = new Order();
            tbl.Status = "Completed";
            tbl.DeliveryDate = DateTime.Now;
            db.Order.Update(tbl);
            foreach (var item in detail)
            {
                foreach (var lstock in prod)
                {
                    if (lstock.ProductId == item.ProductId)
                    {
                        lstock.CurrentStock += item.Quantity;
                        db.LocalInventory.Update(lstock);
                    }
                }
            }
            //LocalInventory add = new LocalInventory();
            //for (int i = 0; i < local.Count(); i++)
            //{
            //  while (j < dt.Count())
            //  {
            //    if (dt[j].ProductId == local[i].ProductId)
            //    {
            //      add.LocalInventoryId = local[i].LocalInventoryId;
            //      add.ProductId = local[i].ProductId;
            //      add.ReorderLevel = local[i].ReorderLevel;
            //      add.SafetyLevel = local[i].SafetyLevel;
            //      add.OutletId = outletid;
            //      add.CurrentStock = dt[j].Quantity;
            //      db.LocalInventories.Update(add);
            //      db.SaveChanges();
            //    }
            //    j++;
            //  }

            //}
            db.SaveChanges();
            return RedirectToAction("ManageOrder");
        }
    }
}
