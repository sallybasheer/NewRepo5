using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Gear
    {
        [Key]
        public int gear_id { get; set; }
        public string gear_type { get; set; }
        public char TRIAL424 { get; set; }
    }
}
