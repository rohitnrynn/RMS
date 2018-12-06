using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class BillDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Bill")]
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public int GST { get; set; }
    }
}
