using Retail.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.CustomModels
{
    public class JoinModel
    {
        public LocalInventory local { get; set; }
        public Product prod { get; set; }
        public Spec spec { get; set; }
    }
}
