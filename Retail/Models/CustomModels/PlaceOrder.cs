using Retail.Models.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.CustomModels
{
    public class PlaceOrder
    {
        public LocalInventory Product { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Atleast one number of item to ordered")]
        public int Quantity { get; set; }

        public bool IsSelected { get; set; }

        public PlaceOrder()
        {
            Product = new LocalInventory();
            IsSelected = false;
            Quantity = Product.ReorderLevel + 1;
        }
    }
}
