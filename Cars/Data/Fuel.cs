using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Fuel
    {
        [Key]
        public int fuel_id { get; set; }
        public string fuel_type { get; set; }
        public char TRIAL424 { get; set; }

    }
}
