using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Retail.Models.DBModels
{
    public class Gst
    {
        [Key]
        public string GstId { get; set; }
        public string Percent { get; set; }
        public string Category { get; set; }


    }
}
