using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Truck
    {
        [Key]
        public int truck_id { get; set; }
		public string manufacture_company { get; set; }
		public string manufacture_date { get; set; }
		public int model { get; set; }
		public int engine_id { get; set; }
		public string plate_number { get; set; }
		public int gear_id { get; set; }
		public string body_serial_number { get; set; }
		public double length { get; set; }
		public double width { get; set; }
		public int color_id { get; set; }
		public double free_weight { get; set; }
		public double full_weight { get; set; }
		
		public int is_deleted { get; set; }
		public string deleted_at { get; set; }
		public char TRIAL424 { get; set; }

	}
}
