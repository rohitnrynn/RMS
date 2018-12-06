using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Retail.Models;
using Retail.Models.CustomModels;
using Retail.Models.DBModels;
using Retail.Models.ViewModel;

namespace Retail.Controllers
{
    public class CentralModelLocal
    {
        public Staff staffdb { get; set; }
        public IEnumerable<Staff> loopstaff { get; set; }
        public IEnumerable<LocalInventory> looplocal { get; set; }
    }
    public class StaffBagLocal
    {
        public AddStaff StaffDetails { get; set; }

        public StaffBagLocal()
        {
            StaffDetails = new AddStaff();
        }
    }
    public class LocalStoreInCharge : Controller
    {
        public static float total;
        public StaffBagLocal StaffHolder { get; set; }
        public RetailContext db;
        public CentralModelLocal obj = new CentralModelLocal();
        public LocalStoreInCharge(RetailContext context)
        {
            db = context;
            StaffHolder = new StaffBagLocal();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageStaff()
        {
            var query = (from u in db.Staff
                         where u.Role != "admin" && u.OutletId.ToString() == (User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor).Value)
                         select u);

            CentralModelLocal obj = new CentralModelLocal
            {
                loopstaff = query.ToList()
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult AddStaffFunction(CentralModelLocal model)
        {

            db.Staff.Add(model.staffdb);
            db.SaveChanges();
            return RedirectToAction("ManageStaff");
        }
        public IActionResult ManageProduct()
        {
            List<Product> product = db.Product.ToList();
            for (int i = 0; i < product.Count(); i++)
            {
                product[i].ProductCat = db.Category.Where(s => s.Cat_Id == product[i].Cat_Id).FirstOrDefault();
                product[i].Spec = db.Spec.Where(sp => sp.ProdId == product[i].ProductId).ToList();
            }

            CustomModelBag modelBag = new CustomModelBag();
            modelBag.Product = product;

            return View("ManageProducts", modelBag);
        }
        public async Task<IActionResult> AddToInventory(int Id)
        {
            var products = await db.Product.FindAsync(Id);
            int outletid = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value);

            
            var check = from u in db.LocalInventory where u.ProductId == Id && u.OutletId == outletid select u;
            var outlet = await db.Outlet.FindAsync(outletid);
            if (check.Count() != 0)
            {
                ViewBag.InventoryStatus = "Failed";
                return RedirectToAction("ManageProducts");
            }
            if (ModelState.IsValid)
            {
                //ViewBag.OutletId = outletid;
                ViewData["OutletId"] = new SelectList(db.Outlet, "OutletId", "OutletId",  outlet.OutletId);
                ViewData["ProductId"] = new SelectList(db.Product, "ProductId", "ProductId", products.ProductId);
                return View();
            }
            return View();
        }
        public IActionResult AddInventory(LocalInventory local)
        {
            if (ModelState.IsValid)
            {
                local.CurrentStock = 0;
                db.LocalInventory.Add(local);
                db.SaveChanges();
                return RedirectToAction("InventoryCatalogue", local);
            }
            return RedirectToAction("InventoryCatalogue", local);
        }
        public IActionResult InventoryCatalogue()
        {
            int outletid = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value);
            dynamic Mymodel = new ExpandoObject();
            Mymodel.local = db.LocalInventory.Where(s => s.OutletId == outletid);
            Mymodel.prod = db.Product;
            Mymodel.spec = db.Spec;
            //CentralModelLocal obj = new CentralModelLocal
            //{
            //  looplocal = db.LocalInventories.ToList()
            //};
            //return View(obj);
            //int StoreId = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor).Value);
            //List<LocalInventory> products = new List<LocalInventory>();
            //products = ((from lp in db.LocalInventories.Where(s => s.OutletId == StoreId)
            //             select lp).Include(q => q.Product).ThenInclude(ti => ti.ProductCat)
            //            .Include(i => i.Outlet)).ToList();
            //for (int i = 0; i < products.Count(); i++)
            //{
            //  products[i].Product.Spec = db.Specialisations.Where(w => w.ProdId == products[i].ProductId).ToList();
            //}
            //var products = from u in db.LocalInventories join uv in db.Products on u.ProductId equals uv.ProductId join sp in db.Specialisations on u.ProductId equals sp.ProdId select new { u.ProductId,uv.ProductName,u.SafetyLevel,u.ReorderLevel,u.CurrentStock,sp.SpecName,sp.SpecValue};
            //var products = from u in db.LocalInventories join uv in db.Products on u.ProductId equals uv.ProductId join sp in db.Specialisations on uv.ProductId equals sp.ProdId into st2
            //from sp in st2.DefaultIfEmpty() select new JoinModel.InventoryJoin { local = u, prod = uv, spec = sp };
            //ViewBag.inventoryproducts = products;
            return View(Mymodel);
        }


