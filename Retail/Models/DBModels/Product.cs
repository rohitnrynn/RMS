using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retail.Models.DBModels
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }

        public string Rate { get; set; }
        [Required]
        public string Company { get; set; }

        [ForeignKey("ProductCat")]
        public int Cat_Id { get; set; }
        public Category ProductCat { get; set; }
        [ForeignKey("Gst")]
        public string GstId { get; set; }


        [NotMapped]
        public List<Spec> Spec { get; set; }

        public Product()
        {
            ProductCat = new Category();
            Spec = new List<Spec>();
        }
    }
}
