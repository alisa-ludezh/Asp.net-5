using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sheduler.Models
{
    public class Person
    {
        public string PersonFIO { get; set; }
        public int TabNom { get; set; }
        public string Job { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string PersonUID { get; set; }
    }
}
