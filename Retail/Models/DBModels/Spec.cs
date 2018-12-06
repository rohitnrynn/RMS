using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class Spec
    {
        
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProdId { get; set; }
        public Product Product { get; set; }

        [Required]
        public string SpecName { get; set; }

        [Required]
        public string SpecValue { get; set; }

    }
}
