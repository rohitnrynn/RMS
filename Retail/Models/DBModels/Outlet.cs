using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class Outlet
    {
        [Key]
        public int OutletId { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{10}$", ErrorMessage = "Phone number must be 10 digit number", MatchTimeoutInMilliseconds = 1000)]
        public string PhoneNumber { get; set; }

    }
}
