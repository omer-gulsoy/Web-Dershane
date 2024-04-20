﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Teacher
	{
        [Key]
        public int Teacher_Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int TC { get; set; }
        public DateTime BirthDay { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
        public string? PrePhotoURL { get; set; }
        public string? DetailPhotoURL { get; set; }
        public string? PreBio { get; set; }
        public string? DetailBio { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Lesson")]
        public int Lesson_Id { get; set; }
        public Lesson? Lesson { get; set; }

		[ForeignKey("City")]
		public int City_Id { get; set; }
		public City? City { get; set; }
		public List<Schedule>? Schedules { get; set; }
    }
}
