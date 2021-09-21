using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Car
    {
        [Key]
        public int car_id { get; set; }
	    public string manufacture_company { get; set; }
		public string manufacture_date { get; set; }
	    public string model { get; set; }
	    public int engine_id { get; set; }
		 public string plate_number { get; set; }
		 public int gear_id { get; set; }
	     public string body_serial_number { get; set; }
		 public Single  length { get; set; }
		 public Single width { get; set; }
		 public int color_id { get; set; }
		 public int seats { get; set; }
		 public int is_leather { get; set; }
		 public int is_deleted { get; set; }
		 public string deleted_at { get; set; }
		 public char TRIAL421 { get; set; }



	
    }
}
