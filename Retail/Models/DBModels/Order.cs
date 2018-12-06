using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
    }
}
