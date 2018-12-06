using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retail.Models;
using Retail.Models.DBModels;

using Retail.Models.ViewModel;

namespace Retail.Controllers
{
    public class CentralModel
    {
        public Staff updatestaff { get; set; }
        public Staff staffdb { get; set; }
        public Product productsdb { get; set; }
        public Outlet outletdb { get; set; }
        public IEnumerable<Outlet> loopoutelts { get; set; }
        public IEnumerable<Product> loopproducts { get; set; }
        public IEnumerable<Staff> loopstaff { get; set; }
    }
    public class StaffBag
  {
    public AddStaff StaffDetails { get; set; }

    public StaffBag()
    {
      StaffDetails = new AddStaff();
    }
  }
  public class CentralInventoryController : Controller
  {
    public StaffBag StaffHolder { get; set; }
    public RetailContext db;
        //private readonly RetailContext _context;

        public CentralModel obj = new CentralModel();

        public CentralInventoryController(RetailContext context)
    {
      db = context;
      StaffHolder = new StaffBag();
    }
    public IActionResult Index()
    {
             return View();
    }
        public IActionResult SalesReports()
        {
            return View();
        }

        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditProduct(int Id)
        {
            CustomModelBag modelBag = new CustomModelBag();
            modelBag.NewProduct = db.Product.Where(s => s.ProductId == Id).FirstOrDefault();
            modelBag.NewProduct.Spec = db.Spec.Where(sp => sp.ProdId == Id).ToList();
            ViewBag.Categories = db.Category.ToList();
            return View("EditProduct", modelBag);
        }
        public IActionResult ViewStaff()
        {
            List<Staff> l = db.Staff.ToList();
            return View(l);
        }
        public IActionResult ViewOutlet()
        {
            List<Outlet> l = db.Outlet.ToList();
            return View(l);
        }
        //public async Task<IActionResult> ViewStaff(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var staf = await _context.Staff
        //        .Include(e => e.Role)
        //        .Include(e => e.Name)
        //        .Include(e => e.PhoneNumber)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (staf == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(staf);
        //}
        public IActionResult AddProduct()
        {
            CustomModelBag modelBag = new CustomModelBag();
            Product product = new Product();
            Spec spec = new Spec();
            product.Spec = new List<Spec>();
            product.Spec.Add(spec);
            modelBag.NewProduct = product;
            ViewBag.Categories = db.Category.ToList();
            return View("AddProduct", modelBag);
        }

        [HttpPost]
        public IActionResult UpdateProductSpec(CustomModelBag modelBag)
        {
            Spec spec = new Spec();
            modelBag.NewProduct.Spec.Add(spec);
            ViewBag.Categories = db.Category.ToList();
            if (modelBag.NewProduct.Cat_Id <= 0)
            {
                return View("AddProduct", modelBag);
            }
            else
            {
                return View("ViewProduct", modelBag);
            }
        }

        [HttpPost]
        public IActionResult AddProductSubmit(CustomModelBag modelBag)
        {
            modelBag.NewProduct.Cat_Id = db.Category.Where(w => w.Name == modelBag.NewProduct.ProductCat.Name).FirstOrDefault().Cat_Id;
            db.Product.Add(modelBag.NewProduct);
            foreach (var spec in modelBag.NewProduct.Spec)
            {
                spec.ProdId = modelBag.NewProduct.ProductId;
                db.Spec.Add(spec);
            }
            db.SaveChanges();
            return RedirectToAction("ViewProduct");
        }
        public IActionResult ViewProduct()
        {
            List<Product> products = db.Product.ToList();
            for (int i = 0; i < products.Count(); i++)
            {
                products[i].ProductCat = db.Category.Where(s => s.Cat_Id == products[i].Cat_Id).FirstOrDefault();
                products[i].Spec = db.Spec.Where(sp => sp.ProdId == products[i].ProductId).ToList();
            }
            CustomModelBag modelBag = new CustomModelBag();
            modelBag.Product = products;

            return View("ViewProduct", modelBag);
             
        }
        //[HttpPost]
        //public IActionResult AddProductFunction(Product prod)
        //{

