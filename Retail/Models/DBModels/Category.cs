using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models.DBModels
{
    public class Category
    {
        [Key]
        public int Cat_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