    public IActionResult Reports()
    {
        List<string> imagesList = new List<string>();
        //var products = (from c in Context.Bill_Items
        //                group c by new { c.Product_Id } into grouping
        //                select new
        //                {
        //                    ClientId = grouping.Key.Product_Id,
        //                    //ClientName = grouping.Key.clientName,
        //                    Count = grouping.Count()
        //                }).ToList();
        ViewBag.result = imagesList;
        ViewBag.results = imagesList;
        return View();
    }

    public IActionResult GetReports(IFormCollection form)
    {
        //List<Search> imagesList = new List<Search>();
        //ViewBag.result = form["select"];
        int Id = Convert.ToInt32((User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Actor)?.Value).ToString());
        var date1 = Convert.ToDateTime(form["date1"]);
        var date2 = Convert.ToDateTime(form["date2"]);
        //ViewBag.sad = date1.ToShortDateString();
        //var bills = Context.Bills.Where(x => x.BillDate >= date1 && x.BillDate <= date2);
        var bills = (from a in db.Bill where a.Date >= date1 && a.Date <= date2 && a.Staff.OutletId == Id select a.BillId).ToList();
        Dictionary<int, int> asd = new Dictionary<int, int>();
        Dictionary<int, int> asd1 = new Dictionary<int, int>();

        total = 0;
        var pros = db.BillDetails.Where(x => bills.Contains(x.BillId)).GroupBy(n => n.ProductId)
                            .Select(g => new { CategoryName = g.Key }).ToList();

        foreach (var pro in pros)
        {
            asd.Add(pro.CategoryName, 0);

        }
        //return View(imagesList);
        var sad = db.BillDetails.Where(x => bills.Contains(x.BillId)).ToList();
        foreach (var i in pros)
        {
            foreach (var j in sad)
            {
                if (i.CategoryName == j.ProductId)
                {
                    asd[i.CategoryName] += j.Quantity;
                    total += (j.Quantity * j.Amount);

                }
            }
        }
        ViewData["results"] = asd;



        total = 0;
        var pros1 = db.BillDetails.GroupBy(n => n.Product.Cat_Id)
                            .Select(g => new { CategoryName = g.Key }).ToList();
        foreach (var pro in pros1)
        {
            asd1.Add(pro.CategoryName, 0);

        }
        var sad1 = db.BillDetails.Where(x => bills.Contains(x.BillId)).Include(x => x.Product).ToList();
        foreach (var i in pros1)
        {
            foreach (var j in sad1)
            {
                if (i.CategoryName == j.Product.Cat_Id)
                {
                    asd1[i.CategoryName] += j.Quantity;
                    total += (j.Quantity * j.Amount);

                }
            }
            ViewData["result"] = asd1;
        }
        //for (int i = 0; i < pros.ToList().Count; i++)
        //{     
        //    imagesList.Add(new Search { Id = pros[i].CategoryName, Count = pros[i].Count });
        //}
        ////return View(imagesList);
        //ViewData["result"] = imagesList;


        ViewData["products"] = db.Product.Include(x=>x.ProductCat).ToList();
            ViewData["spec"] = db.Spec.ToList();
            ViewData["category"] = db.Category.ToList();
        ViewBag.total = total;
        return View("Reports");
        }
    }
}
