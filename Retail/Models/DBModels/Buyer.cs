using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerPhone { get; set; }
        public string BuyerEmail { get; set; }
    }
}
