using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Retail.Models.CustomModels;
using Retail.Models.DBModels;

namespace Retail.Models.ViewModel
{
    public class CustomModelBag
    {
        public List<Outlet> LocalStores { get; set; }
        public List<LocalInventory> local { get; set; }
        public List<Product> Product { get; set; }
        public List<PlaceOrder> LocalProducts { get; set; }
        public Product NewProduct { get; set; }
        public Buyer Buyer { get; set; }
        public BillDetails BillDetails { get; set; }
        public Bill Bill { get; set; }
        public List<Product> BillProducts { get; set; }
        public int TotalAmount { get; set; }
    }
}
