using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public DateTime Date { get; set; }
        public double TotalPayable { get; set; }
        public string PaymentMethod { get; set; }
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public double TotalDiscount { get; set; }
    }
}
