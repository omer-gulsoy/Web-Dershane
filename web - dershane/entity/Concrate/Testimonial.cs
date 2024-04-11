﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Testimonial
	{
		[Key]
		public int Testimonial_Id { get; set; }
		public string? Comment { get; set; }
		public string? Name { get; set; }
		public string? Role { get; set; }
		public bool Status { get; set; }
	}
}
