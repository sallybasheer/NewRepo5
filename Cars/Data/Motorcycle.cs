using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class Motorcycle
    {
		[Key]
		public int motorcycle_id { get; set; }
		public string manufacture_company { get; set; }
		public string manufcture_date { get; set; }
		public string model { get; set; }
		public int engine_id { get; set; }
		public string plate_number { get; set; }
		public int gear_id { get; set; }
		public string body_serial_number { get; set; }
		public double  tier_diameter { get; set; }
		public double length { get; set; }
	
		public int is_deleted { get; set; }
		public string deleted_at { get; set; }
		public char TRIAL424 { get; set; }
	}
}
