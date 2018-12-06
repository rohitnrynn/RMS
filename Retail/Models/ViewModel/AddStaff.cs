using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.ViewModel
{
  public class AddStaff
  {
    [Required]
    public string Username { get; set; }

    [RegularExpression(@"[a-zA-Z]{5,40}$", ErrorMessage = "Password must contain only alphabets\nPassword length must be minimum 5", MatchTimeoutInMilliseconds = 1000)]
    public string Password { get; set; }

    [Required]
    public DateTime? Age { get; set; }

    [Required]
    public string Role { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [RegularExpression(@"[0-9]{10}$", ErrorMessage = "Phone number must be 10 digit number", MatchTimeoutInMilliseconds = 1000)]
    public string PhoneNumber { get; set; }

  }
}
