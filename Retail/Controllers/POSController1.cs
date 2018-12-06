using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Retail.Models;
using Retail.Models.DBModels;
using Retail.Models.ViewModel;


namespace Retail.Controllers
{
    public class POSController : Controller
    {
        public RetailContext db;
        public static List<Bill> bill = new List<Bill>();
        public static List<BillDetails> billdetails = new List<BillDetails>();
        public static Buyer c = new Buyer();
        public static int TotalAmount, BuyerId;

        public POSController(RetailContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            ViewBag.BillDetails = billdetails.ToList();
            var products1 = db.Product.ToList();
            ViewBag.Products = products1;
            CustomModelBag modelBag = new CustomModelBag();
            ViewBag.BillProducts = db.Product.ToList();
            int outletId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Actor)?.Value);
            var products = db.LocalInventory.Where(s => s.OutletId == outletId);
            ViewData["ProductId"] = new SelectList(db.LocalInventory.Where(s => s.OutletId == outletId), "ProductId", "ProductId", products);
            return View();
        }
        [HttpGet]
        public IActionResult BillProcess(CustomModelBag modelBag)
        {
            ViewBag.BillDetails = billdetails.ToList();
            var products1 = db.Product.ToList();
            ViewBag.Products = products1;
            modelBag.BillProducts = db.Product.ToList();
            int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.PrimarySid)?.Value);
            modelBag.Buyer = FindCustomerByPhone(modelBag.Buyer.BuyerPhone);
            BuyerId = modelBag.Buyer.BuyerId;
            ViewBag.Customer = modelBag.Buyer;
            int outletId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Actor)?.Value);
            var products = db.LocalInventory.Where(s => s.OutletId == outletId);
            ViewData["ProductId"] = new SelectList(db.LocalInventory.Where(s => s.OutletId == outletId), "ProductId", "ProductId", products);
            return View("CustomerDetails", modelBag);
        }
        public Buyer FindCustomerByPhone(string phone)
        {
            Buyer customer = new Buyer();
            customer = db.Buyer.Where(w => w.BuyerPhone == phone).FirstOrDefault();
            return customer;
        }
        public IActionResult AddToBill(CustomModelBag modelBag)
        {
            var query = from u in billdetails where u.ProductId == modelBag.BillDetails.ProductId select u;
            if (query.Count() != 0)
            {
                return RedirectToAction("Index");
            }
            var products = db.Product.ToList();
            ViewBag.Products = products;
            foreach (var p in products)
            {
                if (p.ProductId == modelBag.BillDetails.ProductId)
                {
                    modelBag.BillDetails.Amount = Convert.ToInt32(modelBag.BillDetails.Quantity) * Convert.ToInt32(p.Rate);
                    modelBag.TotalAmount += modelBag.BillDetails.Amount;
                    TotalAmount += modelBag.TotalAmount;
                }
            }
            billdetails.Add(modelBag.BillDetails);
            ViewBag.BillDetails = billdetails.ToList();
            ViewBag.Total = modelBag.TotalAmount;

            return RedirectToAction("Index");
        }
        public IActionResult CustomerDetails()
        {
            ViewBag.BillDetails = billdetails.ToList();
            var products1 = db.Product.ToList();
            ViewBag.Products = products1;
            CustomModelBag modelBag = new CustomModelBag();
            ViewBag.BillProducts = db.Product.ToList();
            int outletId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Actor)?.Value);
            var products = db.LocalInventory.Where(s => s.OutletId == outletId);
            ViewData["ProductId"] = new SelectList(db.LocalInventory.Where(s => s.OutletId == outletId), "ProductId", "ProductId", products);
            return View();
        }
        public IActionResult SaveBill(CustomModelBag modelBag)
        {
            int outletId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Actor)?.Value);
            int staffid = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.PrimarySid)?.Value);
            Bill newbill = new Bill();
            newbill.BillId = (int)DateTime.Now.GetHashCode();
            newbill.Date = DateTime.Now;
            newbill.TotalPayable = TotalAmount;
            newbill.PaymentMethod = "Sold";
            newbill.StaffId = staffid;
            newbill.BuyerId = BuyerId;
            db.Bill.Add(newbill);
            db.SaveChanges();
            BillDetails billDetails = new BillDetails();
            foreach (var item in billdetails)
            {
                billDetails.Id = DateTime.Now.GetHashCode() + staffid.GetHashCode();
                billDetails.BillId = newbill.BillId;
                billDetails.ProductId = item.ProductId;
                billDetails.Quantity = item.Quantity;
                billDetails.Amount = item.Amount;
                db.BillDetails.Add(billDetails);
                db.SaveChanges();
            }
            billdetails.Clear();
            TotalAmount = 0;
            return RedirectToAction("Index");
        }
        public IActionResult Invoice()
        {
            ViewBag.BillDetails = billdetails.ToList();
            var products1 = db.Product.ToList();
            ViewBag.Products = products1;
            CustomModelBag modelBag = new CustomModelBag();
            ViewBag.BillProducts = db.Product.ToList();
            int outletId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Actor)?.Value);
            var products = db.LocalInventory.Where(s => s.OutletId == outletId);
            ViewData["ProductId"] = new SelectList(db.LocalInventory.Where(s => s.OutletId == outletId), "ProductId", "ProductId", products);
            return View();
        }
    }
}
