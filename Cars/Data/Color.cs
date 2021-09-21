using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Color
    {
        
       
         [Key]
        public int color_id { get; set; }
        public string color_name { get; set; }
        public char TRIAL424 { get; set; }
    }
}
