using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Engine
    {
       
        [Key]
     public int engine_id { get; set; }
        public string manufacture_company { get; set; }
        public string manufacture_date { get; set; }
        public string model { get; set; }
        public int fuel_id { get; set; }
        public int capacity { get; set; }
        public int cylinders { get; set; }
        public int is_deleted { get; set; }
        public string deleted_at { get; set; }
        public char TRIAL424 { get; set; }
    }
}