        //    db.Product.Add(prod);
        //    db.SaveChanges();
        //    return RedirectToAction("Index", prod);
        //}
        [HttpPost]
        //function to add new staff
        public IActionResult AddStaffFunction(Staff staff)
    {

        db.Staff.Add(staff);
        db.SaveChanges();
      return RedirectToAction("Index",staff);
    }
        public IActionResult AddOutlet()
        {
            return View();
        }
        public IActionResult AddOutletFunction(Outlet outlet)
        {

            db.Outlet.Add(outlet);
            db.SaveChanges();
            return RedirectToAction("Index", outlet);
        }


        //public IActionResult ManageProducts()
        //{
        //    CentralModel obj = new CentralModel
        //    {
        //        loopproducts = db.Product.ToList()
        //    };
        //    return View(obj);
        //}
        //[HttpPost]
        //public IActionResult AddProductsFunction(CentralModel model)
        //{

        //    db.Product.Add(model.productsdb);
        //    db.SaveChanges();
        //    return RedirectToAction("ManageProducts");
        //}
        //public IActionResult Outlet()
        //{
        //    CentralModel obj = new CentralModel
        //    {
        //        loopoutelts = db.Outlet.ToList()
        //    };
        //    return View(obj);
        //}

        //private IActionResult GenerateNumbers()
        //{
        //  List<SelectListItem> items = new List<SelectListItem>();
        //  var numbers = (from p in db.Outlet
        //                 select p.Location,p.Id);
        //}
        public IActionResult UpdateProduct(CustomModelBag modelBag)
        {
            //Getting category id from category name
            modelBag.NewProduct.Cat_Id = db.Category.Where(s => s.Name == modelBag.NewProduct.ProductCat.Name).FirstOrDefault().Cat_Id;

            //creating temp product variable
            Product temp = modelBag.NewProduct;

            //Updating existing data;
            Product product = db.Product.Find(modelBag.NewProduct.ProductId);

            product.ProductName = temp.ProductName;
            product.Company = temp.Company;
            product.Cat_Id = temp.Cat_Id;
            product.Rate = temp.Rate;
            db.Product.Update(product);

            foreach (var spec in temp.Spec)
            {
                Spec prodSpec = db.Spec.Find(spec.Id);
                spec.ProdId = product.ProductId;
                if (prodSpec == null)
                {
                    db.Spec.Add(spec);
                }
                else
                {
                    prodSpec.ProdId = spec.ProdId;
                    prodSpec.SpecName = spec.SpecName;
                    prodSpec.SpecValue = spec.SpecValue;
                    db.Spec.Update(prodSpec);
                }
            }
            db.SaveChanges();
            return RedirectToAction("ViewProduct");
        }

        public IActionResult ManageOrder()
        {
            var pending = from u in db.Order where u.Status == "Pending" select u;
            var dispatched = from u in db.Order where u.Status == "Dispatched" select u;
            var completed = from u in db.Order where u.Status == "Completed" select u;
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
        public IActionResult VerifyOrder(int? id)
        {
            var tbl = db.Order.Find(id);
            int outletid = int.Parse(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value);
            var prod = from u in db.LocalInventory where u.OutletId == outletid select u;
            var detail = from u in db.OrderDetails where u.OrderId == id select u;
            List<LocalInventory> local = new List<LocalInventory>();
            local = prod.ToList();
            List<Order> det = new List<Order>();
            List<OrderDetails> dt = new List<OrderDetails>();
            dt = detail.ToList();
            Order remove = new Order();
            tbl.Status = "Dispatched";
            tbl.DeliveryDate = DateTime.Now;
            db.Order.Update(tbl);
            db.SaveChanges();
            return RedirectToAction("ManageOrder");
        }
        [HttpGet]
        public void FindStaffById(int? id)
        {
            obj.updatestaff = db.Staff.Find(id);
        }
    }
}
