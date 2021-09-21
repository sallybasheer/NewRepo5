using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class sqlite_sequence
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string name { get; set; }
        public string seq { get; set; }
	      public char TRIAL424 { get; set; }
    
    }
}
