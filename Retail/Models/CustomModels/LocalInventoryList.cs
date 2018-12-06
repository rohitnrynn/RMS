using Retail.Models.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.CustomModels
{
    public class LocalInventoryList
    {
        [Key]
        public int LocalInventoryId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ReorderLevel { get; set; }
        public int SafetyLevel { get; set; }
        public int CurrentStock { get; set; }
        [ForeignKey("Outlet")]
        public int OutletId { get; set; }
        public Outlet Outlet { get; set; }
    }
}
