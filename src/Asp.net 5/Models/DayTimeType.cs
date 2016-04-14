using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sheduler.Models
{
    public class DayTimeType
    {
        [ScaffoldColumn(false)]
        public byte Code { get; set; }

        public string Name { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        

        public string ColorStr { get; set; }
    }
}
