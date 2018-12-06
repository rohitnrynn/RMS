using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class CentralInventory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]     
        public string ProductId { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{10}$", ErrorMessage = "Phone number must be 10 digit number", MatchTimeoutInMilliseconds = 1000)]
        public string PhoneNumber { get; set; }

    }
}
