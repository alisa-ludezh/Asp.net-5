using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sheduler.Models
{
    public class StructureOfData
    {
        [ScaffoldColumn(false)]
        public string PersonID { get; set; }

        public Person Person { get; set; }
        [Required]
        public DayTimeType Date1 { get; set; }
        public DayTimeType Date2 { get; set; }
        public DayTimeType Date3 { get; set; }
        public DayTimeType Date4 { get; set; }
        public DayTimeType Date5 { get; set; }
        public DayTimeType Date6 { get; set; }
        public DayTimeType Date7 { get; set; }
        public DayTimeType Date8 { get; set; }
        public DayTimeType Date9 { get; set; }
        public DayTimeType Date10 { get; set; }

    }
}
